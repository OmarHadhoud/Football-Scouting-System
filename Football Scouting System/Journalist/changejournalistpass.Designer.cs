namespace Football_Scouting_System.Journalist
{
	partial class changejournalistpass
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
			this.backbutton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// backbutton
			// 
			this.backbutton.BackColor = System.Drawing.Color.OrangeRed;
			this.backbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.backbutton.Location = new System.Drawing.Point(410, 168);
			this.backbutton.Name = "backbutton";
			this.backbutton.Size = new System.Drawing.Size(104, 33);
			this.backbutton.TabIndex = 12;
			this.backbutton.Text = "Back";
			this.backbutton.UseVisualStyleBackColor = false;
			this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(416, 36);
			this.label2.TabIndex = 11;
			this.label2.Text = "Please enter the new password:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(173, 87);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(190, 61);
			this.button1.TabIndex = 10;
			this.button1.Text = "Update Password";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(173, 57);
			this.textBox1.MaxLength = 50;
			this.textBox1.Name = "textBox1";
			this.textBox1.PasswordChar = '*';
			this.textBox1.Size = new System.Drawing.Size(190, 24);
			this.textBox1.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 22);
			this.label1.TabIndex = 8;
			this.label1.Text = "New Password:";
			// 
			// changejournalistpass
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Coral;
			this.CancelButton = this.backbutton;
			this.ClientSize = new System.Drawing.Size(532, 210);
			this.Controls.Add(this.backbutton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "changejournalistpass";
			this.Text = "Change password";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.changepassForm_FormClosed);
			this.Load += new System.EventHandler(this.changejournalistpass_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button backbutton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}