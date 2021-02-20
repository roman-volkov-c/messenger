using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

using MainServer.Users;

using static MainServer.Program;

namespace MainServer.Servers
{
	internal static class UDPServer
	{
		internal static void Start()
		{
			using Socket serverSocket = new(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			serverSocket.Bind(serverUDPEndPoint);

			while (true)
			{
				StringBuilder input = new();
				EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
				byte[] buffer = new byte[256];

				do
				{
					int bytes = serverSocket.ReceiveFrom(buffer, ref remoteEndPoint);
					_ = input.Append(Encoding.UTF8.GetString(buffer, 0, bytes));
				} while (serverSocket.Available > 0);

				OnlineUser? sender;
				lock (onlineUsersLocker)
					sender = onlineUsers.SingleOrDefault(x => x.SendingEndPoint.Equals(remoteEndPoint));

				string answer = sender is null
					? $"{DateTime.Now.ToShortTimeString()} | {input}"
					: $"{DateTime.Now.ToShortTimeString()} | {sender.Login}: {input}";
				byte[] bytesOfAnswer = Encoding.UTF8.GetBytes(answer);

				lock (onlineUsersLocker)
					foreach (OnlineUser onlineUser in onlineUsers)
						_ = serverSocket.SendTo(bytesOfAnswer, onlineUser.ListeningEndPoint);

				lock (consoleOutputLocker)
					Console.WriteLine(answer);
			}
		}
	}
}