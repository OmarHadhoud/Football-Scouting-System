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
	public partial class Searchforfreeplayers : Form
	{
		Form ParentForm_;
		public Searchforfreeplayers(Form _ParentForm)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
		}

		private void SearchfreeplayersForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}

		private void Searchforfreeplayers_Load(object sender, EventArgs e)
		{

		}
	}
}
