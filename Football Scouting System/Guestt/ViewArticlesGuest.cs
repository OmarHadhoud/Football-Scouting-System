using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Scouting_System.Guestt
{
    public partial class ViewArticlesGuest : Form
    {
        Form ParentForm_;
        Controller controllerobj;
        DataTable iJourns;
        DataTable Journs;
        DataTable news;
        public ViewArticlesGuest(Form _ParentForm_)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm_;
            controllerobj = new Controller();
            UpdateComboBoxes();
            journalistComboBox.SelectedItem = 1;
            allJournalistsComboBox.SelectedItem = 1;
        }

        //To update comboboxes
        private void UpdateComboBoxes()
        {
            iJourns = controllerobj.GetIndpJournalists();
            Journs = controllerobj.GetAllJournalists();
            journalistComboBox.DataSource = iJourns;
            journalistComboBox.DisplayMember = "Name";
            journalistComboBox.ValueMember = "JID";

            allJournalistsComboBox.DataSource = Journs;
            allJournalistsComboBox.DisplayMember = "Name";
            allJournalistsComboBox.ValueMember = "ID";
        }

        

        private void depJBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerobj.GetArticlesBy((int)allJournalistsComboBox.SelectedValue); ;
            dataGridView1.Refresh();
        }

        private void indpJBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerobj.GetArticlesBy((int)journalistComboBox.SelectedValue); ;
            dataGridView1.Refresh();
        }

        private void ViewArticlesGuest_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			try
			{
				string articletxt = (string)dataGridView1.SelectedRows[0].Cells["Text"].Value;
				string articletitle = (string)dataGridView1.SelectedRows[0].Cells["Title"].Value;
				MessageBox.Show(articletxt, articletitle);
			}
			catch
			{
				MessageBox.Show("Please select an article!");
			}
           
        }
    }
}
