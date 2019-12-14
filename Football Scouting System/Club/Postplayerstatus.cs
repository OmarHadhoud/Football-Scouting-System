using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Scouting_System.Club
{
	public partial class Postplayerstatus : Form
	{
		Form ParentForm_;
		Controller Controllerobj;
		DataTable playerstab;
		int ParentclubID;

		public Postplayerstatus(Form _ParentForm,int id)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			Controllerobj = new Controller();
			ParentclubID = id;
			UpdateComboBoxes();

		}

		private void PostplayerstatusForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}

		private void Postplayerstatus_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'scouting_SystemDataSet1.Player' table. You can move, or remove it, as needed.
			this.playerTableAdapter.Fill(this.scouting_SystemDataSet1.Player);

		}

		private void updatestatbutton_Click(object sender, EventArgs e)
		{
				try
				{
				string stat = GetPLAYERSTATUS();

				Controllerobj.UpdateStatus(stat,Convert.ToInt32(comboBox1.SelectedValue));
					MessageBox.Show("Status updated!");
					this.Close();
				}
				catch (System.Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			
		}
		private void UpdateComboBoxes()
		{
			playerstab = Controllerobj.GetPlayers(ParentclubID);
			comboBox1.DataSource = playerstab;
			comboBox1.DisplayMember = "Fname";
			comboBox1.ValueMember = "PID";
			comboBox1.SelectedItem = null;
		}
		private string GetPLAYERSTATUS()
		{
			string status = statustext.Text;
			if (status == "")
				throw new System.Exception("Please enter the player status!");
			return status;
		}

		/*private void fillByToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.playerTableAdapter.FillBy(this.scouting_SystemDataSet1.Player, new System.Nullable<int>(((int)(System.Convert.ChangeType(parameterToolStripTextBox.Text, typeof(int))))));
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			
		}*/
		/*
			private void parameterToolStripTextBox_Click(object sender, EventArgs e)
			{

			}*/
	}
}
