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
    public partial class RequestSigningForm : Form
    {
        ScoutHomeScreen homeScreen;
        Controller controllerobj;
        Form parentForm_;
        int CID;
        string cName;
        public RequestSigningForm(Form _parentForm, ScoutHomeScreen _homeScreen, int _CID, string _cName)
        {
            InitializeComponent();
            controllerobj = new Controller();
            parentForm_ = _parentForm;
            homeScreen = _homeScreen;
            CID = _CID;
            cName = _cName;
        }

        private void RequestSigningForm_Load(object sender, EventArgs e)
        {
            ClubLbl.Text = cName;
            foreach (int id in homeScreen.favs)
            {
                DataTable dt = controllerobj.GetPlayerName_ID(id);
                string name = dt.Rows[0][0].ToString();
                name += ' ';
                name += dt.Rows[0][1].ToString();
                comboBox1.Items.Add(name);
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RequestSigningForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm_.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int PID = comboBox1.SelectedIndex;
            if (PID > -1)
            {
                PID = homeScreen.favs[PID];
                int CID2 = controllerobj.GetPlayerClub(PID);
                if (CID == CID2)
                {
                    MessageBox.Show("Player is already in that club");
                }
                else
                {
                    if (CID2 > 0)
                    {
                        try
                        {
                                int p = controllerobj.ScoutReqSigningC2C(PID, homeScreen.SID, CID, CID2, Convert.ToInt32(numericUpDown1.Value));

                            if (p == 0)
                            {
                                MessageBox.Show("Error");

                            }
                            else
                            {
                                MessageBox.Show("C2C Request send to " + cName);
                            }
                        }
                        catch {
                            MessageBox.Show("Offer Already Existing!"); //could upsert instead but need to check it's the same scout
                        };
                    }
                    else
                    {
                        //should add to C2E instead
                        CID2 = controllerobj.Getefa(CID); //efa ID
                        try
                        {
                            int p = controllerobj.ScoutReqSigningC2E(PID, homeScreen.SID, CID, CID2, Convert.ToInt32(numericUpDown1.Value));


                            if (p == 0)
                            {
                                MessageBox.Show("Error");

                            }
                            else
                            {
                                MessageBox.Show("C2E Request send to " + cName);
                            }
                        }
                        catch { MessageBox.Show("Offer Already Existing!"); } //could upsert instead but need to check it's the same scout
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a valid player (from favorites)");
            }
        }
    }
}
