using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;

using MainServer.Servers;
using MainServer.Users;

namespace MainServer
{
	internal static class Program
	{
		internal static readonly IPAddress serverIPAddress = IPAddress.Parse("127.0.0.1");
		internal static readonly EndPoint serverTCPEndPoint = new IPEndPoint(serverIPAddress, 8005);
		internal static readonly EndPoint serverUDPEndPoint = new IPEndPoint(serverIPAddress, 5555);
		internal static readonly List<OnlineUser> onlineUsers = new();
		internal static readonly object onlineUsersLocker = new();
		internal static readonly object consoleOutputLocker = new();

		private static void Main()
		{
			Console.WriteLine("Сервер был запущен");

			new Thread(TCPServer.Start).Start();
			new Thread(UDPServer.Start).Start();
		}
	}
}
