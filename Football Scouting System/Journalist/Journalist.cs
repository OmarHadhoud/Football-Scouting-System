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
	public partial class Journalist : Form
	{
		private Form ParentForm_;
		int JID;
		Controller controllerobj;
		public Journalist(Form _ParentForm, int id)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			JID = id;
			controllerobj = new Controller();
		}
		private void journalist_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}
		private void Journalist_Load(object sender, EventArgs e)
		{

		}

		private void logbutton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void postbutton_Click(object sender, EventArgs e)
		{
			postarticle P = new postarticle(this,JID);
			P.Show();
			this.Hide();
		}

		private void viewinfobutton_Click(object sender, EventArgs e)
		{
			viewplayers S = new viewplayers(this);
			S.Show();
			this.Hide();
		}

		private void requestbutton_Click(object sender, EventArgs e)
		{
			requestjob R = new requestjob(this,JID);
			R.Show();
			this.Hide();
		}

		private void passbutton_Click(object sender, EventArgs e)
		{
			changejournalistpass C = new changejournalistpass(this,JID);
			this.Hide();
			C.Show();
		}
	}
}
