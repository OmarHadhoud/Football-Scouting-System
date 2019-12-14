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
    public partial class ViewPlayerStats : Form
    {
        private Form ParentForm_;
        private Controller controller;
        private GeneralClasses.PlayerStats Stats;
        public ViewPlayerStats(Form _parentForm, int _ID)
        {
            InitializeComponent();
            Stats = new GeneralClasses.PlayerStats(_ID);
            ParentForm_ = _parentForm;
            controller = new Controller();
        }

        private void ViewPlayerStats_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }

        private void ViewPlayerStats_Load(object sender, EventArgs e)
        {
            NameLbl.Text = Stats.Name;
            /* [Goals] [Assists] [Games Played] [Minutes Played] [Chances Created] [Match Rating] */
            GoalsLbl.Text = Convert.ToString(Stats.Attributes[0]);
            AssistsLbl.Text = Convert.ToString(Stats.Attributes[1]);
            GamesPLbl.Text = Convert.ToString(Stats.Attributes[2]);
            MinutesPLbl.Text = Convert.ToString(Stats.Attributes[3]);
            ChancesCLbl.Text = Convert.ToString(Stats.Attributes[4]);
            MatchRLbl.Text = Convert.ToString(Stats.Attributes[5]);
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
