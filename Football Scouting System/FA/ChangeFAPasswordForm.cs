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
    public partial class ChangeFAPasswordForm : Form
    {
        private FAHomeScreen ParentForm_;
        Controller controllerobj;

        public ChangeFAPasswordForm(FAHomeScreen _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
            controllerobj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string pass = GetFAPassword();
                controllerobj.UpdateFAPassword(ParentForm_.GetFA_ID(), pass);
                MessageBox.Show("Password updated!");
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void ChangeFAPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }

        private string GetFAPassword()
        {
            string pass = textBox1.Text;
            if (pass.Length <= 6)
                throw new System.Exception("The club's password must be more than 6 characters!");
            string hashedPass = Football_Scouting_System.Form1.ComputeSha256Hash(pass);
            return hashedPass;
        }
    }
}
