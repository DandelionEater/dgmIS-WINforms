using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WINforms.Forms.studentOptions;

namespace WINforms.Forms
{
	public partial class studentOptionsWindow : Form
	{
		public studentOptionsWindow()
		{
			InitializeComponent();
		}

		private void createStudButton_Click(object sender, EventArgs e)
		{
			var createStud = new addStudent();
			createStud.Show();
			this.Hide();
		}

		private void deleteStudButton_Click(object sender, EventArgs e)
		{
			var deleteStud = new deleteStudent();
			deleteStud.Show();
			this.Hide();
		}

		private void studentOptionsBackButton_Click(object sender, EventArgs e)
		{
			var adminMenu = new mainPageAdmin();
			adminMenu.Show();
			this.Hide();
		}
	}
}
