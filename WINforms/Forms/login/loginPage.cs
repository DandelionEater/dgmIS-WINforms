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
	public partial class loginPage : Form
	{
		public loginPage()
		{
			InitializeComponent();
		}

		private void _uBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			try
			{
				var _u = _uBox.Text;
				var _p = _pBox.Text;
				Program.DB = new dgmIS.DBconnect.DBconnect(_u, _p);

				switch (Program.DB._access)
				{
					case dgmIS.DBconnect.DBconnect.Access.Admin:
						var adminMenu = new mainPageAdmin();
						adminMenu.Show();
						this.Hide();
						break;
				}
			}
			catch
			{
				MessageBox.Show("Neteisingi duomenys", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void loginPage_Load(object sender, EventArgs e)
		{

		}
	}
}
