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
    public partial class AddScoutForm : Form
    {
        AddStaffForm ParentForm_;
        Controller controllerobj;
        DataTable Clubs;

        public AddScoutForm(AddStaffForm _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
            controllerobj = new Controller();
            UpdateComboBoxes();
        }


        private void addScoutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = controllerobj.GetCountOfScouts() + 1;
                string name = nameTxtBox.Text;
                DateTime Bdate = dateTimePicker1.Value;
                int LicenseNumber = controllerobj.GetCountOfLicenseNumbers() + 1;
                controllerobj.AddLicense(LicenseNumber);
                int clubId = Convert.ToInt32(clbComboBox.SelectedValue);
                string pass = GetPass();
                if (clbComboBox.SelectedValue == null) clubId = -1;
                controllerobj.AddScout(ID, name, Bdate, 0, pass, clubId, LicenseNumber);
                MessageBox.Show("Scout added!");
                MessageBox.Show("The ID of the Scout is " + Convert.ToString(ID));
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetPass()
        {
            string pass = passwordTxtBox.Text;
            if (pass.Length <= 6)
                throw new System.Exception("The club's password must be more than 6 characters!");
            string hashedPass = Football_Scouting_System.Form1.ComputeSha256Hash(pass);
            return hashedPass;
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

        private void AddScoutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();

        }
    }
}
