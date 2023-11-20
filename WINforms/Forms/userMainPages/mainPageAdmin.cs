using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINforms.Forms
{
	public partial class mainPageAdmin : Form
	{
		public mainPageAdmin()
		{
			InitializeComponent();
		}

		private void logOutButtonAdmin_Click(object sender, EventArgs e)
		{
			var loginMenu = new loginPage();
			loginMenu.Show();
			this.Hide();
		}

		private void studentButtonAdmin_Click(object sender, EventArgs e)
		{
			var studOptions = new studentOptionsWindow();
			studOptions.Show();
			this.Hide();
		}

		private void lecturerButtonAdmin_Click(object sender, EventArgs e)
		{

		}

		private void sGroupButtonAdmin_Click(object sender, EventArgs e)
		{

		}

		private void lectureButtonAdmin_Click(object sender, EventArgs e)
		{

		}

		private void mainPageAdmin_Load(object sender, EventArgs e)
		{

		}
	}
}
