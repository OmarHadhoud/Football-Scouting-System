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
    public partial class FAHomeScreen : Form
    {

        int FA_ID = 1;
        private Form ParentForm_;

        public FAHomeScreen(Form _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
        }

        private void addLeagueBtn_Click(object sender, EventArgs e)
        {
            AddLeagueForm alf = new AddLeagueForm(this);
            this.Hide();
            alf.Show();
        }

        private void addClubBtn_Click(object sender, EventArgs e)
        {
            AddClubForm acf = new AddClubForm(this);
            this.Hide();
            acf.Show();
        }

        private void addStaffBtn_Click(object sender, EventArgs e)
        {
            AddStaffForm asf = new AddStaffForm(this);
            this.Hide();
            asf.Show();
        }

        private void confRejSignBtn_Click(object sender, EventArgs e)
        {
            SigningsForm sf = new SigningsForm(this);
            this.Hide();
            sf.Show();
        }

        private void retireBtn_Click(object sender, EventArgs e)
        {
            RetireForm rf = new RetireForm(this);
            this.Hide();
            rf.Show();
        }

        private void changePasBtn_Click(object sender, EventArgs e)
        {
            ChangeFAPasswordForm cfpf = new ChangeFAPasswordForm(this);
            this.Hide();
            cfpf.Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addFaBtn_Click(object sender, EventArgs e)
        {
            AddFa aff = new AddFa(this);
            this.Hide();
            aff.Show();
        }

        private void AddClubToLeagueBtn_Click(object sender, EventArgs e)
        {
            UpdateClubLeague uclf = new UpdateClubLeague(this);
            this.Hide();
            uclf.Show();
        }

        private void FAHomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show(); 
        }

        private void updtFaBtn_Click(object sender, EventArgs e)
        {
            UpdateFA uff = new UpdateFA(this);
            this.Hide();
            uff.Show();
        }

        //Getters
        public int GetFA_ID()
        {
            return FA_ID;
        }

        private void FAHomeScreen_Load(object sender, EventArgs e)
        {
            if(FA_ID!=1)
                addFaBtn.Enabled = false;
        }

        
    }
}
