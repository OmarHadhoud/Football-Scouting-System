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
    public partial class AddFa : Form
    {
        private FAHomeScreen ParentForm_;
        Controller controllerobj;

        public AddFa(FAHomeScreen _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
            controllerobj = new Controller();
        }

        private void addFaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = GetFAId();
                string Email = GetFAEmail();
                string Address = GetFAAdress();
                string Pass = GetFAPass();
                controllerobj.insertFA(ID, Email, Address, Pass);
                MessageBox.Show("FA added!");
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //To get Club data and validate it
        private int GetFAId()
        {
            try
            {
                int id = Convert.ToInt32(faIdTxtBox.Text);
                return id;
            }
            catch
            {
                throw new System.Exception("Please make sure you entered numbers only in ID!");
            }
        }

        private string GetFAEmail()
        {
            string email = emailTxtBox.Text;
            return email;
        }

        private string GetFAAdress()
        {
            string addrs = adrsTxtBox.Text;
            return addrs;
        }

        
        private string GetFAPass()
        {
            string pass = passTxtBox.Text;
            if (pass.Length <= 6)
                throw new System.Exception("The club's password must be more than 6 characters!");
            //TODO: Should add hashing here
            return pass;
        }

        private void AddFa_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }
    }
}
