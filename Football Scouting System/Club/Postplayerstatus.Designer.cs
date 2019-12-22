namespace Football_Scouting_System.Club
{
	partial class Postplayerstatus
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.scouting_SystemDataSet1 = new Football_Scouting_System.Scouting_SystemDataSet1();
			this.statustext = new System.Windows.Forms.TextBox();
			this.updatestatbutton = new System.Windows.Forms.Button();
			this.scouting_SystemDataSet = new Football_Scouting_System.Scouting_SystemDataSet();
			this.getClubsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.getClubsTableAdapter = new Football_Scouting_System.Scouting_SystemDataSetTableAdapters.GetClubsTableAdapter();
			this.playerTableAdapter = new Football_Scouting_System.Scouting_SystemDataSet1TableAdapters.PlayerTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scouting_SystemDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scouting_SystemDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.getClubsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Orange;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(27, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please select player:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Orange;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(27, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Status:";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(164, 37);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 3;
			// 
			// playerBindingSource
			// 
			this.playerBindingSource.DataMember = "Player";
			this.playerBindingSource.DataSource = this.scouting_SystemDataSet1;
			// 
			// scouting_SystemDataSet1
			// 
			this.scouting_SystemDataSet1.DataSetName = "Scouting_SystemDataSet1";
			this.scouting_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// statustext
			// 
			this.statustext.Location = new System.Drawing.Point(164, 87);
			this.statustext.Name = "statustext";
			this.statustext.Size = new System.Drawing.Size(121, 24);
			this.statustext.TabIndex = 4;
			// 
			// updatestatbutton
			// 
			this.updatestatbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.updatestatbutton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updatestatbutton.Location = new System.Drawing.Point(164, 141);
			this.updatestatbutton.Name = "updatestatbutton";
			this.updatestatbutton.Size = new System.Drawing.Size(121, 55);
			this.updatestatbutton.TabIndex = 5;
			this.updatestatbutton.Text = "Update";
			this.updatestatbutton.UseVisualStyleBackColor = true;
			this.updatestatbutton.Click += new System.EventHandler(this.updatestatbutton_Click);
			// 
			// scouting_SystemDataSet
			// 
			this.scouting_SystemDataSet.DataSetName = "Scouting_SystemDataSet";
			this.scouting_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// getClubsBindingSource
			// 
			this.getClubsBindingSource.DataMember = "GetClubs";
			this.getClubsBindingSource.DataSource = this.scouting_SystemDataSet;
			// 
			// getClubsTableAdapter
			// 
			this.getClubsTableAdapter.ClearBeforeFill = true;
			// 
			// playerTableAdapter
			// 
			this.playerTableAdapter.ClearBeforeFill = true;
			// 
			// Postplayerstatus
			// 
			this.AcceptButton = this.updatestatbutton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkOrange;
			this.ClientSize = new System.Drawing.Size(323, 223);
			this.Controls.Add(this.updatestatbutton);
			this.Controls.Add(this.statustext);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Postplayerstatus";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Post player status";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PostplayerstatusForm_FormClosed);
			this.Load += new System.EventHandler(this.Postplayerstatus_Load);
			((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scouting_SystemDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scouting_SystemDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.getClubsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.BindingSource getClubsBindingSource;
		private Scouting_SystemDataSet scouting_SystemDataSet;
		private System.Windows.Forms.TextBox statustext;
		private System.Windows.Forms.Button updatestatbutton;
		private Scouting_SystemDataSetTableAdapters.GetClubsTableAdapter getClubsTableAdapter;
		private Scouting_SystemDataSet1 scouting_SystemDataSet1;
		private System.Windows.Forms.BindingSource playerBindingSource;
		private Scouting_SystemDataSet1TableAdapters.PlayerTableAdapter playerTableAdapter;
	}
}