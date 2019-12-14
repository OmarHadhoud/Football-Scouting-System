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
        Controller controllerobj;

        public ScoutHomeScreen(Form _ParentForm)
        {
            InitializeComponent();
            controllerobj = new Controller();
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
            NewsForm nf = new NewsForm(this);
            this.Hide();
            nf.Show();
        }

        private void StadiumsBtn_Click(object sender, EventArgs e)
        {

        }

        private void ScoutsBtn_Click(object sender, EventArgs e)
        {

        }

        private void ClubsBtn_Click(object sender, EventArgs e)
        {
            ViewClubs vc = new ViewClubs(this);
            this.Hide();
            vc.Show();
            
        }

        private void AddYouthPlayerBtn_Click(object sender, EventArgs e)
        {

        }

		private void ScoutHomeScreen_Load(object sender, EventArgs e)
		{

		}

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
