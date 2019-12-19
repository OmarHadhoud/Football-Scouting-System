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
