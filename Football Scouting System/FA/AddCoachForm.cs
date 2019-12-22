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
    public partial class AddCoachForm : Form
    {
        AddStaffForm ParentForm_;
        Controller controllerobj;
        DataTable Clubs;

        public AddCoachForm(AddStaffForm _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
            controllerobj = new Controller();
            UpdateComboBoxes();

        }


        //To update comboboxes
        private void UpdateComboBoxes()
        {
            Clubs = controllerobj.GetClubs(ParentForm_.GetFA_ID());
            clbComboBox.DataSource = Clubs;
            clbComboBox.DisplayMember = "Name";
            clbComboBox.ValueMember = "CID";
            clbComboBox.SelectedItem = null;
        }

       
        private void addCoachBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = controllerobj.GetLastIdOfCoaches() + 1;
                string name = nameTxtBox.Text;
                DateTime Bdate = dateTimePicker1.Value;
                int LicenseNumber = controllerobj.GetLastIdOfLicenseNumbers() + 1;
                controllerobj.AddLicense(LicenseNumber);
                int clubId = Convert.ToInt32(clbComboBox.SelectedValue);
                if (clbComboBox.SelectedValue == null) clubId = -1;
                controllerobj.AddCoach(ID, name, Bdate, clubId, LicenseNumber);
                MessageBox.Show("Coach added!");
                MessageBox.Show("The ID of the Coach is " + Convert.ToString(ID));
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddCoachForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }

    }
}
