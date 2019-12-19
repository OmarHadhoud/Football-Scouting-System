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
	public partial class Searchplayers : Form
	{
		Form ParentForm_;
		Controller Controllerobj;
		int clubid, efaid,recid;
		public Searchplayers(Form _ParentForm,int efa,int club)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			Controllerobj = new Controller();
			freeButton.Checked = true;
			efaid = efa;
			clubid = club;
		}

		private void SearchNonfreePlayersForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}

		private void Searchnonfreeplayers_Load(object sender, EventArgs e)
		{

		}

		private void viewallbutton_Click(object sender, EventArgs e)
		{
			if (freeButton.Checked == true)
			{
				DataTable dt = Controllerobj.GetAllFreePlayers();
				playerdataGridView.DataSource = dt;
				playerdataGridView.Refresh();
			}
			else if(nonfreeButton.Checked==true)
			{
				DataTable dt = Controllerobj.GetAllNonFreePlayers();
				playerdataGridView.DataSource = dt;
				playerdataGridView.Refresh();
			}
			else
			{
				MessageBox.Show("Please choose a category!");
			}
		}

		private void statbutton_Click(object sender, EventArgs e)
		{
			try
			{
				int id = Convert.ToInt32(playerdataGridView.SelectedRows[0].Cells[0].Value.ToString());
				Scout.ViewPlayerStats vps = new Scout.ViewPlayerStats(this, id);
				vps.Show();
			}
			catch
			{
				MessageBox.Show("Please select a valid player !");
			}
		}

		private void attributesbutton_Click(object sender, EventArgs e)
		{
			try
			{
				int id = Convert.ToInt32(playerdataGridView.SelectedRows[0].Cells[0].Value.ToString());
				Scout.ViewPlayerAttributes vpa = new Scout.ViewPlayerAttributes(this, id);
				vpa.Show();
			}
			catch { MessageBox.Show("Please select a valid player !"); }
		}

		private void signingbutton_Click(object sender, EventArgs e)
		{
			try
			{
				int id = Convert.ToInt32(playerdataGridView.SelectedRows[0].Cells[0].Value.ToString());

				if (freeButton.Checked == true)
				{
					Signfreeplayer S = new Signfreeplayer(this, clubid, efaid, id);
					this.Hide();
					S.Show();

				}
				else if (nonfreeButton.Checked == true)
				{
					getplayerclub();
					Signnonfreeplayer S = new Signnonfreeplayer(this,clubid,recid,id);
					this.Hide();
					S.Show();
				}
				else
				{
					MessageBox.Show("Please choose a category!");
				}
			}
			catch
			{
				MessageBox.Show("Please select a player:");
			}
			
			

		}

		private void getplayerclub()
		{
			int playerid = Convert.ToInt32(playerdataGridView.SelectedRows[0].Cells[0].Value.ToString());

			int temp = Controllerobj.Getclubid(playerid);
			recid = temp;
		}

		private void freeButton_CheckedChanged(object sender, EventArgs e)
		{
			playerdataGridView.DataSource = null;
			playerdataGridView.Refresh();
		}

		private void nonfreeButton_CheckedChanged(object sender, EventArgs e)
		{
			playerdataGridView.DataSource = null;
			playerdataGridView.Refresh();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private string Getplayername()
		{
			string Name = Namebox.Text;
			if (Name == ""||Name==" ")
				throw new System.Exception("Please enter the player name!");
			for (int i = 0; i < Name.Length; ++i)
			{
				if (Name[i] >= '0' && Name[i] <= '9')
					throw new System.Exception("Please don't enter numbers in the player name!");
			}
			return Name;
		}


		private void searchbutton_Click(object sender, EventArgs e)
		{
			if (freeButton.Checked == true)
			{
				try
				{
					string name = Getplayername();
					DataTable dt = Controllerobj.GetaFreePlayer(name);
					if (dt == null)
						MessageBox.Show("No players found!");
					playerdataGridView.DataSource = dt;
					playerdataGridView.Refresh();
				}
				catch (System.Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				
			}
			else if (nonfreeButton.Checked==true)
			{
				try
				{
					string name = Getplayername();
					DataTable dt = Controllerobj.GetanonFreePlayer(name);
					if (dt == null)
						MessageBox.Show("No players found!");
					playerdataGridView.DataSource = dt;
					playerdataGridView.Refresh();
				}
				catch (System.Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				

			}
			else
			{
				MessageBox.Show("Please choose a category!");
			}
		}
	}
}
