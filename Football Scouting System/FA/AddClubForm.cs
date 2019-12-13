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
    public partial class AddClubForm : Form
    {
        private FAHomeScreen ParentForm_;
        Controller controllerobj;
        DataTable FA_Leagues;

        public AddClubForm(FAHomeScreen _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
            controllerobj = new Controller();
            UpdateComboBoxes();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = GetClubId();
                string Name = GetClubName();
                string Abbv = GetClubAbbv();
                string City = GetClubCity();
                string LeagueName = Convert.ToString(comboBox1.SelectedValue);
                DateTime FoundDate = GetClubFD();
                string Pass = GetClubPass();
                controllerobj.insertClub(ID, Name, Abbv, City, LeagueName, ParentForm_.GetFA_ID(), FoundDate, Pass);
                MessageBox.Show("Club added!");
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //To get Club data and validate it
        private int GetClubId()
        {
            try
            {
                int id = Convert.ToInt32(clubIdTxtBox.Text);
                return id;
            }
            catch
            {
                throw new System.Exception("Please make sure you entered numbers only in ID!");
            }
        }

        private string GetClubName()
        {
                string Name = clubNameTxtBox.Text;
                if (Name == "")
                    throw new System.Exception("Please enter the club name!");
            for (int i = 0; i < Name.Length; ++i)
            {
                if (Name[i] >= '0' && Name[i] <= '9')
                    throw new System.Exception("Please don't enter numbers in the club name!");
            }
            return Name;
        }

        private string GetClubAbbv()
        {
            string abbv = clubAbbvTxtBox.Text;
            if (abbv == "")
                throw new System.Exception("Please enter the club abbreviation!");
            return abbv;
        }

        private string GetClubCity()
        {
            string city = clubCityTxtBox.Text;
            for(int i = 0; i < city.Length; ++i)
            {
                if (city[i] >= '0' && city[i] <= '9')
                    throw new System.Exception("Please don't enter numbers in the city name!");
            }
            return city;
        }

        private DateTime GetClubFD()
        {
            DateTime fd = foundDate.Value.Date;
            return fd;
        }

        private string GetClubPass()
        {
            string pass = clubPassTxtBox.Text;
            if (pass.Length <= 6)
                throw new System.Exception("The club's password must be more than 6 characters!");
            //TODO: Should add hashing here
            return pass;
        }

        //To update comboboxes
        private void UpdateComboBoxes()
        {
            FA_Leagues = controllerobj.GetLeagues(ParentForm_.GetFA_ID());
            comboBox1.DataSource = FA_Leagues;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
            comboBox1.SelectedItem = null;
        }

        private void AddClubForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }

    }
}
