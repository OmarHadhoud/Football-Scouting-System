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
    public partial class GuestClubNews : Form
    {
        Form ParentForm_;
        Controller controllerobj;
        DataTable Clubs;
        DataTable news;
        public GuestClubNews(Form _ParentForm_)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm_;
            controllerobj = new Controller();
            UpdateComboBoxes();
            clbsComboBox.SelectedItem = 1;
            news = controllerobj.GetClubNews((int)clbsComboBox.SelectedValue);
            UpdateDataGrid();
        }


        //To update comboboxes
        private void UpdateComboBoxes()
        {
            Clubs = controllerobj.GetAllClubs();
            clbsComboBox.DataSource = Clubs;
            clbsComboBox.DisplayMember = "Name";
            clbsComboBox.ValueMember = "CID";
        }

        private void GuestClubNews_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();

        }

        private void UpdateDataGrid()
        {
            dataGridView1.DataSource = news;
            dataGridView1.Refresh();
        }

        private void clbsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                news = controllerobj.GetClubNews((int)clbsComboBox.SelectedValue);
                UpdateDataGrid();
            }
            catch
            {

            }
        }

        private void readNewsBtn_Click(object sender, EventArgs e)
        {
            string newstxt = (string)dataGridView1.SelectedRows[0].Cells["Text"].Value;
            string newstitle = (string)dataGridView1.SelectedRows[0].Cells["Title"].Value;
            MessageBox.Show(newstxt, newstitle);
        }
    }
}
