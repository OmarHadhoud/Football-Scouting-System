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
	public partial class Postnews : Form
	{
		Form ParentForm_;
		public Postnews(Form _ParentForm)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;

		}

		private void PostnewsForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}

		private void Postnews_Load(object sender, EventArgs e)
		{

		}
	}
}
