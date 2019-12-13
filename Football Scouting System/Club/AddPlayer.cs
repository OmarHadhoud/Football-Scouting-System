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
	public partial class AddPlayer : Form
	{
		private Form ParentForm_;
		Controller controllerobj;
		public AddPlayer(Form _ParentForm)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			controllerobj = new Controller();

		}
		private void AddPlayerForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}
		private void AddPlayer_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			/*try
			{
				int ID = GetClubId();
				string FName = GetClubName();
				string Abbv = GetClubAbbv();
				string City = GetClubCity();
				string LeagueName = Convert.ToString(comboBox1.SelectedValue);
				DateTime FoundDate = GetClubFD();
				string Pass = GetClubPass();
				controllerobj.insertClub(ID, Name, Abbv, City, LeagueName, ParentForm_.GetFA_ID(), FoundDate, Pass);
				MessageBox.Show("Club added!");
				this.Close();
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			controllerobj.insertPlayer();
			MessageBox.Show("Player Successfully Inserted!");
			this.Close();*/

		}
	}
}
