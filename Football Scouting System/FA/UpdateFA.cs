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
    public partial class UpdateFA : Form
    {
        private FAHomeScreen ParentForm_;
        Controller controllerobj;

        public UpdateFA(FAHomeScreen _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
            controllerobj = new Controller();
        }

        private void UpdateFA_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }

        private void emailBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string email = emailTxtBox.Text;
                if (email == "")
                    throw new System.Exception("Please enter an Email!");
                controllerobj.UpdateFAEmail(ParentForm_.GetFA_ID(), email);
                MessageBox.Show("Email updated!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addressBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string address = addressTxtBox.Text;
                if (address == "")
                    throw new System.Exception("Please enter an address!");
                controllerobj.UpdateFAAddress(ParentForm_.GetFA_ID(), address);
                MessageBox.Show("Address updated!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void telNumBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string telNum = telNumTxtBox.Text;
                controllerobj.InsertTelNum(ParentForm_.GetFA_ID(), telNum);
                MessageBox.Show("Number added!");
            }
            catch 
            {
                MessageBox.Show("An error occured! Please make sure this number isn't already added!");
            }
        }
    }
}
