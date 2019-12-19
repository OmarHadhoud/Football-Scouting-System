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
	public partial class viewplayers : Form
	{
		Form ParentForm_;
		Controller Controllerobj;
		public viewplayers(Form _ParentForm)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			Controllerobj = new Controller();
			freeButton.Checked = true;
		}



		private void ViewPlayersForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}

		private void viewplayers_Load(object sender, EventArgs e)
		{

		}

		

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private string Getplayername()
		{
			string Name = Namebox.Text;
			if (Name == "" || Name == " ")
				throw new System.Exception("Please enter the player name!");
			for (int i = 0; i < Name.Length; ++i)
			{
				if (Name[i] >= '0' && Name[i] <= '9')
					throw new System.Exception("Please don't enter numbers in the player name!");
			}
			return Name;
		}

		

		private void viewallbutton_Click_1(object sender, EventArgs e)
		{
			
				if (freeButton.Checked == true)
				{
					DataTable dt = Controllerobj.GetAllFreePlayers();
					playerdataGridView.DataSource = dt;
					playerdataGridView.Refresh();
				}
				else if (nonfreeButton.Checked == true)
				{
					DataTable dt = Controllerobj.GetAllNonFreePlayers();
					playerdataGridView.DataSource = dt;
					playerdataGridView.Refresh();
				}

			
		}

		private void statbutton_Click_1(object sender, EventArgs e)
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

		private void freeButton_CheckedChanged_1(object sender, EventArgs e)
		{
			
				playerdataGridView.DataSource = null;
				playerdataGridView.Refresh();
			
		}

		private void nonfreeButton_CheckedChanged_1(object sender, EventArgs e)
		{
			
				playerdataGridView.DataSource = null;
				playerdataGridView.Refresh();
			
		}

		private void attributesbutton_Click_1(object sender, EventArgs e)
		{
			
				try
				{
					int id = Convert.ToInt32(playerdataGridView.SelectedRows[0].Cells[0].Value.ToString());
					Scout.ViewPlayerAttributes vpa = new Scout.ViewPlayerAttributes(this, id);
					vpa.Show();
				}
				catch { MessageBox.Show("Please select a valid player !"); }
			
		}

		private void searchbutton_Click_1(object sender, EventArgs e)
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
				else if (nonfreeButton.Checked == true)
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
