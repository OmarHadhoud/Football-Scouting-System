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
    public partial class AddLeagueForm : Form
    {
        private FAHomeScreen ParentForm_;
        Controller controllerobj;

        public AddLeagueForm(FAHomeScreen _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
            controllerobj = new Controller();
        }

        private void AddLeagueForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string LeagueName = textBox1.Text;
                if(LeagueName=="")
                {
                    MessageBox.Show("Please enter the league name!");
                    return;
                }
                controllerobj.insertLeague(ParentForm_.GetFA_ID(), LeagueName);
                MessageBox.Show("League Successfully Inserted!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("An error has occured! Make sure you entered a unique league name!");
            }
        }
    }
}
