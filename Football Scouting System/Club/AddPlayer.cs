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
	public partial class AddPlayer : Form
	{
		private Form ParentForm_;
		Controller controllerobj;
		int clubidd;
		public AddPlayer(Form _ParentForm,int id)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			controllerobj = new Controller();
			clubidd = id;

		}
		private void AddPlayerForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}
		private void AddPlayer_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (radioButton1.Checked==true)
				{
					string FName = GetplayerfirstName();
					string MName = GetplayermiddleName();
					string LName = GetplayerlastName();
					int ID = controllerobj.GetCountOfProfPlayers() + 1;
					int age = getplayerAge();
					string bplace = Getplayerbirthplace();
					string nationality = Getplayernationality();
					DateTime bdate = GetPlayerBD();
					double height = getplayerheight();
					int games = getplayergames();
					int minutes = getplayerminutes();
					double rating = getplayerrating();
					string status = Getplayerstatus();
					controllerobj.insertPlayer(FName, MName, LName, bplace, nationality, bdate, age, height, games, minutes, rating, status, ID, clubidd);
					MessageBox.Show("Player Successfully Inserted!");
					this.Close();
				}
				else
				{
					string FName = GetplayerfirstName();
					string MName = GetplayermiddleName();
					string LName = GetplayerlastName();
					int ID = controllerobj.GetCountOfProfPlayers() + 1;
					int age = getplayerAge();
					string bplace = Getplayerbirthplace();
					string nationality = Getplayernationality();
					DateTime bdate = GetPlayerBD();
					double height = getplayerheight();
					int games = getplayergames();
					int minutes = getplayerminutes();
					double rating = getplayerrating();
					string status = Getplayerstatus();
					controllerobj.insertYouthPlayer(FName, MName, LName, bplace, nationality, bdate, age, height, games, minutes, rating, status, ID, clubidd);
					MessageBox.Show("Player Successfully Inserted!");
					this.Close();
				}
				
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			

		}
		//Get and validate players data
		private string GetplayerfirstName()
		{
			string Name = fnametext.Text;
			if (Name == "")
				throw new System.Exception("Please enter the player's first name!");
			for (int i = 0; i < Name.Length; ++i)
			{
				if (Name[i] >= '0' && Name[i] <= '9')
					throw new System.Exception("Please don't enter numbers in the player name!");
			}
			return Name;
		}

		private string GetplayermiddleName()
		{
			string Name = middlenametext.Text;
			/*if (Name == "")
				throw new System.Exception("Please enter the player's middle name!");*/
			for (int i = 0; i < Name.Length; ++i)
			{
				if (Name[i] >= '0' && Name[i] <= '9')
					throw new System.Exception("Please don't enter numbers in the player name!");
			}
			return Name;
		}

		private string GetplayerlastName()
		{
			string Name = lastnametext.Text;
			if (Name == "")
				throw new System.Exception("Please enter the player's last name!");
			for (int i = 0; i < Name.Length; ++i)
			{
				if (Name[i] >= '0' && Name[i] <= '9')
					throw new System.Exception("Please don't enter numbers in the player name!");
			}
			return Name;
		}

		private string Getplayerbirthplace()
		{
			string Name = birthplacetext.Text;
			/*if (Name == "")
				throw new System.Exception("Please enter the player's birthplace!");*/
			for (int i = 0; i < Name.Length; ++i)
			{
				if (Name[i] >= '0' && Name[i] <= '9')
					throw new System.Exception("Please don't enter numbers in the player's birthplace!");
			}
			return Name;
		}

		private string Getplayernationality()
		{
			string Name = nationalitytext.Text;
			if (Name == "")
				throw new System.Exception("Please enter the player's nationality!");
			for (int i = 0; i < Name.Length; ++i)
			{
				if (Name[i] >= '0' && Name[i] <= '9')
					throw new System.Exception("Please don't enter numbers in the player's nationality!");
			}
			return Name;
		}

		private string Getplayerstatus()
		{
			string Name = statustext.Text;
			if (Name == "")
				throw new System.Exception("Please enter the player's status!");
			for (int i = 0; i < Name.Length; ++i)
			{
				if (Name[i] >= '0' && Name[i] <= '9')
					throw new System.Exception("Please don't enter numbers in the player's status!");
			}
			return Name;
		}

		private DateTime GetPlayerBD()
		{
			DateTime fd = dateTimePicker1.Value.Date;
			return fd;
		}

		private double getplayerheight()
		{
			StringBuilder err = new StringBuilder();
			Object data = ValidationClass.isPositivedouble(heighttext.Text, err); //choose the textbox to be validated
			if (data == null)
			{
				throw new System.Exception(err.ToString());

			}
			else
			{
				double x = (double)data;
				return x;

			}
			// return 0;
		}

		private int getplayergames()
		{
			StringBuilder err = new StringBuilder();
			Object data = ValidationClass.isPositiveInteger(gamesplayedtext.Text, err); //choose the textbox to be validated
			if (data == null)
			{
				throw new System.Exception(err.ToString());

			}
			else
			{
				int x = Convert.ToInt32(gamesplayedtext.Text);
				return x;

			}
			// return 0;
		}

		private int getplayerminutes()
		{
			StringBuilder err = new StringBuilder();
			Object data = ValidationClass.isPositiveInteger(minutesplayedtext.Text, err); //choose the textbox to be validated
			if (data == null)
			{
				throw new System.Exception(err.ToString());

			}
			else
			{
				int x = (int)data;
				return x;

			}
			// return 0;
		}

		private double getplayerrating()
		{
			StringBuilder err = new StringBuilder();
			Object data = ValidationClass.isPositivedouble(ratingtext.Text, err); //choose the textbox to be validated
			if (data == null)
			{
				throw new System.Exception(err.ToString());

			}
			else
			{
				double x = (double)data;
				return x;

			}
			// return 0;
		}

		private int getplayerAge()
		{
			StringBuilder err = new StringBuilder();
			Object data = ValidationClass.isPositiveInteger(IDtext.Text, err); //choose the textbox to be validated
			if (data == null)
			{
				throw new System.Exception(err.ToString());

			}
			else
			{
				int x = (int)data;
				return x;

			}
			// return 0;
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
