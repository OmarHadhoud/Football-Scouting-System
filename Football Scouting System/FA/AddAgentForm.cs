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
    public partial class AddAgentForm : Form
    {
        Form ParentForm_;
        Controller controllerobj;

        public AddAgentForm(Form _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
            controllerobj = new Controller();
        }

        private void addAgentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = controllerobj.GetCountOfAgents() + 1;
                string name = nameTxtBox.Text;
                DateTime Bdate = dateTimePicker1.Value;
                int LicenseNumber = controllerobj.GetCountOfLicenseNumbers() + 1;
                controllerobj.AddLicense(LicenseNumber);
                controllerobj.AddAgent(ID, name, Bdate, LicenseNumber);
                MessageBox.Show("Agent added!");
                MessageBox.Show("The ID of the Agent is " + Convert.ToString(ID));
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddAgentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }
    }
}
