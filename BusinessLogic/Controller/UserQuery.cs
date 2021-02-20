using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;

using ServerCommunication;

namespace BusinessLogic.Controller
{
	public static class UserQuery
	{
		internal static readonly IPAddress ServerIP = IPAddress.Parse("127.0.0.1");

		private static readonly EndPoint TCPServerEP = new IPEndPoint(ServerIP, 8005);

		public static Messaging? CurrentMessaging
		{
			get;
			private set;
		}

		public static bool TryCreateUser(string fullName, string login, string password, out string errorText)
		{
			string[] fullNameArr = fullName.Split();
			if (fullNameArr.Length is 2 or 3)
			{
				try
				{
					ServerAnswer answer = EstablishConnection(new RequestToServer(
						new User(fullNameArr[0], fullNameArr[1], fullNameArr.Length is 3 ? fullNameArr[2] : null, login, password),
						RequestToServer.Request.Create));

					errorText = answer.CauseOfProblems;
					return answer.SuccessOfOperation;
				}
				catch (Exception)
				{
					errorText = "Возникли проблемы при подключении к серверу.";
				}
			}
			else
			{
				errorText = "В ФИО допускается от 1-го до 2-х пробелов.";
			}

			return false;
		}

		public static bool TryAddUser(string login, string password, out string errorText)
		{
			if (CurrentMessaging is null)
			{
				Socket UdpListener = new(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
				Socket UdpSender = new(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
				UdpListener.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 0));
				UdpSender.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 0));

				try
				{
					ServerAnswer answer = EstablishConnection(new RequestToServer(
						new User(string.Empty, string.Empty, null, login, password),
						RequestToServer.Request.Add,
						UdpListener.LocalEndPoint,
						UdpSender.LocalEndPoint));
					errorText = answer.CauseOfProblems;

					if (answer.SuccessOfOperation)
					{
						CurrentMessaging = new Messaging(UdpListener, UdpSender, login);
						_ = CurrentMessaging.StartUDPListenerAsync();

						return true;
					}
				}
				catch (Exception)
				{
					errorText = "Возникли проблемы при подключении к серверу.";
				}

				UdpListener.Dispose();
				UdpSender.Dispose();
			}
			else
			{
				errorText = "Сессия текущего пользователя не закончена.";
			}
			
			return false;
		}

		public static bool TryRemoveUser()
		{
			bool success = false;

			if (CurrentMessaging is not null)
			{
				try
				{
					success = EstablishConnection(new RequestToServer(
						new User(string.Empty, string.Empty, null, CurrentMessaging.Login, string.Empty),
						RequestToServer.Request.Remove)).SuccessOfOperation;
				}
				catch (Exception) { }

				CurrentMessaging.DisposeSockets();
				CurrentMessaging = null;
			}
			
			return success;
		}

		private static ServerAnswer EstablishConnection(RequestToServer request)
		{
			using Socket clientSocket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			byte[] buffer = new byte[256];
			List<byte> answer = new();

			clientSocket.Connect(TCPServerEP);
			_ = clientSocket.Send(JsonSerializer.SerializeToUtf8Bytes(request));

			do
			{
				int bytes = clientSocket.Receive(buffer);
				answer.AddRange(buffer[0..bytes]);
			} while (clientSocket.Available > 0);

			Utf8JsonReader utf8Reader = new(answer.ToArray());
			return JsonSerializer.Deserialize<ServerAnswer>(ref utf8Reader);
		}
	}
}