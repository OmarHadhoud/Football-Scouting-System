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
    public partial class ViewScoutGuestView : Form
    {
        Form ParentForm_;
        public ViewScoutGuestView(Form _ParentForm_)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm_;
        }

        private void ViewScoutGuestView_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }
    }
}
