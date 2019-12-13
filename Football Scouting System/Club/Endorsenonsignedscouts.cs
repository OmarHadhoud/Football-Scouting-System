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
		public Endorsenonsignedscouts(Form _ParentForm)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
		}

		private void EndorsenonsignedscoutsForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}

		private void Endorsenonsignedscouts_Load(object sender, EventArgs e)
		{

		}
	}
}
