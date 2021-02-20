
namespace UserInterfaces.Forms
{
	partial class ControllingForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControllingForm));
			this.table = new System.Windows.Forms.TableLayoutPanel();
			this.buttonAuthorize = new System.Windows.Forms.Button();
			this.buttonRegister = new System.Windows.Forms.Button();
			this.buttonPerformAction = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxFullName = new System.Windows.Forms.TextBox();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.textBoxRepeatedPassword = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.table.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// table
			// 
			this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(45)))), ((int)(((byte)(161)))));
			this.table.ColumnCount = 3;
			this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.table.Controls.Add(this.buttonAuthorize, 0, 0);
			this.table.Controls.Add(this.buttonRegister, 2, 0);
			this.table.Controls.Add(this.buttonPerformAction, 0, 5);
			this.table.Controls.Add(this.label1, 1, 1);
			this.table.Controls.Add(this.label2, 1, 2);
			this.table.Controls.Add(this.label3, 1, 3);
			this.table.Controls.Add(this.label4, 1, 4);
			this.table.Controls.Add(this.textBoxFullName, 2, 1);
			this.table.Controls.Add(this.textBoxLogin, 2, 2);
			this.table.Controls.Add(this.textBoxPassword, 2, 3);
			this.table.Controls.Add(this.textBoxRepeatedPassword, 2, 4);
			this.table.Controls.Add(this.pictureBox1, 0, 1);
			this.table.Controls.Add(this.pictureBox2, 0, 2);
			this.table.Controls.Add(this.pictureBox3, 0, 3);
			this.table.Controls.Add(this.pictureBox4, 0, 4);
			this.table.Dock = System.Windows.Forms.DockStyle.Fill;
			this.table.Location = new System.Drawing.Point(0, 0);
			this.table.Name = "table";
			this.table.RowCount = 6;
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.table.Size = new System.Drawing.Size(759, 691);
			this.table.TabIndex = 0;
			// 
			// buttonAuthorize
			// 
			this.buttonAuthorize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(60)))), ((int)(((byte)(232)))));
			this.table.SetColumnSpan(this.buttonAuthorize, 2);
			this.buttonAuthorize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAuthorize.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonAuthorize.FlatAppearance.BorderSize = 0;
			this.buttonAuthorize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(50)))), ((int)(((byte)(209)))));
			this.buttonAuthorize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAuthorize.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonAuthorize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
			this.buttonAuthorize.Location = new System.Drawing.Point(0, 0);
			this.buttonAuthorize.Margin = new System.Windows.Forms.Padding(0);
			this.buttonAuthorize.Name = "buttonAuthorize";
			this.buttonAuthorize.Size = new System.Drawing.Size(378, 138);
			this.buttonAuthorize.TabIndex = 0;
			this.buttonAuthorize.Text = "Авторизация";
			this.buttonAuthorize.UseVisualStyleBackColor = false;
			this.buttonAuthorize.Click += new System.EventHandler(this.ButtonAuthorize_Click);
			// 
			// buttonRegister
			// 
			this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(60)))), ((int)(((byte)(232)))));
			this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttonRegister.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonRegister.FlatAppearance.BorderSize = 0;
			this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(60)))), ((int)(((byte)(232)))));
			this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRegister.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
			this.buttonRegister.Location = new System.Drawing.Point(378, 0);
			this.buttonRegister.Margin = new System.Windows.Forms.Padding(0);
			this.buttonRegister.Name = "buttonRegister";
			this.buttonRegister.Size = new System.Drawing.Size(381, 138);
			this.buttonRegister.TabIndex = 1;
			this.buttonRegister.Text = "Регистрация";
			this.buttonRegister.UseVisualStyleBackColor = false;
			this.buttonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
			// 
			// buttonPerformAction
			// 
			this.buttonPerformAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(214)))));
			this.table.SetColumnSpan(this.buttonPerformAction, 3);
			this.buttonPerformAction.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonPerformAction.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonPerformAction.FlatAppearance.BorderSize = 0;
			this.buttonPerformAction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(81)))), ((int)(((byte)(237)))));
			this.buttonPerformAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPerformAction.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonPerformAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
			this.buttonPerformAction.Location = new System.Drawing.Point(0, 550);
			this.buttonPerformAction.Margin = new System.Windows.Forms.Padding(0);
			this.buttonPerformAction.Name = "buttonPerformAction";
			this.buttonPerformAction.Size = new System.Drawing.Size(759, 141);
			this.buttonPerformAction.TabIndex = 2;
			this.buttonPerformAction.Text = "Зарегистрироваться";
			this.buttonPerformAction.UseVisualStyleBackColor = false;
			this.buttonPerformAction.Click += new System.EventHandler(this.ButtonPerformAction_Click);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
			this.label1.Location = new System.Drawing.Point(189, 138);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(189, 103);
			this.label1.TabIndex = 3;
			this.label1.Text = "ФИО";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
			this.label2.Location = new System.Drawing.Point(189, 241);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(189, 103);
			this.label2.TabIndex = 4;
			this.label2.Text = "Логин";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
			this.label3.Location = new System.Drawing.Point(189, 344);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(189, 103);
			this.label3.TabIndex = 5;
			this.label3.Text = "Пароль";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(209)))));
			this.label4.Location = new System.Drawing.Point(189, 447);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(189, 103);
			this.label4.TabIndex = 6;
			this.label4.Text = "Повторите пароль";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxFullName
			// 
			this.textBoxFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxFullName.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxFullName.Location = new System.Drawing.Point(378, 170);
			this.textBoxFullName.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
			this.textBoxFullName.Name = "textBoxFullName";
			this.textBoxFullName.Size = new System.Drawing.Size(361, 38);
			this.textBoxFullName.TabIndex = 7;
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxLogin.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxLogin.Location = new System.Drawing.Point(378, 273);
			this.textBoxLogin.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(361, 38);
			this.textBoxLogin.TabIndex = 8;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPassword.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxPassword.Location = new System.Drawing.Point(378, 376);
			this.textBoxPassword.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(361, 38);
			this.textBoxPassword.TabIndex = 9;
			// 
			// textBoxRepeatedPassword
			// 
			this.textBoxRepeatedPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxRepeatedPassword.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxRepeatedPassword.Location = new System.Drawing.Point(378, 479);
			this.textBoxRepeatedPassword.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
			this.textBoxRepeatedPassword.Name = "textBoxRepeatedPassword";
			this.textBoxRepeatedPassword.PasswordChar = '*';
			this.textBoxRepeatedPassword.Size = new System.Drawing.Size(361, 38);
			this.textBoxRepeatedPassword.TabIndex = 10;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(8, 146);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(173, 87);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox2.Location = new System.Drawing.Point(8, 249);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(8);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(173, 87);
			this.pictureBox2.TabIndex = 12;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox3.Location = new System.Drawing.Point(8, 352);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(8);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(173, 87);
			this.pictureBox3.TabIndex = 13;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
			this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox4.Location = new System.Drawing.Point(8, 455);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(8);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(173, 87);
			this.pictureBox4.TabIndex = 14;
			this.pictureBox4.TabStop = false;
			// 
			// errorProvider
			// 
			this.errorProvider.BlinkRate = 50;
			this.errorProvider.ContainerControl = this;
			// 
			// ControllingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 691);
			this.Controls.Add(this.table);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(775, 730);
			this.Name = "ControllingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Регистрация";
			this.TopMost = true;
			this.table.ResumeLayout(false);
			this.table.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel table;
		private System.Windows.Forms.Button buttonAuthorize;
		private System.Windows.Forms.Button buttonRegister;
		private System.Windows.Forms.Button buttonPerformAction;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxFullName;
		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.TextBox textBoxRepeatedPassword;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}