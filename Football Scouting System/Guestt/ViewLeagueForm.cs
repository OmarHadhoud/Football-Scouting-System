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
    public partial class ViewLeagueForm : Form
    {
        Form parentForm_;
        public ViewLeagueForm(Form _parentForm)
        {
            InitializeComponent();
            crystalReportViewer1.RefreshReport();
            parentForm_ = _parentForm;
        }

        private void ViewLeagueForm_Load(object sender, EventArgs e)
        {

        }

        private void ViewLeagueForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm_.Show();
        }
    }
}
