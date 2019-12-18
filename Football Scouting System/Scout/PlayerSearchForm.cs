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
    public partial class PlayerSearchForm : Form
    {
        Form ParentForm_;
        Controller controllerobj;
        DataTable dt;
        int SID;
        public PlayerSearchForm(Form _ParentForm, int _SID)
        {
            InitializeComponent();
            controllerobj = new Controller();
            ParentForm_ = _ParentForm;
            comboBox1.SelectedIndex = 0;
            updatePlayersView();
            SID = _SID;
        }

        private void PlayerSearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }


        private void SearchBtn_click(object sender, EventArgs e)
        {
            updatePlayersView();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePlayersView();
        }

        private void updatePlayersView()
        {
            int dir = checkBox1.Checked ? 1 : 0;
            dt = controllerobj.Order_search_PlayerForScouts(comboBox1.SelectedIndex+1, SearchBar.Text,dir);
            PlayerDataGridView.DataSource = dt;
            try { PlayerDataGridView.Columns[0].Visible = false; } catch{ }
            PlayerDataGridView.Refresh();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updatePlayersView();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewStatsBtn_Click(object sender, EventArgs e)
        {
            try { int id = Convert.ToInt32(PlayerDataGridView.SelectedRows[0].Cells[0].Value.ToString()); 
            ViewPlayerStats vps = new ViewPlayerStats(this,id);
            vps.Show();
            }
            catch { MessageBox.Show("Please select a valid player !"); }
        }

        private void ViewAttributesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(PlayerDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                ViewPlayerAttributes vpa = new ViewPlayerAttributes(this, id);
                vpa.Show();
            }
            catch { MessageBox.Show("Please select a valid player !"); }
        }


        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            updatePlayersView();
        }

		private void PlayerSearchForm_Load(object sender, EventArgs e)
		{

		}

        private void FavoriteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(PlayerDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                ScoutHomeScreen f = (ScoutHomeScreen)ParentForm_; //Casting the parent form
                if (!f.favs.Contains(id)) {
                    f.favs.Add(id);
                    MessageBox.Show("Player added to favorites");
                }
                else
                {
                    f.favs.Remove(id);
                    MessageBox.Show("Player removed from favorites");
                }

            }
            catch { MessageBox.Show("Please select a valid player !"); }
        }

        private void RateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(PlayerDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                SuggestRatingForm srf = new SuggestRatingForm(SID,id);
                srf.Show();
            }
            catch { MessageBox.Show("Please select a valid player !"); }
        }
    }
}
