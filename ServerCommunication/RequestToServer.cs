using System;
using System.Net;

namespace ServerCommunication
{
	public class RequestToServer
	{
		public RequestToServer() : this(new User(), Request.Add | Request.Remove) { }

		public RequestToServer(User user, Request request) : this(user, request, null, null) { }

		public RequestToServer(User user, Request request, EndPoint? listeningEP, EndPoint? sendingEP)
		{
			User = user;
			CurrentRequest = request;
			ListeningEP = listeningEP?.ToString();
			SendingEP = sendingEP?.ToString();
		}

		public User User
		{
			get; set;
		}

		public Request CurrentRequest
		{
			get; set;
		}

		public string? ListeningEP
		{
			get; set;
		}

		public string? SendingEP
		{
			get; set;
		}

		/// <summary>
		/// Преобразует <see cref="ListeningEP"/> в <see cref="EndPoint"/>.
		/// </summary>
		/// <returns> <see cref="EndPoint"/> или <see langword="null"/>. </returns>
		public EndPoint? GetListeningEP() => GetEndPoint(ListeningEP);

		/// <summary>
		/// Преобразует <see cref="SendingEP"/> в <see cref="EndPoint"/>.
		/// </summary>
		/// <returns> <see cref="EndPoint"/> или <see langword="null"/>. </returns>
		public EndPoint? GetSendingEP() => GetEndPoint(SendingEP);

		private EndPoint? GetEndPoint(string? endPoint)
		{
			if (endPoint is not null)
			{
				try
				{
					string[] endPoingArr = endPoint.Split(':');
					return new IPEndPoint(IPAddress.Parse(endPoingArr[0]), int.Parse(endPoingArr[1]));
				}
				catch (Exception) { }
			}
			
			return null;
		}

		public enum Request : byte
		{
			Create,
			Add,
			Remove
		}
	}
}