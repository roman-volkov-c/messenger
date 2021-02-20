namespace ServerCommunication
{
	public class User
	{
		public User() : this(string.Empty, string.Empty, null, string.Empty, string.Empty) { }

		public User(string lastName, string firstName, string? middleName, string login, string password)
		{
			LastName = lastName;
			FirstName = firstName;
			MiddleName = middleName;
			Login = login;
			Password = password;
		}

		public string LastName
		{
			get; set;
		}

		public string FirstName
		{
			get; set;
		}

		public string? MiddleName
		{
			get; set;
		}

		public string Login
		{
			get; set;
		}

		public string Password
		{
			get; set;
		}

		public override string ToString() => $"{LastName} {FirstName}{(MiddleName is null ? " " : $" {MiddleName} ")}{Login} {Password}";
	}
}