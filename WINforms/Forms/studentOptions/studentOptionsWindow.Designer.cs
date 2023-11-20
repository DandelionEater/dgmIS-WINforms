namespace WINforms.Forms
{
	partial class studentOptionsWindow
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
			createStudButton = new Button();
			studentOptionsBackButton = new Button();
			deleteStudButton = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(157, 34);
			label1.Name = "label1";
			label1.Size = new Size(506, 59);
			label1.TabIndex = 0;
			label1.Text = "Studentų valdymo panelė";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(283, 105);
			label2.Name = "label2";
			label2.Size = new Size(252, 28);
			label2.TabIndex = 0;
			label2.Text = "Pasirinkite norimą operaciją";
			// 
			// createStudButton
			// 
			createStudButton.Anchor = AnchorStyles.None;
			createStudButton.Location = new Point(221, 192);
			createStudButton.Name = "createStudButton";
			createStudButton.Size = new Size(170, 112);
			createStudButton.TabIndex = 1;
			createStudButton.Text = "Sukurti studentą";
			createStudButton.UseVisualStyleBackColor = true;
			createStudButton.Click += createStudButton_Click;
			// 
			// studentOptionsBackButton
			// 
			studentOptionsBackButton.Anchor = AnchorStyles.Bottom;
			studentOptionsBackButton.Location = new Point(333, 404);
			studentOptionsBackButton.Name = "studentOptionsBackButton";
			studentOptionsBackButton.Size = new Size(143, 34);
			studentOptionsBackButton.TabIndex = 1;
			studentOptionsBackButton.Text = "Atgal";
			studentOptionsBackButton.UseVisualStyleBackColor = true;
			studentOptionsBackButton.Click += studentOptionsBackButton_Click;
			// 
			// deleteStudButton
			// 
			deleteStudButton.Anchor = AnchorStyles.None;
			deleteStudButton.Location = new Point(420, 192);
			deleteStudButton.Name = "deleteStudButton";
			deleteStudButton.Size = new Size(170, 112);
			deleteStudButton.TabIndex = 1;
			deleteStudButton.Text = "Ištrinti studentą";
			deleteStudButton.UseVisualStyleBackColor = true;
			deleteStudButton.Click += deleteStudButton_Click;
			// 
			// studentOptionsWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ClientSize = new Size(800, 450);
			Controls.Add(studentOptionsBackButton);
			Controls.Add(deleteStudButton);
			Controls.Add(createStudButton);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "studentOptionsWindow";
			Text = "„dgmIS“ akademinė sistema";
			WindowState = FormWindowState.Maximized;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Button createStudButton;
		private Button studentOptionsBackButton;
		private Button deleteStudButton;
	}
}