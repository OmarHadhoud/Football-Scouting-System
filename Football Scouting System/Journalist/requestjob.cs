using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Scouting_System.Journalist
{
	public partial class requestjob : Form
	{
		Form ParentForm_;
		Controller Controllerobj;
		int JID;
		DataTable clubstable;
		public requestjob(Form _ParentForm,int id)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			Controllerobj = new Controller();
			JID = id;
			UpdateComboBoxes();
		}

		private void requestForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void requestjob_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'scouting_SystemDataSet1.Club' table. You can move, or remove it, as needed.
			//this.clubTableAdapter.Fill(this.scouting_SystemDataSet1.Club);

		}

		private void UpdateComboBoxes()
		{
			clubstable = Controllerobj.GetAllClubs();
			comboBox1.DataSource = clubstable;
			comboBox1.DisplayMember = "Name";
			comboBox1.ValueMember = "CID";
			comboBox1.SelectedItem = null;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (Convert.ToString(comboBox1.SelectedValue) == "")
			{
				MessageBox.Show("No Clubs were chosen!");
			}
			else
			{
				try
				{
					Controllerobj.journalistrequest(JID, (int)comboBox1.SelectedValue);
					MessageBox.Show("You are now hired!");
					this.Close();
				}
				catch
				{
					MessageBox.Show("You are already working for this club!");
				}
			}
			
		}
	}
}
