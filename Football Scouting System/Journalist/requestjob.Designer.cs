namespace Football_Scouting_System.Journalist
{
	partial class requestjob
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
			this.components = new System.ComponentModel.Container();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.scouting_SystemDataSet1 = new Football_Scouting_System.Scouting_SystemDataSet1();
			this.clubBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clubTableAdapter = new Football_Scouting_System.Scouting_SystemDataSet1TableAdapters.ClubTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.scouting_SystemDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.clubBindingSource;
			this.comboBox1.DisplayMember = "Name";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(15, 60);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(270, 24);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.ValueMember = "CID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.IndianRed;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(15, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Please choose a club:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(327, 37);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(135, 47);
			this.button1.TabIndex = 2;
			this.button1.Text = "Choose";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.IndianRed;
			this.button2.Location = new System.Drawing.Point(327, 129);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(135, 30);
			this.button2.TabIndex = 3;
			this.button2.Text = "Back";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// scouting_SystemDataSet1
			// 
			this.scouting_SystemDataSet1.DataSetName = "Scouting_SystemDataSet1";
			this.scouting_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// clubBindingSource
			// 
			this.clubBindingSource.DataMember = "Club";
			this.clubBindingSource.DataSource = this.scouting_SystemDataSet1;
			// 
			// clubTableAdapter
			// 
			this.clubTableAdapter.ClearBeforeFill = true;
			// 
			// requestjob
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Firebrick;
			this.ClientSize = new System.Drawing.Size(474, 171);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "requestjob";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "requestjob";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.requestForm_FormClosed);
			this.Load += new System.EventHandler(this.requestjob_Load);
			((System.ComponentModel.ISupportInitialize)(this.scouting_SystemDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private Scouting_SystemDataSet1 scouting_SystemDataSet1;
		private System.Windows.Forms.BindingSource clubBindingSource;
		private Scouting_SystemDataSet1TableAdapters.ClubTableAdapter clubTableAdapter;
	}
}