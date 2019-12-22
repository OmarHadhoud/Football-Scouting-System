namespace Football_Scouting_System.Club
{
	partial class signscout
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
			this.sendbutton = new System.Windows.Forms.Button();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.feebox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// sendbutton
			// 
			this.sendbutton.Location = new System.Drawing.Point(213, 259);
			this.sendbutton.Name = "sendbutton";
			this.sendbutton.Size = new System.Drawing.Size(374, 50);
			this.sendbutton.TabIndex = 9;
			this.sendbutton.Text = "Send offer";
			this.sendbutton.UseVisualStyleBackColor = true;
			this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Location = new System.Drawing.Point(351, 201);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(236, 24);
			this.dateTimePicker.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(213, 201);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 19);
			this.label2.TabIndex = 7;
			this.label2.Text = "Please select date:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(213, 142);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 19);
			this.label1.TabIndex = 6;
			this.label1.Text = "Please enter fee:";
			// 
			// feebox
			// 
			this.feebox.Location = new System.Drawing.Point(351, 142);
			this.feebox.Name = "feebox";
			this.feebox.Size = new System.Drawing.Size(100, 24);
			this.feebox.TabIndex = 5;
			// 
			// signscout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleGreen;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.sendbutton);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.feebox);
			this.Name = "signscout";
			this.Text = "signscout";
			this.Load += new System.EventHandler(this.signscout_Load);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignScout_FormClosed);

			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button sendbutton;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox feebox;
	}
}