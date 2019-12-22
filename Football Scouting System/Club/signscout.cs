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
	public partial class signscout : Form
	{
		Form ParentForm_;
		Controller controllerobj;
		int club_, efa_, scout_;

		private void sendbutton_Click(object sender, EventArgs e)
		{
			try
			{

				int fee = getofferfee();
				DateTime dt = GetofferDatetime();
				try
				{
					controllerobj.AddScoutOffer(club_, efa_, scout_, dt, fee, 0);
					MessageBox.Show("Offer sent successfully!");
					this.Close();
				}
				catch
				{
					MessageBox.Show("You've already sent an offer!");
				}

			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}

		private void SignScout_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}

		public signscout(Form _ParentForm, int _club, int _efa, int _scout)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			controllerobj = new Controller();
			club_ = _club;
			efa_ = _efa;
			scout_ = _scout;
		}

		private DateTime GetofferDatetime()
		{
			DateTime fd = dateTimePicker.Value.Date;
			return fd;
		}

		private int getofferfee()
		{
			StringBuilder err = new StringBuilder();
			Object data = ValidationClass.isPositiveInteger(feebox.Text, err); //choose the textbox to be validated
			if (data == null)
			{
				throw new System.Exception(err.ToString());

			}
			else
			{
				int x = (int)data;
				return x;

			}
			// return 0;
		}

		private void signscout_Load(object sender, EventArgs e)
		{

		}
	}
}
