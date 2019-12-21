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
    public partial class ChangeScoutPassword : Form
    {
        Controller controllerobj;
        int SID;
        public ChangeScoutPassword(int SID_)
        {
            InitializeComponent();
            controllerobj = new Controller();
            SID = SID_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string pass = GetScoutPassword();
                controllerobj.UpdateScoutPassword(SID, pass);
                MessageBox.Show("Password updated!");
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }
        private string GetScoutPassword()
        {
            string pass = textBox1.Text;
            if (pass.Length <= 6)
                throw new System.Exception("The password must be more than 6 characters!");
            string hashedPass = Football_Scouting_System.Form1.ComputeSha256Hash(pass);
            return hashedPass;
        }
    }
}
