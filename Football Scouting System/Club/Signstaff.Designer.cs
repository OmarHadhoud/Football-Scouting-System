namespace Football_Scouting_System.Club
{
	partial class Signstaff
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.Scoutbutton = new System.Windows.Forms.RadioButton();
			this.Journalistbutton = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.viewbutton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.hirebutton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Goldenrod;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.Journalistbutton);
			this.panel1.Controls.Add(this.Scoutbutton);
			this.panel1.Location = new System.Drawing.Point(41, 80);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(338, 47);
			this.panel1.TabIndex = 0;
			// 
			// Scoutbutton
			// 
			this.Scoutbutton.AutoSize = true;
			this.Scoutbutton.Location = new System.Drawing.Point(12, 9);
			this.Scoutbutton.Name = "Scoutbutton";
			this.Scoutbutton.Size = new System.Drawing.Size(65, 21);
			this.Scoutbutton.TabIndex = 0;
			this.Scoutbutton.TabStop = true;
			this.Scoutbutton.Text = "Scout";
			this.Scoutbutton.UseVisualStyleBackColor = true;
			this.Scoutbutton.CheckedChanged += new System.EventHandler(this.Scoutbutton_CheckedChanged);
			// 
			// Journalistbutton
			// 
			this.Journalistbutton.AutoSize = true;
			this.Journalistbutton.Location = new System.Drawing.Point(191, 9);
			this.Journalistbutton.Name = "Journalistbutton";
			this.Journalistbutton.Size = new System.Drawing.Size(86, 21);
			this.Journalistbutton.TabIndex = 1;
			this.Journalistbutton.TabStop = true;
			this.Journalistbutton.Text = "Journalist";
			this.Journalistbutton.UseVisualStyleBackColor = true;
			this.Journalistbutton.CheckedChanged += new System.EventHandler(this.Journalistbutton_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Goldenrod;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(41, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(535, 36);
			this.label1.TabIndex = 1;
			this.label1.Text = "Please select which one you want to hire:";
			// 
			// viewbutton
			// 
			this.viewbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.viewbutton.Location = new System.Drawing.Point(448, 80);
			this.viewbutton.Name = "viewbutton";
			this.viewbutton.Size = new System.Drawing.Size(128, 47);
			this.viewbutton.TabIndex = 2;
			this.viewbutton.Text = "View all";
			this.viewbutton.UseVisualStyleBackColor = false;
			this.viewbutton.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView1.Location = new System.Drawing.Point(41, 160);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 26;
			this.dataGridView1.Size = new System.Drawing.Size(535, 239);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// hirebutton
			// 
			this.hirebutton.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.hirebutton.Location = new System.Drawing.Point(263, 405);
			this.hirebutton.Name = "hirebutton";
			this.hirebutton.Size = new System.Drawing.Size(116, 47);
			this.hirebutton.TabIndex = 4;
			this.hirebutton.Text = "Hire";
			this.hirebutton.UseVisualStyleBackColor = false;
			this.hirebutton.Click += new System.EventHandler(this.hirebutton_Click);
			// 
			// Signstaff
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.ClientSize = new System.Drawing.Size(627, 493);
			this.Controls.Add(this.hirebutton);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.viewbutton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Signstaff";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sign staff";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignstaffForm_FormClosed);
			this.Load += new System.EventHandler(this.Signstaff_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton Journalistbutton;
		private System.Windows.Forms.RadioButton Scoutbutton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button viewbutton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button hirebutton;
	}
}