namespace Football_Scouting_System.Journalist
{
	partial class postarticle
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
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.titletext = new System.Windows.Forms.TextBox();
			this.textbox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(167, 30);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(286, 24);
			this.dateTimePicker1.TabIndex = 16;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(459, 123);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(162, 128);
			this.button1.TabIndex = 15;
			this.button1.Text = "Post";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// titletext
			// 
			this.titletext.Location = new System.Drawing.Point(167, 79);
			this.titletext.Name = "titletext";
			this.titletext.Size = new System.Drawing.Size(286, 24);
			this.titletext.TabIndex = 14;
			this.titletext.Text = "Max 50 characters";
			// 
			// textbox
			// 
			this.textbox.Location = new System.Drawing.Point(167, 123);
			this.textbox.Multiline = true;
			this.textbox.Name = "textbox";
			this.textbox.Size = new System.Drawing.Size(286, 128);
			this.textbox.TabIndex = 13;
			this.textbox.Text = "Max 500 characters";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Magenta;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(33, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 19);
			this.label4.TabIndex = 12;
			this.label4.Text = "Text:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Magenta;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Location = new System.Drawing.Point(33, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 19);
			this.label3.TabIndex = 11;
			this.label3.Text = "Title:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Magenta;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(33, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 19);
			this.label2.TabIndex = 10;
			this.label2.Text = " Date:";
			// 
			// postarticle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkMagenta;
			this.ClientSize = new System.Drawing.Size(646, 277);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.titletext);
			this.Controls.Add(this.textbox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "postarticle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Post an article";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.article_FormClosed);
			this.Load += new System.EventHandler(this.postarticle_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox titletext;
		private System.Windows.Forms.TextBox textbox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}