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
	public partial class Signfreeplayer : Form
	{
		Form ParentForm_;
		Controller controllerobj;
		int club_, efa_, player_;
		public Signfreeplayer(Form _ParentForm,int _club,int _efa,int _player)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			controllerobj = new Controller();
			club_ = _club;
			efa_ = _efa;
			player_ = _player;
		}

		private void SignPlayer_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}

		private void Signplayer_Load(object sender, EventArgs e)
		{

		}

		private void sendbutton_Click(object sender, EventArgs e)
		{
			try
			{

				int fee = getofferfee();
				DateTime dt = GetofferDatetime();
				try
				{
					controllerobj.AddOffer(club_, efa_, player_, dt, fee, 0);
					MessageBox.Show("Offer sent successfully!");
					this.Close();
				}
				catch
				{
					MessageBox.Show("You already sent an offer to this player!");
				}
				
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}

		private void dateTimePicker_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void feebox_TextChanged(object sender, EventArgs e)
		{

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
	}
}
