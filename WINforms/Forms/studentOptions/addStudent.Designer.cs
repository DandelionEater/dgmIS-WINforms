namespace WINforms.Forms.studentOptions
{
	partial class addStudent
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
			label5 = new Label();
			sGroup = new ComboBox();
			lName = new TextBox();
			fName = new TextBox();
			backButton = new Button();
			createStudentButton = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(217, 42);
			label1.Name = "label1";
			label1.Size = new Size(398, 59);
			label1.TabIndex = 0;
			label1.Text = "Studento sukūrimas";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top;
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(313, 101);
			label2.Name = "label2";
			label2.Size = new Size(184, 28);
			label2.TabIndex = 0;
			label2.Text = "Studento sukūrimas";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(219, 192);
			label3.Name = "label3";
			label3.Size = new Size(154, 28);
			label3.TabIndex = 0;
			label3.Text = "Studento vardas";
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.None;
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(218, 239);
			label4.Name = "label4";
			label4.Size = new Size(168, 28);
			label4.TabIndex = 0;
			label4.Text = "Studento pavardė";
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.None;
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(219, 285);
			label5.Name = "label5";
			label5.Size = new Size(66, 28);
			label5.TabIndex = 0;
			label5.Text = "Grupė";
			// 
			// sGroup
			// 
			sGroup.Anchor = AnchorStyles.None;
			sGroup.FormattingEnabled = true;
			sGroup.Location = new Point(415, 290);
			sGroup.Name = "sGroup";
			sGroup.Size = new Size(157, 23);
			sGroup.TabIndex = 1;
			sGroup.SelectedIndexChanged += sGroup_SelectedIndexChanged;
			// 
			// lName
			// 
			lName.Anchor = AnchorStyles.None;
			lName.Location = new Point(415, 244);
			lName.Name = "lName";
			lName.Size = new Size(157, 23);
			lName.TabIndex = 2;
			lName.TextChanged += fName_Changed;
			// 
			// fName
			// 
			fName.Anchor = AnchorStyles.None;
			fName.Location = new Point(415, 197);
			fName.Name = "fName";
			fName.Size = new Size(157, 23);
			fName.TabIndex = 2;
			fName.TextChanged += fName_Changed;
			// 
			// backButton
			// 
			backButton.Anchor = AnchorStyles.Bottom;
			backButton.Location = new Point(237, 393);
			backButton.Name = "backButton";
			backButton.Size = new Size(141, 45);
			backButton.TabIndex = 3;
			backButton.Text = "Atgal";
			backButton.UseVisualStyleBackColor = true;
			backButton.Click += backButton_Click;
			// 
			// createStudentButton
			// 
			createStudentButton.Anchor = AnchorStyles.Bottom;
			createStudentButton.Location = new Point(423, 393);
			createStudentButton.Name = "createStudentButton";
			createStudentButton.Size = new Size(141, 45);
			createStudentButton.TabIndex = 3;
			createStudentButton.Text = "Sukurti studentą";
			createStudentButton.UseVisualStyleBackColor = true;
			createStudentButton.Click += createStudentButton_Click;
			// 
			// addStudent
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ClientSize = new Size(800, 450);
			Controls.Add(createStudentButton);
			Controls.Add(backButton);
			Controls.Add(fName);
			Controls.Add(lName);
			Controls.Add(sGroup);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "addStudent";
			Text = "„dgmIS“ akademinė sistema";
			WindowState = FormWindowState.Maximized;
			Load += addStudent_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private ComboBox sGroup;
		private TextBox lName;
		private TextBox fName;
		private Button backButton;
		private Button createStudentButton;
	}
}