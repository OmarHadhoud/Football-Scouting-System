namespace Football_Scouting_System.Club
{
	partial class Endorsenonsignedscouts
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.getscoutBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.scouting_SystemDataSet2 = new Football_Scouting_System.Scouting_SystemDataSet2();
			this.scouting_SystemDataSet1 = new Football_Scouting_System.Scouting_SystemDataSet1();
			this.scoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.scoutTableAdapter = new Football_Scouting_System.Scouting_SystemDataSet1TableAdapters.ScoutTableAdapter();
			this.getscoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.getscoutTableAdapter = new Football_Scouting_System.Scouting_SystemDataSet2TableAdapters.getscoutTableAdapter();
			this.button1 = new System.Windows.Forms.Button();
			this.getscoutBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.getscoutBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scouting_SystemDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scouting_SystemDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scoutBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.getscoutBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.getscoutBindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Red;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(12, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select non-signed scout:";
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.getscoutBindingSource2;
			this.comboBox1.DisplayMember = "Name";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(12, 57);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(161, 24);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.ValueMember = "SID";
			// 
			// getscoutBindingSource1
			// 
			this.getscoutBindingSource1.DataMember = "getscout";
			this.getscoutBindingSource1.DataSource = this.scouting_SystemDataSet2;
			// 
			// scouting_SystemDataSet2
			// 
			this.scouting_SystemDataSet2.DataSetName = "Scouting_SystemDataSet2";
			this.scouting_SystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// scouting_SystemDataSet1
			// 
			this.scouting_SystemDataSet1.DataSetName = "Scouting_SystemDataSet1";
			this.scouting_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// scoutBindingSource
			// 
			this.scoutBindingSource.DataMember = "Scout";
			this.scoutBindingSource.DataSource = this.scouting_SystemDataSet1;
			// 
			// scoutTableAdapter
			// 
			this.scoutTableAdapter.ClearBeforeFill = true;
			// 
			// getscoutBindingSource
			// 
			this.getscoutBindingSource.DataMember = "getscout";
			this.getscoutBindingSource.DataSource = this.scouting_SystemDataSet2;
			// 
			// getscoutTableAdapter
			// 
			this.getscoutTableAdapter.ClearBeforeFill = true;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(179, 23);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(161, 58);
			this.button1.TabIndex = 2;
			this.button1.Text = "Endorse";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// getscoutBindingSource2
			// 
			this.getscoutBindingSource2.DataMember = "getscout";
			this.getscoutBindingSource2.DataSource = this.scouting_SystemDataSet2;
			// 
			// Endorsenonsignedscouts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkRed;
			this.ClientSize = new System.Drawing.Size(352, 109);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Endorsenonsignedscouts";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Endorse non-signed scouts";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EndorsenonsignedscoutsForm_FormClosed);
			this.Load += new System.EventHandler(this.Endorsenonsignedscouts_Load);
			((System.ComponentModel.ISupportInitialize)(this.getscoutBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scouting_SystemDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scouting_SystemDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scoutBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.getscoutBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.getscoutBindingSource2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private Scouting_SystemDataSet1 scouting_SystemDataSet1;
		private System.Windows.Forms.BindingSource scoutBindingSource;
		private Scouting_SystemDataSet1TableAdapters.ScoutTableAdapter scoutTableAdapter;
		private Scouting_SystemDataSet2 scouting_SystemDataSet2;
		private System.Windows.Forms.BindingSource getscoutBindingSource;
		private Scouting_SystemDataSet2TableAdapters.getscoutTableAdapter getscoutTableAdapter;
		private System.Windows.Forms.BindingSource getscoutBindingSource1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.BindingSource getscoutBindingSource2;
	}
}