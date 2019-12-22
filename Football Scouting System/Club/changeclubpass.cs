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
	public partial class changeclubpass : Form
	{
		Form ParentForm_;
		Controller controllerobj;
		int club_;
		public changeclubpass(Form _ParentForm,int _club)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			controllerobj = new Controller();
			club_ = _club;
		}

		private void changepassForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void backbutton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void changeclubpass_Load(object sender, EventArgs e)
		{

		}

		private string GetClubPassword()
		{
			string pass = textBox1.Text;
			if (pass.Length <= 6)
				throw new System.Exception("The club's password must be more than 6 characters!");
			string hashedPass = Football_Scouting_System.Form1.ComputeSha256Hash(pass);
			return hashedPass;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string pass = GetClubPassword();
				controllerobj.UpdateClubPassword(club_, pass);
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
