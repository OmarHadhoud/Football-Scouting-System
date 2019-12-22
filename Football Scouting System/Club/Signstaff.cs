using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Scouting_System.Club
{
	public partial class Signstaff : Form
	{
		Form ParentForm_;
		Controller controllerobj;
		int club_, jid,sid,efaid;
		int check;
		public Signstaff(Form _ParentForm,int efa,int club)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			Scoutbutton.Checked = true;
			controllerobj = new Controller();
			club_ = club;
			efaid = efa;
			check = 0;
		}

		private void SignstaffForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}

		private void Signstaff_Load(object sender, EventArgs e)
		{

		}

		private void Scoutbutton_CheckedChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = null;
			dataGridView1.Refresh();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(Scoutbutton.Checked==true)
			{
				DataTable dt = controllerobj.GetfreeScouts();
				dataGridView1.DataSource = dt;
				dataGridView1.Refresh();
			}
			else
			{
				DataTable dt = controllerobj.GetAllJournalists();
				dataGridView1.DataSource = dt;
				dataGridView1.Refresh();
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void Journalistbutton_CheckedChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = null;
			dataGridView1.Refresh();
		}

		private void hirebutton_Click(object sender, EventArgs e)
		{
			if (Scoutbutton.Checked == true)
			{
				try
				{
					int id = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
					signscout S = new signscout(this,club_,efaid,id);
					S.Show();
					this.Hide();
					
					
				}
				catch
				{
					MessageBox.Show("Please select a Scout:");
				}
				/////////////////////
				
				
					
				
				}
			else
			{
				try
				{
					jid = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
					check = 1;

				}
				catch
				{
					MessageBox.Show("Please make sure you have chosen a journalist!");

				}
				if(check==1)
				{
					try
					{
						controllerobj.journalistrequest(jid, club_);

						MessageBox.Show("Journalist is hired!");


						this.Close();
					}
					catch
					{
						MessageBox.Show("He is already working for this club!");
						check = 0;

					}
				}
				

			}
		}
	}
}
