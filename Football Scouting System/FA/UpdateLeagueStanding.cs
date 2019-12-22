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
    public partial class UpdateLeagueStanding : Form
    {
        private FAHomeScreen ParentForm_;
        Controller controllerobj;
        DataTable FA_Leagues;

        public UpdateLeagueStanding(FAHomeScreen _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
            controllerobj = new Controller();
            UpdateComboBoxes();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string lgstnd = stndTxtBx.Text;
                controllerobj.UpdateLeagueStanding(ParentForm_.GetFA_ID(), (string)comboBox1.SelectedValue, lgstnd);
                MessageBox.Show("League standing updated successfully!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("An error has happened! Please try again with valid data!");
                this.Close();
            }
        }

        //To update comboboxes
        private void UpdateComboBoxes()
        {
            FA_Leagues = controllerobj.GetLeagues(ParentForm_.GetFA_ID());
            comboBox1.DataSource = FA_Leagues;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
            comboBox1.SelectedItem = null;
        }

        private void UpdateLeagueStanding_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }
    }
}
