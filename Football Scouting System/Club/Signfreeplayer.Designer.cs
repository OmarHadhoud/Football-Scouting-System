namespace Football_Scouting_System.Club
{
	partial class Signfreeplayer
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
			this.feebox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.sendbutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// feebox
			// 
			this.feebox.Location = new System.Drawing.Point(150, 49);
			this.feebox.Name = "feebox";
			this.feebox.Size = new System.Drawing.Size(100, 24);
			this.feebox.TabIndex = 0;
			this.feebox.TextChanged += new System.EventHandler(this.feebox_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(12, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Please enter fee:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(12, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Please select date:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Location = new System.Drawing.Point(150, 108);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(236, 24);
			this.dateTimePicker.TabIndex = 3;
			this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
			// 
			// sendbutton
			// 
			this.sendbutton.Location = new System.Drawing.Point(12, 166);
			this.sendbutton.Name = "sendbutton";
			this.sendbutton.Size = new System.Drawing.Size(374, 50);
			this.sendbutton.TabIndex = 4;
			this.sendbutton.Text = "Send offer";
			this.sendbutton.UseVisualStyleBackColor = true;
			this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
			// 
			// Signfreeplayer
			// 
			this.AcceptButton = this.sendbutton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(407, 235);
			this.Controls.Add(this.sendbutton);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.feebox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Signfreeplayer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sign a free player";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignPlayer_FormClosed);
			this.Load += new System.EventHandler(this.Signplayer_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox feebox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Button sendbutton;
	}
}