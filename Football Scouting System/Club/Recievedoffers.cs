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
	public partial class Recievedoffers : Form
	{
		Form ParentForm_;
		Controller controllerobj;
		int efa_,club_;
		public Recievedoffers(Form _ParentForm,int _EFA,int _club)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			controllerobj = new Controller();
			club_ = _club;
			efa_ = _EFA;
		}
		private void ApproachedtransfersotherclubForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}
		private void Approchedtransfersotherclubs_Load(object sender, EventArgs e)
		{
			actualoffersbutton.Checked = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (actualoffersbutton.Checked == true)
			{
				DataTable dt = controllerobj.GetactualOffers(club_);
				offersGridView.DataSource = dt;
				offersGridView.Refresh();
			}
			else if (suggestedoffersbutton.Checked == true)
			{
				DataTable dt = controllerobj.GetsuggestedfreeOffers(club_);
				offersGridView.DataSource = dt;
				offersGridView.Refresh();
			}
			else
			{
				DataTable dt = controllerobj.GetsuggestednonfreeOffers(club_);
				offersGridView.DataSource = dt;
				offersGridView.Refresh();

			}
		}

		private void actualoffersbutton_CheckedChanged(object sender, EventArgs e)
		{
			offersGridView.DataSource = null;
			offersGridView.Refresh();
		}

		private void suggestedoffersbutton_CheckedChanged(object sender, EventArgs e)
		{
			offersGridView.DataSource = null;
			offersGridView.Refresh();
		}

		private void acceptbutton_Click(object sender, EventArgs e)
		{
			try
			{
				//int id = Convert.ToInt32(playerdataGridView.SelectedRows[0].Cells[0].Value.ToString());

				if (actualoffersbutton.Checked == true)
				{
					
					try
					{

						int scid = (int)offersGridView.SelectedRows[0].Cells["Club ID"].Value;
						int pid = (int)offersGridView.SelectedRows[0].Cells["Player ID"].Value;
						controllerobj.SetPlayerClub(scid, pid);
						controllerobj.DeleteC2COffer(club_, scid, pid);
						MessageBox.Show("Offer accepted!");
						this.Close();

					}
					catch
					{
						MessageBox.Show("Please make sure you have chosen an offer!");
					}

				}
				else if (suggestedoffersbutton.Checked == true)
				{
					try
					{

						int pid = (int)offersGridView.SelectedRows[0].Cells["PlayerID"].Value;
						controllerobj.approvesuggestion(efa_,club_,pid);
						MessageBox.Show("Offer accepted!");
						this.Close();

					}
					catch
					{
						MessageBox.Show("Please make sure you have chosen an offer!");
					}

				}
				else
				{
					try
					{
						int REC = (int)offersGridView.SelectedRows[0].Cells["ClubID"].Value;
						int pid = (int)offersGridView.SelectedRows[0].Cells["PlayerID"].Value;
						controllerobj.approvenonfreesuggestion(REC, club_, pid);
						MessageBox.Show("Offer accepted!");
						this.Close();

					}
					catch
					{
						MessageBox.Show("Please make sure you have chosen an offer!");
					}
				}

			}
			catch
			{
				MessageBox.Show("Please select an offer!");
			}
		}

		private void rejectbutton_Click(object sender, EventArgs e)
		{
			try
			{
				//int id = Convert.ToInt32(playerdataGridView.SelectedRows[0].Cells[0].Value.ToString());

				if (actualoffersbutton.Checked == true)
				{
					try
					{
						int scid = (int)offersGridView.SelectedRows[0].Cells["Club ID"].Value;
						int pid = (int)offersGridView.SelectedRows[0].Cells["Player ID"].Value;
						controllerobj.DeleteC2COffer(club_, scid, pid);
						MessageBox.Show("Offer rejected!");
						this.Close();
							
						
					}
					catch
					{
						MessageBox.Show("Please make sure you have chosen an offer!");
					}

				}
				else if (suggestedoffersbutton.Checked == true)
				{
					try
					{
						int pid = (int)offersGridView.SelectedRows[0].Cells["PlayerID"].Value;
						controllerobj.DeleteC2EOffer(efa_, club_, pid);
						MessageBox.Show("Offer rejected!");
						this.Close();


					}
					catch
					{
						MessageBox.Show("Please make sure you have chosen a free offer!");
					}
				}
				else
				{
					try
					{
						int rcid = (int)offersGridView.SelectedRows[0].Cells["ClubID"].Value;
						int pid = (int)offersGridView.SelectedRows[0].Cells["PlayerID"].Value;
						controllerobj.DeleteC2COffer(rcid, club_, pid);
						MessageBox.Show("Offer rejected!");
						this.Close();


					}
					catch
					{
						MessageBox.Show("Please make sure you have chosen an offer!");
					}
				}

			}
			catch
			{
				MessageBox.Show("Please select an offer!");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void suggestednonfree_CheckedChanged(object sender, EventArgs e)
		{
			offersGridView.DataSource = null;
			offersGridView.Refresh();
		}
	}
}
