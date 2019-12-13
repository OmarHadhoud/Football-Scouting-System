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
    public partial class RetireForm : Form
    {
        private FAHomeScreen ParentForm_;
        Controller controllerobj;
        DataTable Players;
        DataTable Managers;
        DataTable Coaches;
        DataTable Agents;

        public RetireForm(FAHomeScreen _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
            controllerobj = new Controller();
            UpdateComboBoxes();
        }

       

        private void retMgrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                controllerobj.DeleteManager((int)mgrComboBox.SelectedValue);
                UpdateComboBoxes();
            }
            catch
            {
                MessageBox.Show("An error occured! Make sure you've chosen a manager to delete!");
            }
        }

        private void retPlayerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                controllerobj.DeletePlayer((int)playerComboBox.SelectedValue);
                UpdateComboBoxes();

            }
            catch
            {
                MessageBox.Show("An error occured! Make sure you've chosen a player to delete!");
            }
        }

        private void retAgntBtn_Click(object sender, EventArgs e)
        {
            try
            {
                controllerobj.DeleteAgent((int)agentComboBox.SelectedValue);
                UpdateComboBoxes();

            }
            catch
            {
                MessageBox.Show("An error occured! Make sure you've chosen an agent to delete!");
            }
        }

        private void retCoachBtn_Click(object sender, EventArgs e)
        {
            try
            {
                controllerobj.DeleteCoach((int)coachComboBox.SelectedValue);
                UpdateComboBoxes();

            }
            catch
            {
                MessageBox.Show("An error occured! Make sure you've chosen a coach to delete!");
            }
        }

        //To update comboboxes
        private void UpdateComboBoxes()
        {
            Players = controllerobj.GetPlayers();
            playerComboBox.DataSource = Players;
            playerComboBox.DisplayMember = "Name";
            playerComboBox.ValueMember = "PID";
            playerComboBox.SelectedItem = null;

            Managers = controllerobj.GetManagers();
            mgrComboBox.DataSource = Managers;
            mgrComboBox.DisplayMember = "Name";
            mgrComboBox.ValueMember = "MID";
            mgrComboBox.SelectedItem = null;

            Coaches = controllerobj.GetCoaches();
            coachComboBox.DataSource = Coaches;
            coachComboBox.DisplayMember = "Name";
            coachComboBox.ValueMember = "CID";
            coachComboBox.SelectedItem = null;

            Agents = controllerobj.GetAgents();
            agentComboBox.DataSource = Agents;
            agentComboBox.DisplayMember = "Name";
            agentComboBox.ValueMember = "AID";
            agentComboBox.SelectedItem = null;

        }

        private void RetireForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }
    }
}
