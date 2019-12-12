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

    public partial class ScoutHomeScreen : Form
    {
        private Form ParentForm_;
        public ScoutHomeScreen(Form _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
        }

        private void ScoutHomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }

        private void PlayerSearchBtn_Click(object sender, EventArgs e)
        {
            PlayerSearchForm psf = new PlayerSearchForm(this);
            this.Hide();
            psf.Show();
        }

        private void NewsBtn_Click(object sender, EventArgs e)
        {

        }

        private void StadiumsBtn_Click(object sender, EventArgs e)
        {

        }

        private void ScoutsBtn_Click(object sender, EventArgs e)
        {

        }

        private void ClubsBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddYouthPlayerBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
