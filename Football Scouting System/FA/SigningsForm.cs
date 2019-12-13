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
    public partial class SigningsForm : Form
    {
        private FAHomeScreen ParentForm_;
        Controller controllerobj;

        public SigningsForm(FAHomeScreen _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
            controllerobj = new Controller();
        }

        private void SigningsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }

		private void SigningsForm_Load(object sender, EventArgs e)
		{
            dataGridView1.DataSource = controllerobj.GetFreePlayerOffers(ParentForm_.GetFA_ID());
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DialogResult d  = MessageBox.Show("Approve this signing?","Approve signing",MessageBoxButtons.YesNoCancel);
            }
            catch
            {
                MessageBox.Show("An unexpected error has occured!");
            }

        }
    }
}
