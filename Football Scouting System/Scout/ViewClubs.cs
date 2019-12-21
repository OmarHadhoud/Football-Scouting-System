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
        DataTable dt;
        public ViewClubs(Form _ParentForm)
        {
            InitializeComponent();
            controllerobj = new Controller();
            ParentForm_ = _ParentForm;
            comboBox1.SelectedIndex = 0;
            updateClubsView();
        }

        private void ViewClubs_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }   

        private void SearchBtn_click(object sender, EventArgs e)
        {
            updateClubsView();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateClubsView();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updateClubsView();
        }

        private void updateClubsView()
        {
            int dir = checkBox1.Checked ? 1 : 0;
            dt = controllerobj.Order_Search_Club(comboBox1.SelectedIndex + 1, SearchBar.Text, dir);
            ClubDataGridView.DataSource = dt;
            try { ClubDataGridView.Columns[0].Visible = false; } catch { }
            ClubDataGridView.Refresh();
        }
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            updateClubsView();
        }

        private void RequestWorkingBtn_Click(object sender, EventArgs e)
        {
            int CID;
            int sCID;
            int SID;
            int EfaID;
            try
            {
                try {   CID = Convert.ToInt32(ClubDataGridView.SelectedRows[0].Cells[0].Value.ToString());}
                catch
                {
                    MessageBox.Show("Please select a valid club");
                    throw;
                }

                try {   SID = ((ScoutHomeScreen)ParentForm_).SID; }
                catch
                {
                    MessageBox.Show("Error, Couldn't find your scout ID"); //shouldn't reach this part
                    throw;
                }

                try {   EfaID = controllerobj.Getefa(CID);}
                catch 
                {
                    MessageBox.Show("Error, couldn't find EFA ID"); //shouldn't reach this part
                    throw;
                }

                try{    sCID = controllerobj.GetScoutClub_ID(SID); }
                catch
                {
                    MessageBox.Show("Error, Couldn't retrive your current club"); //shouldn't reach this part
                    throw;
                }
                if (CID == sCID)
                {
                    MessageBox.Show("You're already in that club");
                }
                else
                {
                    //check if submitted
                    try { controllerobj.ScoutReqWorkingC2E(SID, CID, EfaID, Convert.ToInt32(numericUpDown1.Value)); }
                    catch
                    {
                        MessageBox.Show("Offer already existing");
                        throw;
                    }
                    MessageBox.Show("Offer sent");
                }
            }
            catch { }
        }

        private void RequestSigningBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ClubDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                string name = ClubDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                RequestSigningForm RSF = new RequestSigningForm(this, (ScoutHomeScreen)ParentForm_,id,name);
                RSF.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Please select a valid club");
            }
            

        }
    }
}
