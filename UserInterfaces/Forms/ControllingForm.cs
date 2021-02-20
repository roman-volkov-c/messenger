using System;
using System.Drawing;
using System.Windows.Forms;

using BusinessLogic.Controller;

namespace UserInterfaces.Forms
{
	internal partial class ControllingForm : Form
	{
		#region Private Definitions

		private readonly RowStyle fullNameRow;
		private readonly RowStyle repeatedPasswordRow;
		private readonly float normalHeightOfFullNameRow;
		private readonly float normalHeightOfRepeatedPasswordRow;
		private readonly Color selectedColor;
		private readonly Color selectedColorHover;
		private readonly int minHeight;
		private readonly int minHeightWhenAuthorize;
		private Action action;

		#endregion

		public ControllingForm()
		{
			InitializeComponent();

			TableLayoutRowStyleCollection rows = table.RowStyles;
			fullNameRow = rows[1];
			normalHeightOfFullNameRow = fullNameRow.Height;
			repeatedPasswordRow = rows[4];
			normalHeightOfRepeatedPasswordRow = repeatedPasswordRow.Height;

			minHeight = MinimumSize.Height;
			minHeightWhenAuthorize = minHeight - (int)(minHeight * (normalHeightOfFullNameRow + normalHeightOfRepeatedPasswordRow) / 100);

			selectedColor = buttonRegister.BackColor;
			selectedColorHover = buttonRegister.FlatAppearance.MouseOverBackColor;

			ButtonAuthorize_Click(this, EventArgs.Empty);
		}

		private enum Action : byte
		{
			Register,
			Authorize
		}

		private void ButtonAuthorize_Click(object sender, EventArgs e)
		{
			if (action is not Action.Authorize)
			{
				float totalHeight = (fullNameRow.Height + repeatedPasswordRow.Height) / 100;
				fullNameRow.Height = 0;
				textBoxFullName.Visible = false;
				repeatedPasswordRow.Height = 0;
				textBoxRepeatedPassword.Visible = false;

				MinimumSize = new Size(MinimumSize.Width, minHeightWhenAuthorize);
				Height -= (int)(Height * totalHeight);
				Text = "Авторизация";

				buttonRegister.Cursor = Cursors.Hand;
				buttonRegister.BackColor = buttonAuthorize.BackColor;
				buttonRegister.FlatAppearance.MouseOverBackColor = buttonAuthorize.FlatAppearance.MouseOverBackColor;
				buttonAuthorize.Cursor = Cursors.Arrow;
				buttonAuthorize.BackColor = selectedColor;
				buttonAuthorize.FlatAppearance.MouseOverBackColor = selectedColorHover;
				buttonPerformAction.Text = "Авторизоваться";

				action = Action.Authorize;
			}
		}

		private void ButtonRegister_Click(object sender, EventArgs e)
		{
			if (action is not Action.Register)
			{
				Height = (int)(Height / (1 - (normalHeightOfFullNameRow + normalHeightOfRepeatedPasswordRow) / 100));
				MinimumSize = new Size(MinimumSize.Width, minHeight);
				Text = "Регистрация";

				fullNameRow.Height = normalHeightOfFullNameRow;
				textBoxFullName.Visible = true;
				repeatedPasswordRow.Height = normalHeightOfRepeatedPasswordRow;
				textBoxRepeatedPassword.Visible = true;

				buttonAuthorize.Cursor = Cursors.Hand;
				buttonAuthorize.BackColor = buttonRegister.BackColor;
				buttonAuthorize.FlatAppearance.MouseOverBackColor = buttonRegister.FlatAppearance.MouseOverBackColor;
				buttonRegister.Cursor = Cursors.Arrow;
				buttonRegister.BackColor = selectedColor;
				buttonRegister.FlatAppearance.MouseOverBackColor = selectedColorHover;
				buttonPerformAction.Text = "Зарегистрироваться";

				action = Action.Register;
			}
		}

		private void ButtonPerformAction_Click(object sender, EventArgs e)
		{
			errorProvider.Clear();

			string errorText = string.Empty;
			Control? control = null;

			switch (action)
			{
				case Action.Register:
					if (textBoxPassword.Text.Equals(textBoxRepeatedPassword.Text))
					{
						control = UserQuery.TryCreateUser(textBoxFullName.Text, textBoxLogin.Text, textBoxPassword.Text, out errorText)
							? null
							: errorText.Contains("Логин", StringComparison.OrdinalIgnoreCase)
								? textBoxLogin
								: errorText.Contains("Пароль", StringComparison.OrdinalIgnoreCase)
									? textBoxPassword
									: textBoxFullName;
					}
					else
					{
						errorText = "Пароли не совпадают.";
						control = textBoxRepeatedPassword;
					}

					if (control is null)
						ButtonAuthorize_Click(this, EventArgs.Empty);

					break;
				case Action.Authorize:
					if (UserQuery.TryAddUser(textBoxLogin.Text, textBoxPassword.Text, out errorText))
						new ClientForm(this).Show();
					else
						control = errorText.Contains("Пароль", StringComparison.OrdinalIgnoreCase) ? textBoxPassword : textBoxLogin;

					break;
			}

			if (control is not null)
				errorProvider.SetError(control, errorText);
		}
	}
}