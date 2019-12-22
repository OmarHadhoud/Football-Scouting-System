using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Football_Scouting_System
{

	public partial class Form1 : Form
    {
        Controller objcontroller;
		//public int ID;

		public Form1()
        {
            InitializeComponent();
            objcontroller = new Controller();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			//playSimpleSound();
		}
		/*
		private void playSimpleSound()
		{
			SoundPlayer simpleSound = ;
			simpleSound.Play();
		}
		*/
		private void LogInBtn_Click(object sender, EventArgs e)
        {
			int ID =Convert.ToInt32(userNameTxtbox.Text);
            Login(ID);
        }

        private void GuestLogIn_Click(object sender, EventArgs e)
        {
            Guestt.GuestHomeScreen g = new Guestt.GuestHomeScreen(this);
            g.Show();
            this.Hide();
        }
        private void Login(int ID)
        {
            string hashedPass = Football_Scouting_System.Form1.ComputeSha256Hash(passTxtBox.Text);
            string id = userNameTxtbox.Text;
            //Check FAs
            if(objcontroller.LogInFA(ID,hashedPass)==1)
            {
                try
                {
                    FA.FAHomeScreen f = new FA.FAHomeScreen(this,ID);
                    f.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("An unexpected error has occured");
                }
                
            }
            //Check Clubs
            else if(objcontroller.LogInClub(ID, "kkkkkkkk") == 1)
            {
                try
                {
                    Club.ClubHomeScreen C = new Club.ClubHomeScreen(this, ID);
                    C.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("An unexpected error has occured");
                }
            }
            //Check Scouts
            else if (objcontroller.LogInScout(ID, hashedPass) == 1)
            {
                try
                {
                    Scout.ScoutHomeScreen s = new Scout.ScoutHomeScreen(this, ID);
                    s.Show();
                    this.Hide();
                }
                catch 
                {
                    MessageBox.Show("An unexpected error has occured");

                }
            }
            //Check journalist
            else if (objcontroller.LogInJournalist(ID, hashedPass) == 1)
            {
                try
                {
                    Journalist.Journalist j = new Journalist.Journalist(this, ID);
                    j.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("An unexpected error has occured");

                }
            }
            //else invalid
            else
            {
                MessageBox.Show("Invalid ID or Password! Please re-enter a valid one or enter as guest!");
            }
        }
        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
