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
    public partial class GuestHomeScreen : Form
    {
        Form ParentForm_;
        public GuestHomeScreen(Form _ParentForm_)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm_;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void clbNewsBtn_Click(object sender, EventArgs e)
        {

        }

        private void clubsBtn_Click(object sender, EventArgs e)
        {

        }

        private void scoutsBtn_Click(object sender, EventArgs e)
        {
            ViewScoutGuestView vsgv = new ViewScoutGuestView(this);
            this.Hide();
            vsgv.Show();
        }

        private void articlesBtn_Click(object sender, EventArgs e)
        {

        }

        private void leaguesBtn_Click(object sender, EventArgs e)
        {

        }

        private void playersBtn_Click(object sender, EventArgs e)
        {

        }

        private void stadiumsBtn_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

        }

        private void GuestHomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }
    }
}
