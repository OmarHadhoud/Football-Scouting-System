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
    public partial class ViewPlayerAttributes : Form
    {
        private Form ParentForm_;
        private Controller controller;
        private GeneralClasses.PlayerAttributes Attributes;
        public ViewPlayerAttributes(Form _parentForm, int _ID)
        {
            InitializeComponent();
            Attributes = new GeneralClasses.PlayerAttributes(_ID);
            ParentForm_ = _parentForm;
            controller = new Controller();
        }

        private void ViewPlayerAttributes_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }

        private void ViewPlayerAttributes_Load(object sender, EventArgs e)
        {
            /*[Pace] [Acceleration] [Strength] [Jumping] [Shooting] [Passing] [Dribbling] [Positionning] [Off the ball] [Goalkeeper handling] [Goalkeeper positioning] [Goalkeeper decisions]*/
            PaceLbl.Text = Attributes.Attributes[0].ToString();
            AccLbl.Text = Attributes.Attributes[1].ToString();
            StrengthLbl.Text = Attributes.Attributes[2].ToString();
            JumpingLbl.Text = Attributes.Attributes[3].ToString();
            ShootingLbl.Text = Attributes.Attributes[4].ToString();
            PassingLbl.Text = Attributes.Attributes[5].ToString();
            DribblingLbl.Text = Attributes.Attributes[6].ToString();
            PositioningLbl.Text = Attributes.Attributes[7].ToString();
            OTBLbl.Text = Attributes.Attributes[8].ToString();
            GKHLbl.Text = Attributes.Attributes[9].ToString();
            GKPLbl.Text = Attributes.Attributes[10].ToString();
            GKDLbl.Text = Attributes.Attributes[11].ToString();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
