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
    public partial class AddJournalistForm : Form
    {
        AddStaffForm ParentForm_;
        Controller controllerobj;

        public AddJournalistForm(AddStaffForm _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
            controllerobj = new Controller();
        }
        private void addJournalistBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = controllerobj.GetCountOfJournalists() + 1;
                string name = nameTxtBox.Text;
                DateTime Bdate = dateTimePicker1.Value;
                string pass = GetPass();
                controllerobj.AddJournalist(ID, name, Bdate, pass);
                MessageBox.Show("Journalist added!");
                MessageBox.Show("The ID of the Journalist is (Use it to login) " + Convert.ToString(ID));
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

        private void AddJournalistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }

        

       

        
    }
}
