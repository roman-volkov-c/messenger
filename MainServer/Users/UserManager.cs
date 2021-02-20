using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using ServerCommunication;

namespace MainServer.Users
{
	internal class UserManager
	{
		private readonly User User;

		private UserManager(User user) => User = user;

		internal static UserManager? TryCreateUserManager(User user, out string errorText)
		{
			errorText = Regex.IsMatch(user.LastName, "^[А-я]{5,15}$")
				? Regex.IsMatch(user.FirstName, "^[А-я]{2,15}$")
					? Regex.IsMatch(user.MiddleName ?? "ааааа", "^[А-я]{5,15}$")
						? Regex.IsMatch(user.Login, @"^[A-z\d]{1,20}$")
							? Regex.IsMatch(user.Password, @"^[A-z\d]{8,20}$")
								? string.Empty
								: "Пароль должен состоять из символов латинского алфавита и/или цифр (от 8 до 20)."
							: "Логин должен состоять из символов латинского алфавита и/или цифр (от 1 до 20)."
						: "Отчество должно состоять из символов русского алфавита (от 5 до 15)."
					: "Имя должно состоять из символов русского алфавита (от 2 до 15)."
				: "Фамилия должна состоять из символов русского алфавита (от 5 до 15).";

			return errorText == string.Empty ? new UserManager(user) : null;
		}

		internal static async Task<User?> TryLoad(string login)
		{
			string path = $"{login}.json";
			User? user = null;

			if (File.Exists(path))
			{
				using FileStream streamReader = new(path, FileMode.Open);
				user = await JsonSerializer.DeserializeAsync<User>(streamReader);
			}

			return user;
		}

		internal async Task<bool> TrySave()
		{
			string path = $"{User.Login}.json";
			bool fileNotExists = !File.Exists(path);

			if (fileNotExists)
			{
				using FileStream streamWriter = new(path, FileMode.Create);
				await JsonSerializer.SerializeAsync(streamWriter, User);
			}
			
			return fileNotExists;
		}
	}
}