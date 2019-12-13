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
        public PlayerSearchForm(Form _ParentForm)
        {
            InitializeComponent();
            controllerobj = new Controller();
            ParentForm_ = _ParentForm;
            comboBox1.SelectedIndex = 0;
            updatePlayersView();
        }

        private void PlayerSearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            updatePlayersView();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePlayersView();
        }

        private void updatePlayersView()
        {
           
            dt = controllerobj.Order_search_PlayerForScouts(comboBox1.SelectedIndex+1, SearchBar.Text);

            PlayerDataGridView.DataSource = dt;
            PlayerDataGridView.Refresh();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewStatsBtn_Click(object sender, EventArgs e)
        {
            // PlayerDataGridView.SelectedRows
        }
    }
}
