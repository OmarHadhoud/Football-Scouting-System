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
	public partial class Releaseplayer : Form
	{
		Form ParentForm_;
		Controller Controllerobj;
		int ParentclubID;
		DataTable playerstab;

		public Releaseplayer(Form _ParentForm, int id)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			Controllerobj = new Controller();
			ParentclubID = id;
			UpdateComboBoxes();


		}
		private void EditclubstadiumForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}

		private void Editclubstadium_Load(object sender, EventArgs e)
		{

		}
		private void UpdateComboBoxes()
		{
			playerstab = Controllerobj.GetPlayers(ParentclubID);
			comboBox1.DataSource = playerstab;
			comboBox1.DisplayMember = "Fname";
			comboBox1.ValueMember = "PID";
			comboBox1.SelectedItem = null;
		}
		private void releasebutton_Click(object sender, EventArgs e)
		{
			if (Convert.ToString(comboBox1.SelectedValue) == "")
			{
				MessageBox.Show("No Players were chosen!");
			}
			else
			{
				Controllerobj.ReleasePlayer(Convert.ToInt32(comboBox1.SelectedValue));
				MessageBox.Show("Player is released!");
				this.Close();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
