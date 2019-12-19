namespace Football_Scouting_System.Journalist
{
	partial class Journalist
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.viewinfobutton = new System.Windows.Forms.Button();
			this.postbutton = new System.Windows.Forms.Button();
			this.requestbutton = new System.Windows.Forms.Button();
			this.logbutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// viewinfobutton
			// 
			this.viewinfobutton.Location = new System.Drawing.Point(244, 67);
			this.viewinfobutton.Name = "viewinfobutton";
			this.viewinfobutton.Size = new System.Drawing.Size(272, 85);
			this.viewinfobutton.TabIndex = 0;
			this.viewinfobutton.Text = "View players information";
			this.viewinfobutton.UseVisualStyleBackColor = true;
			this.viewinfobutton.Click += new System.EventHandler(this.viewinfobutton_Click);
			// 
			// postbutton
			// 
			this.postbutton.Location = new System.Drawing.Point(244, 170);
			this.postbutton.Name = "postbutton";
			this.postbutton.Size = new System.Drawing.Size(272, 85);
			this.postbutton.TabIndex = 1;
			this.postbutton.Text = "Post articles";
			this.postbutton.UseVisualStyleBackColor = true;
			this.postbutton.Click += new System.EventHandler(this.postbutton_Click);
			// 
			// requestbutton
			// 
			this.requestbutton.Location = new System.Drawing.Point(244, 278);
			this.requestbutton.Name = "requestbutton";
			this.requestbutton.Size = new System.Drawing.Size(272, 85);
			this.requestbutton.TabIndex = 2;
			this.requestbutton.Text = "Request a club job";
			this.requestbutton.UseVisualStyleBackColor = true;
			this.requestbutton.Click += new System.EventHandler(this.requestbutton_Click);
			// 
			// logbutton
			// 
			this.logbutton.BackColor = System.Drawing.Color.LightPink;
			this.logbutton.Location = new System.Drawing.Point(610, 426);
			this.logbutton.Name = "logbutton";
			this.logbutton.Size = new System.Drawing.Size(140, 55);
			this.logbutton.TabIndex = 5;
			this.logbutton.Text = "Logout";
			this.logbutton.UseVisualStyleBackColor = false;
			this.logbutton.Click += new System.EventHandler(this.logbutton_Click);
			// 
			// Journalist
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Pink;
			this.ClientSize = new System.Drawing.Size(762, 493);
			this.Controls.Add(this.logbutton);
			this.Controls.Add(this.requestbutton);
			this.Controls.Add(this.postbutton);
			this.Controls.Add(this.viewinfobutton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Journalist";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Welcome";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.journalist_FormClosed);
			this.Load += new System.EventHandler(this.Journalist_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button viewinfobutton;
		private System.Windows.Forms.Button postbutton;
		private System.Windows.Forms.Button requestbutton;
		private System.Windows.Forms.Button logbutton;
	}
}