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
    public partial class UpdateFA : Form
    {
        private FAHomeScreen ParentForm_;
        Controller controllerobj;

        public UpdateFA(FAHomeScreen _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
            controllerobj = new Controller();
        }

        private void UpdateFA_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
