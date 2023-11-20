namespace WINforms.Forms.studentOptions
{
	partial class deleteStudent
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
			sGroupCbox = new ComboBox();
			sLoginCbox = new ComboBox();
			label4 = new Label();
			backButton = new Button();
			confirmButton = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(200, 41);
			label1.Name = "label1";
			label1.Size = new Size(399, 59);
			label1.TabIndex = 0;
			label1.Text = "Studento ištrynimas";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(249, 213);
			label2.Name = "label2";
			label2.Size = new Size(53, 21);
			label2.TabIndex = 0;
			label2.Text = "Grupė";
			label2.Click += label2_Click;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(249, 259);
			label3.Name = "label3";
			label3.Size = new Size(78, 21);
			label3.TabIndex = 0;
			label3.Text = "Studentas";
			// 
			// sGroupCbox
			// 
			sGroupCbox.Anchor = AnchorStyles.None;
			sGroupCbox.FormattingEnabled = true;
			sGroupCbox.Location = new Point(354, 211);
			sGroupCbox.Name = "sGroupCbox";
			sGroupCbox.Size = new Size(185, 23);
			sGroupCbox.TabIndex = 1;
			sGroupCbox.SelectedIndexChanged += sGroupCbox_SelectedIndexChanged;
			// 
			// sLoginCbox
			// 
			sLoginCbox.Anchor = AnchorStyles.None;
			sLoginCbox.FormattingEnabled = true;
			sLoginCbox.Location = new Point(354, 257);
			sLoginCbox.Name = "sLoginCbox";
			sLoginCbox.Size = new Size(185, 23);
			sLoginCbox.TabIndex = 1;
			sLoginCbox.SelectedIndexChanged += sLoginCbox_SelectedIndexChanged;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Top;
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(303, 100);
			label4.Name = "label4";
			label4.Size = new Size(202, 28);
			label4.TabIndex = 2;
			label4.Text = "Pasirinkite informaciją";
			// 
			// backButton
			// 
			backButton.Anchor = AnchorStyles.Bottom;
			backButton.Location = new Point(243, 386);
			backButton.Name = "backButton";
			backButton.Size = new Size(141, 42);
			backButton.TabIndex = 3;
			backButton.Text = "Atgal";
			backButton.UseVisualStyleBackColor = true;
			backButton.Click += backButton_Click;
			// 
			// confirmButton
			// 
			confirmButton.Anchor = AnchorStyles.Bottom;
			confirmButton.Location = new Point(415, 386);
			confirmButton.Name = "confirmButton";
			confirmButton.Size = new Size(141, 42);
			confirmButton.TabIndex = 3;
			confirmButton.Text = "Patvirtinti";
			confirmButton.UseVisualStyleBackColor = true;
			confirmButton.Click += confirmButton_Click;
			// 
			// deleteStudent
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ClientSize = new Size(800, 450);
			Controls.Add(confirmButton);
			Controls.Add(backButton);
			Controls.Add(label4);
			Controls.Add(sLoginCbox);
			Controls.Add(sGroupCbox);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "deleteStudent";
			Text = "„dgmIS“ akademinė sistema";
			WindowState = FormWindowState.Maximized;
			Load += deleteStudent_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private ComboBox sGroupCbox;
		private ComboBox sLoginCbox;
		private Label label4;
		private Button backButton;
		private Button confirmButton;
	}
}