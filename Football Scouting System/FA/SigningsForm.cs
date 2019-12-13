using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Scouting_System.FA
{
    public partial class SigningsForm : Form
    {
        private FAHomeScreen ParentForm_;
        Controller controllerobj;

        public SigningsForm(FAHomeScreen _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
            controllerobj = new Controller();
        }

        private void SigningsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }

		private void SigningsForm_Load(object sender, EventArgs e)
		{

		}
	}
}
