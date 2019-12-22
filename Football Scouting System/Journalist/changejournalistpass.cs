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
	public partial class changejournalistpass : Form
	{
		Form ParentForm_;
		Controller controllerobj;
		int jid_;
		public changejournalistpass(Form _ParentForm,int _jid)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			controllerobj = new Controller();
			jid_ = _jid;
		}

		private void changepassForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}

		private void changejournalistpass_Load(object sender, EventArgs e)
		{

		}

		private string GetJournalistPassword()
		{
			string pass = textBox1.Text;
			if (pass.Length <= 6)
				throw new System.Exception("The club's password must be more than 6 characters!");
			string hashedPass = Football_Scouting_System.Form1.ComputeSha256Hash(pass);
			return hashedPass;
		}

		private void backbutton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string pass = GetJournalistPassword();
				controllerobj.UpdatejournalistPassword(jid_, pass);
				MessageBox.Show("Password updated!");
				this.Close();
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);

			}
		}
	}
}
