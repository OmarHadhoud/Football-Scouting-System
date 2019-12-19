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
        public RequestSigningForm(Form _parentForm, ScoutHomeScreen _homeScreen,int _CID,string _cName)
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
            //DataTable dt = controllerobj.SelectAllDep();
            //comboBox1.DataSource = dt;
            //comboBox1.ite
            //comboBox1.DisplayMember = "Dname";
            //comboBox1.ValueMember = "Dnumber";
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RequestSigningForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm_.Show();
        }
    }
}
