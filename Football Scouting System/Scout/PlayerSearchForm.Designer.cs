﻿namespace Football_Scouting_System.Scout
{
    partial class PlayerSearchForm
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
			this.PlayerDataGridView = new System.Windows.Forms.DataGridView();
			this.ViewStatsBtn = new System.Windows.Forms.Button();
			this.FavoriteBtn = new System.Windows.Forms.Button();
			this.ViewAttributesBtn = new System.Windows.Forms.Button();
			this.RateBtn = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SearchBar = new System.Windows.Forms.TextBox();
			this.logOutBtn = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// PlayerDataGridView
			// 
			this.PlayerDataGridView.AllowUserToAddRows = false;
			this.PlayerDataGridView.AllowUserToDeleteRows = false;
			this.PlayerDataGridView.BackgroundColor = System.Drawing.Color.OldLace;
			this.PlayerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PlayerDataGridView.Location = new System.Drawing.Point(0, 41);
			this.PlayerDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.PlayerDataGridView.MultiSelect = false;
			this.PlayerDataGridView.Name = "PlayerDataGridView";
			this.PlayerDataGridView.ReadOnly = true;
			this.PlayerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.PlayerDataGridView.ShowEditingIcon = false;
			this.PlayerDataGridView.Size = new System.Drawing.Size(684, 351);
			this.PlayerDataGridView.TabIndex = 0;
			// 
			// ViewStatsBtn
			// 
			this.ViewStatsBtn.BackColor = System.Drawing.Color.OldLace;
			this.ViewStatsBtn.Location = new System.Drawing.Point(12, 412);
			this.ViewStatsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ViewStatsBtn.Name = "ViewStatsBtn";
			this.ViewStatsBtn.Size = new System.Drawing.Size(147, 37);
			this.ViewStatsBtn.TabIndex = 1;
			this.ViewStatsBtn.Text = "View stats";
			this.ViewStatsBtn.UseVisualStyleBackColor = false;
			this.ViewStatsBtn.Click += new System.EventHandler(this.ViewStatsBtn_Click);
			// 
			// FavoriteBtn
			// 
			this.FavoriteBtn.BackColor = System.Drawing.Color.OldLace;
			this.FavoriteBtn.Location = new System.Drawing.Point(14, 457);
			this.FavoriteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.FavoriteBtn.Name = "FavoriteBtn";
			this.FavoriteBtn.Size = new System.Drawing.Size(147, 37);
			this.FavoriteBtn.TabIndex = 2;
			this.FavoriteBtn.Text = "Favorite";
			this.FavoriteBtn.UseVisualStyleBackColor = false;
			// 
			// ViewAttributesBtn
			// 
			this.ViewAttributesBtn.BackColor = System.Drawing.Color.OldLace;
			this.ViewAttributesBtn.Location = new System.Drawing.Point(201, 412);
			this.ViewAttributesBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ViewAttributesBtn.Name = "ViewAttributesBtn";
			this.ViewAttributesBtn.Size = new System.Drawing.Size(147, 37);
			this.ViewAttributesBtn.TabIndex = 3;
			this.ViewAttributesBtn.Text = "View attributes";
			this.ViewAttributesBtn.UseVisualStyleBackColor = false;
			this.ViewAttributesBtn.Click += new System.EventHandler(this.ViewAttributesBtn_Click);
			// 
			// RateBtn
			// 
			this.RateBtn.BackColor = System.Drawing.Color.OldLace;
			this.RateBtn.Location = new System.Drawing.Point(201, 457);
			this.RateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.RateBtn.Name = "RateBtn";
			this.RateBtn.Size = new System.Drawing.Size(147, 37);
			this.RateBtn.TabIndex = 4;
			this.RateBtn.Text = "Suggest rating";
			this.RateBtn.UseVisualStyleBackColor = false;
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.OldLace;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Age",
            "Position",
            "Height"});
			this.comboBox1.Location = new System.Drawing.Point(528, 420);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(140, 24);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(470, 423);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "Sort by:";
			// 
			// SearchBar
			// 
			this.SearchBar.BackColor = System.Drawing.Color.OldLace;
			this.SearchBar.Location = new System.Drawing.Point(86, 9);
			this.SearchBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SearchBar.Name = "SearchBar";
			this.SearchBar.Size = new System.Drawing.Size(538, 24);
			this.SearchBar.TabIndex = 8;
			this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
			// 
			// logOutBtn
			// 
			this.logOutBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.logOutBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logOutBtn.Location = new System.Drawing.Point(569, 485);
			this.logOutBtn.Margin = new System.Windows.Forms.Padding(2);
			this.logOutBtn.Name = "logOutBtn";
			this.logOutBtn.Size = new System.Drawing.Size(101, 31);
			this.logOutBtn.TabIndex = 14;
			this.logOutBtn.Text = "Back";
			this.logOutBtn.UseVisualStyleBackColor = false;
			this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(528, 453);
			this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(101, 21);
			this.checkBox1.TabIndex = 15;
			this.checkBox1.Text = "Descending";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 17);
			this.label2.TabIndex = 27;
			this.label2.Text = "Search :";
			// 
			// PlayerSearchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(684, 529);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.logOutBtn);
			this.Controls.Add(this.SearchBar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.RateBtn);
			this.Controls.Add(this.ViewAttributesBtn);
			this.Controls.Add(this.FavoriteBtn);
			this.Controls.Add(this.ViewStatsBtn);
			this.Controls.Add(this.PlayerDataGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "PlayerSearchForm";
			this.Text = "Player search";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayerSearchForm_FormClosed);
			this.Load += new System.EventHandler(this.PlayerSearchForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PlayerDataGridView;
        private System.Windows.Forms.Button ViewStatsBtn;
        private System.Windows.Forms.Button FavoriteBtn;
        private System.Windows.Forms.Button ViewAttributesBtn;
        private System.Windows.Forms.Button RateBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
    }
}