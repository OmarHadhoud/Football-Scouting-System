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
        private int SID;
        GeneralClasses.Scout Sc;
        public List<int> favs;
        public ScoutHomeScreen(Form _ParentForm, int _SID)
        {
            InitializeComponent();
            controllerobj = new Controller();
            ParentForm_ = _ParentForm;
            SID = _SID;
            favs = new List<int>();
            try
            {
                Sc = new GeneralClasses.Scout(SID);
            }
            catch(Exception ex)
            {
                this.Close();
            }
        }

        private void ScoutHomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }

        private void PlayerSearchBtn_Click(object sender, EventArgs e)
        {
            PlayerSearchForm psf = new PlayerSearchForm(this,SID);
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

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            Scout_profile Sp = new Scout_profile(this , Sc);
            this.Hide();
            Sp.Show();
        }

        private void ScoutHomeScreen_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
