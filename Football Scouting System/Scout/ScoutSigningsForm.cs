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
    public partial class ScoutSigningsForm : Form
    {
        private ScoutHomeScreen ParentForm_;
        Controller controllerobj;
        DataTable dt;
        public ScoutSigningsForm(ScoutHomeScreen _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
            controllerobj = new Controller();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }

        private void SigningsForm_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                int scid = (int)dataGridView1.SelectedRows[0].Cells["Club ID"].Value;
                int EfaID = (int)controllerobj.Getefa(scid);
                controllerobj.SetScoutClub(scid, ParentForm_.SID);
                controllerobj.DeleteC2ESOffer(EfaID, scid, ParentForm_.SID);
                MessageBox.Show("Offer accepted!");

                UpdateDataGridView();

            }
            catch
            {
                MessageBox.Show("Please make sure you have chosen an offer!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int scid = (int)dataGridView1.SelectedRows[0].Cells["Club ID"].Value;
                int EfaID = (int)controllerobj.Getefa(scid);
                controllerobj.DeleteC2ESOffer(EfaID, scid,ParentForm_.SID);
                MessageBox.Show("Offer rejected!");
                UpdateDataGridView();
            }
            catch
            {
                MessageBox.Show("Please make sure you have chosen an offer!");
            }
        }

        private void UpdateDataGridView()
        { 
            dt = controllerobj.GetScoutsSignings(ParentForm_.SID);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
