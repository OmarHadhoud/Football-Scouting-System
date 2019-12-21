namespace Football_Scouting_System.Guestt
{
    partial class ViewPlayer
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
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ViewAttributesBtn = new System.Windows.Forms.Button();
            this.ViewStatsBtn = new System.Windows.Forms.Button();
            this.PlayerDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Search :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(465, 370);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "Descending";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logOutBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.Location = new System.Drawing.Point(500, 396);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(87, 25);
            this.logOutBtn.TabIndex = 36;
            this.logOutBtn.Text = "Back";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchBar.Location = new System.Drawing.Point(86, 9);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(462, 20);
            this.SearchBar.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sort by:";
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
            this.comboBox1.Location = new System.Drawing.Point(465, 343);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // ViewAttributesBtn
            // 
            this.ViewAttributesBtn.BackColor = System.Drawing.Color.OldLace;
            this.ViewAttributesBtn.Location = new System.Drawing.Point(184, 337);
            this.ViewAttributesBtn.Name = "ViewAttributesBtn";
            this.ViewAttributesBtn.Size = new System.Drawing.Size(126, 30);
            this.ViewAttributesBtn.TabIndex = 31;
            this.ViewAttributesBtn.Text = "View attributes";
            this.ViewAttributesBtn.UseVisualStyleBackColor = false;
            this.ViewAttributesBtn.Click += new System.EventHandler(this.ViewAttributesBtn_Click);
            // 
            // ViewStatsBtn
            // 
            this.ViewStatsBtn.BackColor = System.Drawing.Color.OldLace;
            this.ViewStatsBtn.Location = new System.Drawing.Point(22, 337);
            this.ViewStatsBtn.Name = "ViewStatsBtn";
            this.ViewStatsBtn.Size = new System.Drawing.Size(126, 30);
            this.ViewStatsBtn.TabIndex = 29;
            this.ViewStatsBtn.Text = "View stats";
            this.ViewStatsBtn.UseVisualStyleBackColor = false;
            this.ViewStatsBtn.Click += new System.EventHandler(this.ViewStatsBtn_Click);
            // 
            // PlayerDataGridView
            // 
            this.PlayerDataGridView.AllowUserToAddRows = false;
            this.PlayerDataGridView.AllowUserToDeleteRows = false;
            this.PlayerDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.PlayerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerDataGridView.Location = new System.Drawing.Point(12, 35);
            this.PlayerDataGridView.MultiSelect = false;
            this.PlayerDataGridView.Name = "PlayerDataGridView";
            this.PlayerDataGridView.ReadOnly = true;
            this.PlayerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PlayerDataGridView.ShowEditingIcon = false;
            this.PlayerDataGridView.Size = new System.Drawing.Size(586, 285);
            this.PlayerDataGridView.TabIndex = 28;
            // 
            // ViewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 435);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ViewAttributesBtn);
            this.Controls.Add(this.ViewStatsBtn);
            this.Controls.Add(this.PlayerDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewPlayer";
            this.Text = "View Player";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewPlayer_FormClosed);
            this.Load += new System.EventHandler(this.ViewPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ViewAttributesBtn;
        private System.Windows.Forms.Button ViewStatsBtn;
        private System.Windows.Forms.DataGridView PlayerDataGridView;
    }
}