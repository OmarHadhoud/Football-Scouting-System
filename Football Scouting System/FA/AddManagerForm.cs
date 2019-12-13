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
    public partial class AddManagerForm : Form
    {
        AddStaffForm ParentForm_;
        Controller controllerobj;
        DataTable Clubs;
        DataTable Agents;

        public AddManagerForm(AddStaffForm _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
            controllerobj = new Controller();
            UpdateComboBoxes();
        }

      
        private void addFaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = controllerobj.GetCountOfManagers() + 1;
                string name = nameTxtBox.Text;
                string Nationality = GetManagerNationality();
                DateTime Bdate = dateTimePicker1.Value;
                int clubId = Convert.ToInt32(clbComboBox.SelectedValue);
                int AgentId = Convert.ToInt32(agntComboBox.SelectedValue);
                if (clbComboBox.SelectedValue == null) clubId = -1;
                if (agntComboBox.SelectedValue == null) AgentId = -1;
                controllerobj.AddManager(ID, name, Bdate, Nationality, clubId, AgentId);
                MessageBox.Show("Manager added!");
                MessageBox.Show("The ID of the Manager is " + Convert.ToString(ID));
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //To get Club data and validate it


        private string GetManagerNationality()
        {
            string nat = nationalityTxtBox.Text;
            return nat;
        }

       
        //To update comboboxes
        private void UpdateComboBoxes()
        {
            Clubs = controllerobj.GetClubs(ParentForm_.GetFA_ID());
            clbComboBox.DataSource = Clubs;
            clbComboBox.DisplayMember = "Name";
            clbComboBox.ValueMember = "CID";
            clbComboBox.SelectedItem = null;
            Agents = controllerobj.GetAgents();
            agntComboBox.DataSource = Agents;
            agntComboBox.DisplayMember = "Name";
            agntComboBox.ValueMember = "AID";
            agntComboBox.SelectedItem = null;
        }

        private void AddManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }

    }
}
