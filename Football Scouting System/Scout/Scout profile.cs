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
    public partial class Scout_profile : Form
    {
        GeneralClasses.Scout Sc;
        private Form ParentForm_;
        public Scout_profile(Form _ParentForm, GeneralClasses.Scout Sc_)
        {
            InitializeComponent();
            Sc = Sc_;
            ParentForm_ = _ParentForm;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Scout_profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }

        private void Scout_profile_Load(object sender, EventArgs e)
        {
            NameLbl.Text = Sc.Name;
            ClubLbl.Text = Sc.Club;
            EndorsesLbl.Text =Convert.ToString( Sc.Endorses);
            LicenseNoLbl.Text = Convert.ToString(Sc.LicenseNumber);
            dateTimePicker1.Value = Sc.BirthDate;
            if (Sc.BirthDate <= dateTimePicker1.MinDate)
            {
                dateTimePicker1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeScoutPassword CSP = new ChangeScoutPassword(Sc.ID);
            CSP.Show();
        }
        
    }
}
