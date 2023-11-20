using Org.BouncyCastle.Crypto;
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
	public partial class deleteStudent : Form
	{
		public deleteStudent()
		{
			InitializeComponent();
		}

		private async void deleteStudent_Load(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("IDs");
			dt.Columns.Add("Names");

			var IDs = await Program.DB.getGroupIDsAdmin();
			var Names = await Program.DB.getGroups();

			for (int i = 0; i < IDs.Count; i++)
			{
				dt.Rows.Add(IDs[i], Names[i]);
			}

			sGroupCbox.DataSource = dt;
			sGroupCbox.DisplayMember = "Names";
			sGroupCbox.ValueMember = "IDs";

			if (!int.TryParse(sGroupCbox.SelectedValue.ToString(), out int sGroup))
			{
				sGroup = 1;
			}

			DataTable dt2 = new DataTable();
			dt2.Columns.Add("IDs");
			dt2.Columns.Add("Names");

			try
			{
				IDs = await Program.DB.getStudentsFromGroup(sGroup);
				Names = await Program.DB.getStudentFromGroupLogins(sGroup);


				for (int i = 0; i < IDs.Count; i++)
				{
					dt2.Rows.Add(IDs[i], Names[i]);
				}
			}
			catch
			{

			}

			sLoginCbox.DataSource = dt2;
			sLoginCbox.DisplayMember = "Names";
			sLoginCbox.ValueMember = "IDs";
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private async void sGroupCbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt2 = new DataTable();
			dt2.Columns.Add("IDs");
			dt2.Columns.Add("Names");

			if(!int.TryParse(sGroupCbox.SelectedValue.ToString(), out int sGroup))
			{
				sGroup = 1;
			}

			try
			{
				var IDs = await Program.DB.getStudentsFromGroup(sGroup);
				var Names = await Program.DB.getStudentFromGroupLogins(sGroup);

				for (int i = 0; i < IDs.Count; i++)
				{
					dt2.Rows.Add(IDs[i], Names[i]);
				}
			}
			catch
			{

			}

			sLoginCbox.DataSource = dt2;
			sLoginCbox.DisplayMember = "Names";
			sLoginCbox.ValueMember = "IDs";

			sLoginCbox.SelectedIndex = -1;
		}

		private void sLoginCbox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private async void confirmButton_Click(object sender, EventArgs e)
		{
			if (sLoginCbox.SelectedIndex == -1)
			{
				MessageBox.Show("Nepasirinkta informacija. Bandykite dar kartą.", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var response = MessageBox.Show("Ar tikrai norite ištrinti šį studentą?", "Įspėjimas", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

			switch (response)
			{
				case DialogResult.OK:
					await Program.DB.deleteStudent(int.Parse(sLoginCbox.SelectedValue.ToString()));

					DataTable dt = new DataTable();
					dt.Columns.Add("IDs");
					dt.Columns.Add("Names");

					var IDs = await Program.DB.getGroupIDsAdmin();
					var Names = await Program.DB.getGroups();

					for (int i = 0; i < IDs.Count; i++)
					{
						dt.Rows.Add(IDs[i], Names[i]);
					}

					sGroupCbox.DataSource = dt;
					sGroupCbox.DisplayMember = "Names";
					sGroupCbox.ValueMember = "IDs";

					DataTable dt2 = new DataTable();
					dt2.Columns.Add("IDs");
					dt2.Columns.Add("Names");

					if (!int.TryParse(sGroupCbox.SelectedValue.ToString(), out int sGroup))
					{
						sGroup = 1;
					}

					try
					{
						IDs = await Program.DB.getStudentsFromGroup(sGroup);
						Names = await Program.DB.getStudentFromGroupLogins(sGroup);

						for (int i = 0; i < IDs.Count; i++)
						{
							dt2.Rows.Add(IDs[i], Names[i]);
						}
					}
					catch
					{

					}

					sLoginCbox.DataSource = dt2;
					sLoginCbox.DisplayMember = "Names";
					sLoginCbox.ValueMember = "IDs";

					sLoginCbox.SelectedIndex = -1;

					MessageBox.Show("Operacija atlikta sėkmingai", "Pavyko!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;
			}
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			var studOptions = new studentOptionsWindow();
			studOptions.Show();
			this.Hide();
		}
	}
}
