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
	public partial class Postnews : Form
	{
		Controller Controllerobj;
		Form ParentForm_;
		int CID;
		public Postnews(Form _ParentForm,int clubid)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			Controllerobj = new Controller();
			CID = clubid;

		}

		private void PostnewsForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}

		private void Postnews_Load(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				int pno_ = Getpostno();
				int id_ = getID();
				string title_ = Gettitle();
				string text_ = Gettext();
				DateTime pd_ = GetnewsPD();
				Controllerobj.insertnews(pno_, id_, pd_, title_, text_);
				MessageBox.Show("Post added!");
				this.Close();
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private int getID()
		{
			return CID;
		}
		private DateTime GetnewsPD()
		{
			DateTime fd = dateTimePicker1.Value.Date;
			return fd;
		}
		private string Gettext()
		{
			string text = textbox.Text;
			if (text == "")
				throw new System.Exception("Please enter the text!");
			return text;
		}
		private string Gettitle()
		{
			string title = titletext.Text;
			if (title == "")
				throw new System.Exception("Please enter the title!");
			return title;
		}
		private int Getpostno() //to be modified with auto-generaton for ids
		{
			return Controllerobj.GetCountOfnews();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
