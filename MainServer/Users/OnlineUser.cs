using System.Net;

namespace MainServer.Users
{
	internal class OnlineUser
	{
		internal readonly string Login;
		internal readonly EndPoint ListeningEndPoint;
		internal readonly EndPoint SendingEndPoint;

		internal OnlineUser(string login, EndPoint listeningEP, EndPoint sendingEP)
		{
			Login = login;
			ListeningEndPoint = listeningEP;
			SendingEndPoint = sendingEP;
		}
	}
}