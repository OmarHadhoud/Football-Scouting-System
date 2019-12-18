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
    public partial class SuggestRatingForm : Form
    {
        private Controller controller;
        int SID;
        int PID;
        public SuggestRatingForm(int _SID,int _PID)
        {
            InitializeComponent();
            controller = new Controller();
            PID = _PID;
            SID = _SID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(PaceNUM.Value) == 0 || Convert.ToInt32(AccNUM.Value) == 0 || Convert.ToInt32(StrengthNUM.Value) == 0 || Convert.ToInt32(JumpingNUM.Value) == 0 || Convert.ToInt32(ShootingNUM.Value) == 0 || Convert.ToInt32(PassingNUM.Value) == 0 || Convert.ToInt32(DribblingNUM.Value) == 0 || Convert.ToInt32(PosNUM.Value) == 0 || Convert.ToInt32(OTBNUM.Value) == 0 || Convert.ToInt32(GKHNUM.Value) == 0 || Convert.ToInt32(GKPNUM.Value) == 0 || Convert.ToInt32(GKDNUM.Value) == 0)
            {
                MessageBox.Show("Please enter all values");
            }
            else
            {
                try
                {
                    controller.AddPlayerRating(PID, SID, Convert.ToInt32(PaceNUM.Value), Convert.ToInt32(AccNUM.Value), Convert.ToInt32(StrengthNUM.Value), Convert.ToInt32(JumpingNUM.Value), Convert.ToInt32(ShootingNUM.Value), Convert.ToInt32(PassingNUM.Value), Convert.ToInt32(DribblingNUM.Value), Convert.ToInt32(PosNUM.Value), Convert.ToInt32(OTBNUM.Value), Convert.ToInt32(GKHNUM.Value), Convert.ToInt32(GKPNUM.Value), Convert.ToInt32(GKDNUM.Value));
                    MessageBox.Show("Added successfully");
                }
                catch
                {

                    MessageBox.Show("Already submitted"); //needes to be edited to allow changes /resubbmission 
                }
                

            }
        }
    }
}
