﻿using System;
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
        DataTable Signings;

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
            UpdateDataGridView();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                int scid = (int)dataGridView1.SelectedRows[0].Cells["Club ID"].Value;
                int pid = (int)dataGridView1.SelectedRows[0].Cells["Player ID"].Value;
                controllerobj.SetPlayerClub(scid, pid);
                controllerobj.DeleteC2EOffer(ParentForm_.GetFA_ID(), scid, pid);
                MessageBox.Show("Player offer accepted!");
                UpdateDataGridView();

            }
            catch
            {
                MessageBox.Show("Please make sure you have chosen an offer!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                controllerobj.DeleteC2EOffer(ParentForm_.GetFA_ID(), (int)dataGridView1.SelectedRows[0].Cells["Club ID"].Value, (int)dataGridView1.SelectedRows[0].Cells["Player ID"].Value);
                MessageBox.Show("Player offer accepted!");
                UpdateDataGridView();
            }
            catch
            {
                MessageBox.Show("Please make sure you have chosen an offer!");
            }
        }

        private void UpdateDataGridView()
        {
            Signings = controllerobj.GetFreePlayerOffers(ParentForm_.GetFA_ID());
            dataGridView1.DataSource = Signings;
        }
    }
}
