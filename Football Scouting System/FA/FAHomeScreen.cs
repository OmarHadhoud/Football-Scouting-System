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

        }

        private void confRejSignBtn_Click(object sender, EventArgs e)
        {

        }

        private void retireBtn_Click(object sender, EventArgs e)
        {

        }

        private void changePasBtn_Click(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {

        }

        private void FAHomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show(); 
        }

        private void addFaBtn_Click(object sender, EventArgs e)
        {

        }

        //Getters
        public int GetFA_ID()
        {
            return FA_ID;
        }

        
    }
}
