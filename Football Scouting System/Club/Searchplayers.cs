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
		public Searchplayers(Form _ParentForm)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			Controllerobj = new Controller();

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
			else
			{
				DataTable dt = Controllerobj.GetAllNonFreePlayers();
				playerdataGridView.DataSource = dt;
				playerdataGridView.Refresh();
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
			Signplayer S = new Signplayer(this);
			this.Hide();
			S.Show();

		}
	}
}
