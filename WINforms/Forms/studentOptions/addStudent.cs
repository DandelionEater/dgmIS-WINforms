using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINforms.Forms.studentOptions
{
	public partial class addStudent : Form
	{
		public addStudent()
		{
			InitializeComponent();
		}

		private void fName_Changed(object sender, EventArgs e)
		{

		}

		private void backButton_Click(object sender, EventArgs e)
		{
			var studOptions = new studentOptionsWindow();
			studOptions.Show();
			this.Hide();
		}

		private async void createStudentButton_Click(object sender, EventArgs e)
		{
			var _fName = fName.Text;
			var _lName = lName.Text;
			var _sGroup = sGroup.SelectedValue;

			await Program.DB.createStudent(_fName, _lName, int.Parse(_sGroup.ToString()));

			MessageBox.Show(string.Format("Studentas sėkmingai sukurtas\nJo prisijungimo duomenys:\nVartotojo vardas - {0}\nSlaptažodis - {1}", _fName, _lName));

			var studOptions = new studentOptionsWindow();
			studOptions.Show();
			this.Hide();
		}

		private void sGroup_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private async void addStudent_Load(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			var column = dt.Columns.Add("IDs");
			var columns = dt.Columns.Add("Names");

			var IDs = await Program.DB.getGroupIDsAdmin();
			var Names = await Program.DB.getGroups();

			for (int i = 0; i < IDs.Count; i++)
			{
				dt.Rows.Add(IDs[i], Names[i]);
			}

			sGroup.DataSource = dt;
			sGroup.DisplayMember = "Names";
			sGroup.ValueMember = "IDs";
		}
	}
}
