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
    public partial class UpdateClubLeague : Form
    {
        private FAHomeScreen ParentForm_;
        Controller controllerobj;
        DataTable FA_Leagues;
        DataTable Clubs;

        public UpdateClubLeague(FAHomeScreen _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
            controllerobj = new Controller();
            UpdateComboBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedValue == null || comboBox2.SelectedValue == null)
                    throw new System.Exception("Please choose both the club and the league!");
                controllerobj.UpdateClubLeague((int)comboBox1.SelectedValue,ParentForm_.GetFA_ID(),(string)comboBox2.SelectedValue);
                MessageBox.Show("League updated successfully!");
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //To update comboboxes
        private void UpdateComboBoxes()
        {
            FA_Leagues = controllerobj.GetLeagues(ParentForm_.GetFA_ID());
            Clubs = controllerobj.GetClubs(ParentForm_.GetFA_ID());
            comboBox1.DataSource = Clubs;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "CID";
            comboBox1.SelectedItem = null;
            comboBox2.DataSource = FA_Leagues;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Name";
            comboBox2.SelectedItem = null;
        }

    }
}
