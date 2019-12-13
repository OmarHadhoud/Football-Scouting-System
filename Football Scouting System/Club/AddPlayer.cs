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
		public AddPlayer(Form _ParentForm)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			controllerobj = new Controller();

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
				
				string FName = GetplayerfirstName();
				string MName = GetplayermiddleName();
				string LName = GetplayerlastName();
				int ID = getplayerID();
				string bplace = Getplayerbirthplace();
				string nationality = Getplayernationality();
				DateTime bdate = GetPlayerBD();
				float height = getplayerheight();
				int games = getplayergames();
				int minutes = getplayerminutes();
				float rating = getplayerrating();
				string status = Getplayerstatus();
				controllerobj.insertPlayer(FName,MName,LName,bplace,nationality,bdate,height,games,minutes,rating,status,ID);
				MessageBox.Show("Player Successfully Inserted!");
				this.Close();
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

		private float getplayerheight()
		{
			StringBuilder err = new StringBuilder();
			Object data = ValidationClass.isPositiveInteger(heighttext.Text, err); //choose the textbox to be validated
			if (data == null)
			{
				throw new System.Exception(err.ToString());

			}
			else
			{
				float x = (float)data;
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
				int x = (int)data;
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

		private float getplayerrating()
		{
			StringBuilder err = new StringBuilder();
			Object data = ValidationClass.isPositiveInteger(ratingtext.Text, err); //choose the textbox to be validated
			if (data == null)
			{
				throw new System.Exception(err.ToString());

			}
			else
			{
				float x = (float)data;
				return x;

			}
			// return 0;
		}

		private int getplayerID()
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



	}
}
