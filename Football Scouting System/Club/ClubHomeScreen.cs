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
	public partial class ClubHomeScreen : Form
	{
		private Form ParentForm_;
		int clubID;
		public ClubHomeScreen(Form _ParentForm,int id)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			clubID = id;
			
		}
		private void ClubHomeScreen_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}
		private void ClubHomeScreen_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			AddPlayer A = new AddPlayer(this,clubID);
			this.Hide();
			A.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Signstaff S = new Signstaff(this);
			this.Hide();
			S.Show();
		}

		private void Searchfreebutt_Click(object sender, EventArgs e)
		{
			Searchforfreeplayers S = new Searchforfreeplayers(this);
			this.Hide();
			S.Show();
		}

		private void Searchnonfree_Click(object sender, EventArgs e)
		{
			Searchnonfreeplayers S = new Searchnonfreeplayers(this);
			this.Hide();
			S.Show();
		}

		private void Postbutton_Click(object sender, EventArgs e)
		{
			
			Postnews P = new Postnews(this,clubID);
			this.Hide();
			P.Show();
		}

		private void playerstatusbutt_Click(object sender, EventArgs e)
		{
			Postplayerstatus P = new Postplayerstatus(this,clubID);
			this.Hide();
			P.Show();
		}

		private void Transfersbutton_Click(object sender, EventArgs e)
		{
			Approchedtransfersotherclubs A = new Approchedtransfersotherclubs(this);
			this.Hide();
			A.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Endorsenonsignedscouts E = new Endorsenonsignedscouts(this);
			this.Hide();
			E.Show();
		}

		private void Stadiumbutt_Click(object sender, EventArgs e)
		{
			Editclubstadium E = new Editclubstadium(this);
			this.Hide();
			E.Show();
		}

		private void Leaguebutton_Click(object sender, EventArgs e)
		{
			Checkleaguestatus C = new Checkleaguestatus(this);
			this.Hide();
			C.Show();
		}

		private void LogoutButt_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
