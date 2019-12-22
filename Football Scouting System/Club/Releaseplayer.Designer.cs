namespace Football_Scouting_System.Club
{
	partial class Releaseplayer
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.releasebutton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(30, 75);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(270, 24);
			this.comboBox1.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.SlateBlue;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(30, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(270, 36);
			this.label1.TabIndex = 4;
			this.label1.Text = "Please select player:";
			// 
			// releasebutton
			// 
			this.releasebutton.Location = new System.Drawing.Point(306, 26);
			this.releasebutton.Name = "releasebutton";
			this.releasebutton.Size = new System.Drawing.Size(138, 73);
			this.releasebutton.TabIndex = 6;
			this.releasebutton.Text = "Release";
			this.releasebutton.UseVisualStyleBackColor = true;
			this.releasebutton.Click += new System.EventHandler(this.releasebutton_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SlateBlue;
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.Location = new System.Drawing.Point(306, 105);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(138, 32);
			this.button1.TabIndex = 7;
			this.button1.Text = "back";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Releaseplayer
			// 
			this.AcceptButton = this.releasebutton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.CancelButton = this.button1;
			this.ClientSize = new System.Drawing.Size(456, 149);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.releasebutton);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Releaseplayer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Release players";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditclubstadiumForm_FormClosed);
			this.Load += new System.EventHandler(this.Editclubstadium_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button releasebutton;
		private System.Windows.Forms.Button button1;
	}
}