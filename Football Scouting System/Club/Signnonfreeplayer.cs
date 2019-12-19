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
	public partial class Signnonfreeplayer : Form
	{
		Form ParentForm_;
		Controller controllerobj;
		int club_, rec_, player_;

		public Signnonfreeplayer(Form _ParentForm,int _club, int _rec, int _player)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			controllerobj = new Controller();
			club_ = _club;
			rec_ = _rec;
			player_ = _player;
		}

		private void SignnonfreePlayer_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}

		private void Signnonfreeplayer_Load(object sender, EventArgs e)
		{

		}

		private void sendbutton_Click(object sender, EventArgs e)
		{
			if(club_!=rec_)
			{
				try
				{

					int fee = getofferfee();
					DateTime dt = GetofferDatetime();
					try
					{
						controllerobj.AddnonfreeOffer(club_,rec_, player_, dt, fee, 0);
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
			else
			{
				MessageBox.Show("The player already exists in your club!");
			}
			
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
