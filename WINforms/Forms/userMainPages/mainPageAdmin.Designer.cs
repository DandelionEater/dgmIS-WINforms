namespace WINforms.Forms
{
	partial class mainPageAdmin
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
			studentButtonAdmin = new Button();
			lecturerButtonAdmin = new Button();
			lectureButtonAdmin = new Button();
			sGroupButtonAdmin = new Button();
			logOutButtonAdmin = new Button();
			label2 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(264, 32);
			label1.Name = "label1";
			label1.Size = new Size(470, 59);
			label1.TabIndex = 0;
			label1.Text = "Sveiki Administratoriau!";
			// 
			// studentButtonAdmin
			// 
			studentButtonAdmin.Anchor = AnchorStyles.None;
			studentButtonAdmin.Location = new Point(223, 147);
			studentButtonAdmin.Name = "studentButtonAdmin";
			studentButtonAdmin.Size = new Size(256, 132);
			studentButtonAdmin.TabIndex = 1;
			studentButtonAdmin.Text = "Studentų valdymo panelė";
			studentButtonAdmin.UseVisualStyleBackColor = true;
			studentButtonAdmin.Click += studentButtonAdmin_Click;
			// 
			// lecturerButtonAdmin
			// 
			lecturerButtonAdmin.Anchor = AnchorStyles.None;
			lecturerButtonAdmin.Location = new Point(506, 147);
			lecturerButtonAdmin.Name = "lecturerButtonAdmin";
			lecturerButtonAdmin.Size = new Size(256, 132);
			lecturerButtonAdmin.TabIndex = 1;
			lecturerButtonAdmin.Text = "Dėstytojų valdymo panelė (Kolkas neveikia)";
			lecturerButtonAdmin.UseVisualStyleBackColor = true;
			lecturerButtonAdmin.Click += lecturerButtonAdmin_Click;
			// 
			// lectureButtonAdmin
			// 
			lectureButtonAdmin.Anchor = AnchorStyles.None;
			lectureButtonAdmin.Location = new Point(506, 302);
			lectureButtonAdmin.Name = "lectureButtonAdmin";
			lectureButtonAdmin.Size = new Size(256, 132);
			lectureButtonAdmin.TabIndex = 1;
			lectureButtonAdmin.Text = "Paskaitų valdymo panelė (Kolkas neveikia)";
			lectureButtonAdmin.UseVisualStyleBackColor = true;
			lectureButtonAdmin.Click += lectureButtonAdmin_Click;
			// 
			// sGroupButtonAdmin
			// 
			sGroupButtonAdmin.Anchor = AnchorStyles.None;
			sGroupButtonAdmin.Location = new Point(223, 302);
			sGroupButtonAdmin.Name = "sGroupButtonAdmin";
			sGroupButtonAdmin.Size = new Size(256, 132);
			sGroupButtonAdmin.TabIndex = 1;
			sGroupButtonAdmin.Text = "Studentų grupių valdymo panelė (Kolkas neveikia)";
			sGroupButtonAdmin.UseVisualStyleBackColor = true;
			sGroupButtonAdmin.Click += sGroupButtonAdmin_Click;
			// 
			// logOutButtonAdmin
			// 
			logOutButtonAdmin.Anchor = AnchorStyles.Bottom;
			logOutButtonAdmin.Location = new Point(365, 484);
			logOutButtonAdmin.Name = "logOutButtonAdmin";
			logOutButtonAdmin.Size = new Size(256, 36);
			logOutButtonAdmin.TabIndex = 1;
			logOutButtonAdmin.Text = "Atsijungti";
			logOutButtonAdmin.UseVisualStyleBackColor = true;
			logOutButtonAdmin.Click += logOutButtonAdmin_Click;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top;
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(404, 91);
			label2.Name = "label2";
			label2.Size = new Size(185, 28);
			label2.TabIndex = 0;
			label2.Text = "Pasirinkite operaciją";
			// 
			// mainPageAdmin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			ClientSize = new Size(984, 561);
			Controls.Add(logOutButtonAdmin);
			Controls.Add(sGroupButtonAdmin);
			Controls.Add(lectureButtonAdmin);
			Controls.Add(lecturerButtonAdmin);
			Controls.Add(studentButtonAdmin);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "mainPageAdmin";
			Text = "„dgmIS“ akademinė sistema";
			WindowState = FormWindowState.Maximized;
			Load += mainPageAdmin_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button studentButtonAdmin;
		private Button lecturerButtonAdmin;
		private Button lectureButtonAdmin;
		private Button sGroupButtonAdmin;
		private Button logOutButtonAdmin;
		private Label label2;
	}
}