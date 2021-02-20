using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

using MainServer.Users;

using ServerCommunication;

using static MainServer.Program;

namespace MainServer.Servers
{
	internal static class TCPServer
	{
		internal static void Start()
		{
			using Socket serverSocket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

			serverSocket.Bind(serverTCPEndPoint);
			serverSocket.Listen(3);

			while (true)
			{
				using Socket clientSocket = serverSocket.Accept();
				List<byte> request = new();
				byte[] buffer = new byte[256];

				do
				{
					int bytes = clientSocket.Receive(buffer);
					request.AddRange(buffer[0..bytes]);
				} while (clientSocket.Available > 0);

				Utf8JsonReader utf8Reader = new(request.ToArray());
				_ = clientSocket.Send(JsonSerializer.SerializeToUtf8Bytes(GetMessage(JsonSerializer.Deserialize<RequestToServer>(ref utf8Reader))));
			}
		}

		private static ServerAnswer GetMessage(RequestToServer request) => request.CurrentRequest switch
		{
			RequestToServer.Request.Add => TryAddUser(request.User, request.GetListeningEP(), request.GetSendingEP()),
			RequestToServer.Request.Create => TryCreateUser(request.User),
			RequestToServer.Request.Remove => TryRemoveUser(request.User),
			_ => new(false, "Неподдерживаемая операция.")
		};

		private static ServerAnswer TryCreateUser(User user)
		{
			bool success = UserManager.TryCreateUserManager(user, out string errorText)?.TrySave().Result ?? false;

			WriteMessageWithFlag($"Попытка создать нового пользователя \"{user}\":", success);
			return new(success, success ? string.Empty : (errorText == string.Empty ? "Пользователь с таким логином уже существует." : errorText));
		}

		private static ServerAnswer TryAddUser(User user, EndPoint? listeningEP, EndPoint? sendingEP)
		{
			User? loadedUser = UserManager.TryLoad(user.Login).Result;
			string errorText = loadedUser is null
				? "Пользователь не существует."
				: loadedUser.Password.Equals(user.Password)
					? listeningEP is null || sendingEP is null
						? "Указаны некорректные конечные точки."
						: string.Empty
					: "Некорректный пароль.";

			if (errorText == string.Empty)
			{
				if (onlineUsers.SingleOrDefault(x => x.Login.Equals(user.Login)) is null)
				{
					lock(onlineUsersLocker)
						onlineUsers.Add(new OnlineUser(user.Login, listeningEP, sendingEP));

					SendToUDPSocket($"Пользователь \"{user.Login}\" подключился");
				}
				else
				{
					errorText = "Пользователь уже онлайн.";
				}
			}

			WriteMessageWithFlag($"Попытка подключить пользователя \"{user.Login} ({listeningEP}) ({sendingEP})\":", errorText == string.Empty);
			return new(errorText == string.Empty, errorText);
		}

		private static ServerAnswer TryRemoveUser(User user)
		{
			OnlineUser? onlineUser = onlineUsers.SingleOrDefault(x => x.Login.Equals(user.Login));
			bool success = onlineUser is not null;

			if (success)
			{
				lock (onlineUsersLocker)
					_ = onlineUsers.Remove(onlineUser);

				SendToUDPSocket($"Пользователь \"{user.Login}\" отключился.");
			}

			WriteMessageWithFlag($"Попытка отключить пользователя \"{user.Login}\":", success);
			return new(success, success ? string.Empty : "Пользователь не онлайн.");
		}

		private static void WriteMessageWithFlag(string message, bool success)
		{
			lock (consoleOutputLocker)
			{
				Console.Write(message);
				Console.ForegroundColor = success ? ConsoleColor.Green : ConsoleColor.Red;
				Console.WriteLine(success ? " Успешно." : " Неудачно.");
				Console.ResetColor();
			}
		}

		private static void SendToUDPSocket(string message)
		{
			using Socket socket = new(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

			socket.Bind(new IPEndPoint(IPAddress.Any, 0));
			_ = socket.SendTo(Encoding.UTF8.GetBytes($"Сервер: {message}"), serverUDPEndPoint);
		}
	}
}