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
    public partial class ViewPlayer : Form
    {
        Form ParentForm_;
        Controller controllerobj;
        DataTable dt;
        public ViewPlayer(Form _ParentForm)
        {
            InitializeComponent();
            controllerobj = new Controller();
            ParentForm_ = _ParentForm;
            comboBox1.SelectedIndex = 0;
            updatePlayersView();
        }

        private void ViewPlayer_Load(object sender, EventArgs e)
        {

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
            dt = controllerobj.Order_search_PlayerForScouts(comboBox1.SelectedIndex + 1, SearchBar.Text, dir);
            PlayerDataGridView.DataSource = dt;
            try { PlayerDataGridView.Columns[0].Visible = false; } catch { }
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
            try
            {
                int id = Convert.ToInt32(PlayerDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                Scout.ViewPlayerStats vps = new Scout.ViewPlayerStats(this, id);
                vps.Show();
            }
            catch { MessageBox.Show("Please select a valid player !"); }
        }

        private void ViewAttributesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(PlayerDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                Scout.ViewPlayerAttributes vpa = new Scout.ViewPlayerAttributes(this, id);
                vpa.Show();
            }
            catch { MessageBox.Show("Please select a valid player !"); }
        }


        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            updatePlayersView();
        }


        private void ViewPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }
    }
}
