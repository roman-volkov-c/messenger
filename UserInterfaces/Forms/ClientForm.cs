using System;
using System.Windows.Forms;

using BusinessLogic.Controller;

namespace UserInterfaces.Forms
{
	internal partial class ClientForm : Form
	{
		private readonly ControllingForm controllingForm;
		private bool isFirstClick;
		private Messaging messaging;

		internal ClientForm(ControllingForm controllingForm)
		{
			InitializeComponent();

			this.controllingForm = controllingForm;
			isFirstClick = true;
			Left = controllingForm.Left;
			Top = controllingForm.Top;

			controllingForm.Hide();
		}

		private void ButtonSend_Click(object sender, EventArgs e)
		{
			if (!isFirstClick)
			{
				messaging.SendMessage(textBoxInput.Text);
				textBoxInput.Text = string.Empty;
				TextBoxInput_Leave(this, EventArgs.Empty);
			}
		}

		private void TextBoxInput_Leave(object sender, EventArgs e)
		{
			if (textBoxInput.Text == string.Empty)
			{
				isFirstClick = true;
				textBoxInput.TextAlign = HorizontalAlignment.Center;
				textBoxInput.Text = "Введите сообщение здесь";
			}
		}

		private void TextBoxInput_Enter(object sender, EventArgs e)
		{
			if (isFirstClick)
			{
				isFirstClick = false;
				textBoxInput.Text = string.Empty;
				textBoxInput.TextAlign = HorizontalAlignment.Left;
			}
		}

		private void ClientForm_Shown(object sender, EventArgs e)
		{
			Messaging? messaging = UserQuery.CurrentMessaging;

			if (messaging is null)
			{
				Close();
				_ = MessageBox.Show("Возникли ошибки при подключении службы получения/отправки сообщений.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				this.messaging = messaging;
				messaging.NewMessageArrive += Messaging_NewMessageArrive;
			}
		}

		private void Messaging_NewMessageArrive(string message) => Invoke((Action)(() => labelOutput.Text += message + '\n'));

		private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			_ = UserQuery.TryRemoveUser();
			controllingForm.Show();
			controllingForm.Left = Left;
			controllingForm.Top = Top;
		}

		private void CheckBoxTopMost_CheckedChanged(object sender, EventArgs e) => TopMost = checkBoxTopMost.Checked;

		private void ButtonClear_Click(object sender, EventArgs e) => labelOutput.Text = string.Empty;
	}
}