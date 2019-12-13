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
	public partial class Postplayerstatus : Form
	{
		Form ParentForm_;
		public Postplayerstatus(Form _ParentForm)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;

		}

		private void PostplayerstatusForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}

		private void Postplayerstatus_Load(object sender, EventArgs e)
		{

		}
	}
}
