
namespace UserInterfaces.Forms
{
	partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.checkBoxTopMost = new System.Windows.Forms.CheckBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxTopMost
            // 
            this.checkBoxTopMost.AutoSize = true;
            this.checkBoxTopMost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(31)))), ((int)(((byte)(161)))));
            this.checkBoxTopMost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxTopMost.ForeColor = System.Drawing.Color.Aqua;
            this.checkBoxTopMost.Location = new System.Drawing.Point(-1, 0);
            this.checkBoxTopMost.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxTopMost.Name = "checkBoxTopMost";
            this.checkBoxTopMost.Size = new System.Drawing.Size(144, 19);
            this.checkBoxTopMost.TabIndex = 1;
            this.checkBoxTopMost.Text = "Поверх всех окон";
            this.checkBoxTopMost.UseVisualStyleBackColor = false;
            this.checkBoxTopMost.CheckedChanged += new System.EventHandler(this.CheckBoxTopMost_CheckedChanged);
            // 
            // labelOutput
            // 
            this.labelOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(28)))), ((int)(((byte)(140)))));
            this.labelOutput.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOutput.ForeColor = System.Drawing.Color.Aqua;
            this.labelOutput.Location = new System.Drawing.Point(-1, 19);
            this.labelOutput.Margin = new System.Windows.Forms.Padding(0);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(735, 319);
            this.labelOutput.TabIndex = 2;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.textBoxInput.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxInput.ForeColor = System.Drawing.Color.Aqua;
            this.textBoxInput.Location = new System.Drawing.Point(-1, 338);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxInput.MaxLength = 150;
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ShortcutsEnabled = false;
            this.textBoxInput.Size = new System.Drawing.Size(504, 123);
            this.textBoxInput.TabIndex = 3;
            this.textBoxInput.Text = "Введите сообщение здесь";
            this.textBoxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxInput.Enter += new System.EventHandler(this.TextBoxInput_Enter);
            this.textBoxInput.Leave += new System.EventHandler(this.TextBoxInput_Leave);
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(163)))));
            this.buttonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSend.FlatAppearance.BorderSize = 0;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonSend.ForeColor = System.Drawing.Color.Aqua;
            this.buttonSend.Location = new System.Drawing.Point(503, 338);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(231, 123);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(27)))), ((int)(((byte)(148)))));
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(27)))), ((int)(((byte)(148)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonClear.ForeColor = System.Drawing.Color.Aqua;
            this.buttonClear.Location = new System.Drawing.Point(636, 0);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(98, 19);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(31)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.checkBoxTopMost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Мессенджер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Shown += new System.EventHandler(this.ClientForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.CheckBox checkBoxTopMost;
		private System.Windows.Forms.Label labelOutput;
		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.Button buttonSend;
		private System.Windows.Forms.Button buttonClear;
	}
}