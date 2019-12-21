using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Scouting_System.Guestt
{
    public partial class ViewStadiumsForm : Form
    {
        Form ParentForm_;
        public ViewStadiumsForm(Form _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
        }

        private void ViewStadiumsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }
    }
}
