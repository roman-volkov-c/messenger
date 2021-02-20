using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Controller
{
	public class Messaging
	{
		private static readonly EndPoint UDPServerEP = new IPEndPoint(UserQuery.ServerIP, 5555);
		private readonly Socket UDPListener;
		private readonly Socket UDPSender;

		internal readonly string Login;

		internal Messaging(Socket listener, Socket sender, string login)
		{
			UDPListener = listener;
			UDPSender = sender;
			Login = login;
		}

		public event Action<string>? NewMessageArrive;

		public void SendMessage(string message) => UDPSender.SendTo(Encoding.UTF8.GetBytes(message), UDPServerEP);

		internal void DisposeSockets()
		{
			UDPListener.Dispose();
			UDPSender.Dispose();
		}

		internal async Task StartUDPListenerAsync() => await Task.Run(() =>
		{
			while (true)
			{
				StringBuilder input = new();
				byte[] buffer = new byte[256];
				EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);

				do
				{
					int bytes = UDPListener.ReceiveFrom(buffer, ref remoteEndPoint);
					_ = input.Append(Encoding.UTF8.GetString(buffer, 0, bytes));
				} while (UDPListener.Available > 0);

				if (remoteEndPoint.Equals(UDPServerEP))
					NewMessageArrive?.Invoke(input.ToString());
			}
		});
	}
}