using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Scouting_System.Journalist
{
	public partial class postarticle : Form
	{
		private Form ParentForm_;
		int JID;
		Controller controllerobj;
		public postarticle(Form _ParentForm, int id)
		{
			InitializeComponent();
			ParentForm_ = _ParentForm;
			JID = id;
			controllerobj = new Controller();
		}

		private void article_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm_.Show();
		}

		private void postarticle_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				int pno_ = Getpostno();
				int id_ = getJournalistID();
				string title_ = Gettitle();
				string text_ = Gettext();
				DateTime pd_ = GetnewsPD();
				controllerobj.insertarticle(pno_, id_, pd_, title_, text_);
				MessageBox.Show("Article added!");
				this.Close();
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}



		private int getJournalistID()
		{
			return JID;
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

			int id = controllerobj.GetLastIdOfarticles() + 1;
			return id;
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
