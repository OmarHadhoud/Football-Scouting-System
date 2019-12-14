namespace Football_Scouting_System.Club
{
	partial class Searchplayers
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
			this.playerdataGridView = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.nonfreeButton = new System.Windows.Forms.RadioButton();
			this.freeButton = new System.Windows.Forms.RadioButton();
			this.viewallbutton = new System.Windows.Forms.Button();
			this.Namebox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.searchbutton = new System.Windows.Forms.Button();
			this.statbutton = new System.Windows.Forms.Button();
			this.attributesbutton = new System.Windows.Forms.Button();
			this.signingbutton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.playerdataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// playerdataGridView
			// 
			this.playerdataGridView.AllowUserToAddRows = false;
			this.playerdataGridView.AllowUserToDeleteRows = false;
			this.playerdataGridView.AllowUserToResizeColumns = false;
			this.playerdataGridView.AllowUserToResizeRows = false;
			this.playerdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.playerdataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.playerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.playerdataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.playerdataGridView.Location = new System.Drawing.Point(12, 113);
			this.playerdataGridView.Name = "playerdataGridView";
			this.playerdataGridView.RowTemplate.Height = 26;
			this.playerdataGridView.Size = new System.Drawing.Size(545, 244);
			this.playerdataGridView.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.nonfreeButton);
			this.panel1.Controls.Add(this.freeButton);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(326, 30);
			this.panel1.TabIndex = 1;
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
			// 
			// viewallbutton
			// 
			this.viewallbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.viewallbutton.Location = new System.Drawing.Point(344, 12);
			this.viewallbutton.Name = "viewallbutton";
			this.viewallbutton.Size = new System.Drawing.Size(213, 30);
			this.viewallbutton.TabIndex = 2;
			this.viewallbutton.Text = "View All";
			this.viewallbutton.UseVisualStyleBackColor = true;
			this.viewallbutton.Click += new System.EventHandler(this.viewallbutton_Click);
			// 
			// Namebox
			// 
			this.Namebox.Location = new System.Drawing.Point(12, 83);
			this.Namebox.Name = "Namebox";
			this.Namebox.Size = new System.Drawing.Size(325, 24);
			this.Namebox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Please enter player\'s name:";
			// 
			// searchbutton
			// 
			this.searchbutton.Location = new System.Drawing.Point(344, 77);
			this.searchbutton.Name = "searchbutton";
			this.searchbutton.Size = new System.Drawing.Size(213, 30);
			this.searchbutton.TabIndex = 5;
			this.searchbutton.Text = "Search";
			this.searchbutton.UseVisualStyleBackColor = true;
			// 
			// statbutton
			// 
			this.statbutton.Location = new System.Drawing.Point(12, 366);
			this.statbutton.Name = "statbutton";
			this.statbutton.Size = new System.Drawing.Size(138, 47);
			this.statbutton.TabIndex = 6;
			this.statbutton.Text = "Statistics";
			this.statbutton.UseVisualStyleBackColor = true;
			this.statbutton.Click += new System.EventHandler(this.statbutton_Click);
			// 
			// attributesbutton
			// 
			this.attributesbutton.Location = new System.Drawing.Point(156, 366);
			this.attributesbutton.Name = "attributesbutton";
			this.attributesbutton.Size = new System.Drawing.Size(138, 47);
			this.attributesbutton.TabIndex = 7;
			this.attributesbutton.Text = "Attributes";
			this.attributesbutton.UseVisualStyleBackColor = true;
			this.attributesbutton.Click += new System.EventHandler(this.attributesbutton_Click);
			// 
			// signingbutton
			// 
			this.signingbutton.Location = new System.Drawing.Point(12, 419);
			this.signingbutton.Name = "signingbutton";
			this.signingbutton.Size = new System.Drawing.Size(282, 47);
			this.signingbutton.TabIndex = 8;
			this.signingbutton.Text = "Offer a signing";
			this.signingbutton.UseVisualStyleBackColor = true;
			this.signingbutton.Click += new System.EventHandler(this.signingbutton_Click);
			// 
			// Searchplayers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(572, 490);
			this.Controls.Add(this.signingbutton);
			this.Controls.Add(this.attributesbutton);
			this.Controls.Add(this.statbutton);
			this.Controls.Add(this.searchbutton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Namebox);
			this.Controls.Add(this.viewallbutton);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.playerdataGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Searchplayers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search non-free players";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchNonfreePlayersForm_FormClosed);
			this.Load += new System.EventHandler(this.Searchnonfreeplayers_Load);
			((System.ComponentModel.ISupportInitialize)(this.playerdataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView playerdataGridView;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton nonfreeButton;
		private System.Windows.Forms.RadioButton freeButton;
		private System.Windows.Forms.Button viewallbutton;
		private System.Windows.Forms.TextBox Namebox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button searchbutton;
		private System.Windows.Forms.Button statbutton;
		private System.Windows.Forms.Button attributesbutton;
		private System.Windows.Forms.Button signingbutton;
	}
}