namespace WINforms.Forms
{
	partial class loginPage
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			_uBox = new TextBox();
			_pBox = new TextBox();
			exitButton = new Button();
			loginButton = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(129, 53);
			label1.Name = "label1";
			label1.Size = new Size(549, 59);
			label1.TabIndex = 0;
			label1.Text = "„dgmIS“ akademinė sistema";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(339, 124);
			label2.Name = "label2";
			label2.Size = new Size(127, 28);
			label2.TabIndex = 0;
			label2.Text = "Prisijungimas";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(254, 282);
			label3.Name = "label3";
			label3.Size = new Size(89, 21);
			label3.TabIndex = 0;
			label3.Text = "Slaptažodis";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(219, 232);
			label4.Name = "label4";
			label4.Size = new Size(124, 21);
			label4.TabIndex = 0;
			label4.Text = "Vartotojo vardas";
			// 
			// _uBox
			// 
			_uBox.Location = new Point(359, 230);
			_uBox.Name = "_uBox";
			_uBox.Size = new Size(213, 23);
			_uBox.TabIndex = 1;
			_uBox.TextChanged += _uBox_TextChanged;
			// 
			// _pBox
			// 
			_pBox.Location = new Point(359, 280);
			_pBox.Name = "_pBox";
			_pBox.Size = new Size(213, 23);
			_pBox.TabIndex = 1;
			_pBox.UseSystemPasswordChar = true;
			// 
			// exitButton
			// 
			exitButton.Location = new Point(258, 370);
			exitButton.Name = "exitButton";
			exitButton.Size = new Size(133, 37);
			exitButton.TabIndex = 2;
			exitButton.Text = "Išeiti";
			exitButton.UseVisualStyleBackColor = true;
			exitButton.Click += exitButton_Click;
			// 
			// loginButton
			// 
			loginButton.Location = new Point(410, 370);
			loginButton.Name = "loginButton";
			loginButton.Size = new Size(133, 37);
			loginButton.TabIndex = 2;
			loginButton.Text = "Prisijungti";
			loginButton.UseVisualStyleBackColor = true;
			loginButton.Click += loginButton_Click;
			// 
			// loginPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(loginButton);
			Controls.Add(exitButton);
			Controls.Add(_pBox);
			Controls.Add(_uBox);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "loginPage";
			Text = "„dgmIS“ akademinė sistema";
			Load += loginPage_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox _uBox;
		private TextBox _pBox;
		private Button exitButton;
		private Button loginButton;
	}
}