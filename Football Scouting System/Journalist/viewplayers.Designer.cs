namespace Football_Scouting_System.Journalist
{
	partial class viewplayers
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
			this.attributesbutton = new System.Windows.Forms.Button();
			this.statbutton = new System.Windows.Forms.Button();
			this.searchbutton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Namebox = new System.Windows.Forms.TextBox();
			this.viewallbutton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.nonfreeButton = new System.Windows.Forms.RadioButton();
			this.freeButton = new System.Windows.Forms.RadioButton();
			this.playerdataGridView = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.playerdataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// attributesbutton
			// 
			this.attributesbutton.Location = new System.Drawing.Point(272, 379);
			this.attributesbutton.Name = "attributesbutton";
			this.attributesbutton.Size = new System.Drawing.Size(138, 47);
			this.attributesbutton.TabIndex = 15;
			this.attributesbutton.Text = "Attributes";
			this.attributesbutton.UseVisualStyleBackColor = true;
			this.attributesbutton.Click += new System.EventHandler(this.attributesbutton_Click_1);
			// 
			// statbutton
			// 
			this.statbutton.Location = new System.Drawing.Point(128, 379);
			this.statbutton.Name = "statbutton";
			this.statbutton.Size = new System.Drawing.Size(138, 47);
			this.statbutton.TabIndex = 14;
			this.statbutton.Text = "Statistics";
			this.statbutton.UseVisualStyleBackColor = true;
			this.statbutton.Click += new System.EventHandler(this.statbutton_Click_1);
			// 
			// searchbutton
			// 
			this.searchbutton.Location = new System.Drawing.Point(460, 90);
			this.searchbutton.Name = "searchbutton";
			this.searchbutton.Size = new System.Drawing.Size(213, 30);
			this.searchbutton.TabIndex = 13;
			this.searchbutton.Text = "Search";
			this.searchbutton.UseVisualStyleBackColor = true;
			this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(130, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 17);
			this.label1.TabIndex = 12;
			this.label1.Text = "Please enter player\'s name:";
			// 
			// Namebox
			// 
			this.Namebox.Location = new System.Drawing.Point(128, 96);
			this.Namebox.Name = "Namebox";
			this.Namebox.Size = new System.Drawing.Size(325, 24);
			this.Namebox.TabIndex = 11;
			// 
			// viewallbutton
			// 
			this.viewallbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.viewallbutton.Location = new System.Drawing.Point(460, 25);
			this.viewallbutton.Name = "viewallbutton";
			this.viewallbutton.Size = new System.Drawing.Size(213, 30);
			this.viewallbutton.TabIndex = 10;
			this.viewallbutton.Text = "View All";
			this.viewallbutton.UseVisualStyleBackColor = true;
			this.viewallbutton.Click += new System.EventHandler(this.viewallbutton_Click_1);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.nonfreeButton);
			this.panel1.Controls.Add(this.freeButton);
			this.panel1.Location = new System.Drawing.Point(128, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(326, 30);
			this.panel1.TabIndex = 9;
			// 
			// nonfreeButton
			// 
			this.nonfreeButton.AutoSize = true;
			this.nonfreeButton.Location = new System.Drawing.Point(194, 3);
			this.nonfreeButton.Name = "nonfreeButton";
			this.nonfreeButton.Size = new System.Drawing.Size(129, 21);
			this.nonfreeButton.TabIndex = 1;
			this.nonfreeButton.TabStop = true;
			this.nonfreeButton.Text = "Non-free Players";
			this.nonfreeButton.UseVisualStyleBackColor = true;
			this.nonfreeButton.CheckedChanged += new System.EventHandler(this.nonfreeButton_CheckedChanged_1);
			// 
			// freeButton
			// 
			this.freeButton.AutoSize = true;
			this.freeButton.Location = new System.Drawing.Point(3, 3);
			this.freeButton.Name = "freeButton";
			this.freeButton.Size = new System.Drawing.Size(102, 21);
			this.freeButton.TabIndex = 0;
			this.freeButton.TabStop = true;
			this.freeButton.Text = "Free Players";
			this.freeButton.UseVisualStyleBackColor = true;
			this.freeButton.CheckedChanged += new System.EventHandler(this.freeButton_CheckedChanged_1);
			// 
			// playerdataGridView
			// 
			this.playerdataGridView.AllowUserToAddRows = false;
			this.playerdataGridView.AllowUserToDeleteRows = false;
			this.playerdataGridView.AllowUserToResizeColumns = false;
			this.playerdataGridView.AllowUserToResizeRows = false;
			this.playerdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.playerdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.playerdataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.playerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.playerdataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.playerdataGridView.Location = new System.Drawing.Point(128, 126);
			this.playerdataGridView.Name = "playerdataGridView";
			this.playerdataGridView.RowTemplate.Height = 26;
			this.playerdataGridView.Size = new System.Drawing.Size(545, 244);
			this.playerdataGridView.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.button1.Location = new System.Drawing.Point(548, 379);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 47);
			this.button1.TabIndex = 16;
			this.button1.Text = "Back";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// viewplayers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.attributesbutton);
			this.Controls.Add(this.statbutton);
			this.Controls.Add(this.searchbutton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Namebox);
			this.Controls.Add(this.viewallbutton);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.playerdataGridView);
			this.MaximizeBox = false;
			this.Name = "viewplayers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "View Players";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewPlayersForm_FormClosed);
			this.Load += new System.EventHandler(this.viewplayers_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.playerdataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button attributesbutton;
		private System.Windows.Forms.Button statbutton;
		private System.Windows.Forms.Button searchbutton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Namebox;
		private System.Windows.Forms.Button viewallbutton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton nonfreeButton;
		private System.Windows.Forms.RadioButton freeButton;
		private System.Windows.Forms.DataGridView playerdataGridView;
		private System.Windows.Forms.Button button1;
	}
}