using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Scouting_System.Scout
{
    public partial class ViewClubs : Form
    {
        private Form ParentForm_;
        Controller controllerobj;
        public ViewClubs(Form _ParentForm)
        {
            InitializeComponent();
            controllerobj = new Controller();
            ParentForm_ = _ParentForm;
        }

        private void ViewClubs_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }   

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
