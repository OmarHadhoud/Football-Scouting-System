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
	public partial class Endorsenonsignedscouts : Form
	{
		Form ParentForm_;
		Controller controllerobj;

		public Endorsenonsignedscouts(Form _ParentForm)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			controllerobj = new Controller();
		}

		private void EndorsenonsignedscoutsForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}

		private void Endorsenonsignedscouts_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'scouting_SystemDataSet2.getscout' table. You can move, or remove it, as needed.
			this.getscoutTableAdapter.Fill(this.scouting_SystemDataSet2.getscout);
			// TODO: This line of code loads data into the 'scouting_SystemDataSet1.Scout' table. You can move, or remove it, as needed.
			this.scoutTableAdapter.Fill(this.scouting_SystemDataSet1.Scout);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			controllerobj.Endorsenonsigned(Convert.ToInt32(comboBox1.SelectedValue));
			MessageBox.Show("Thank you for endorsing!");
			this.Close();
		}
		
	}
}
