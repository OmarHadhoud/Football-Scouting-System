namespace Football_Scouting_System.Scout
{
    partial class ViewClubs
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
            this.logOutBtn = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RequestSigningBtn = new System.Windows.Forms.Button();
            this.ViewDetailsBtn = new System.Windows.Forms.Button();
            this.RequestWorkingBtn = new System.Windows.Forms.Button();
            this.ClubDataGridView = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClubDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logOutBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.Location = new System.Drawing.Point(544, 421);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(87, 25);
            this.logOutBtn.TabIndex = 24;
            this.logOutBtn.Text = "Back";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.OldLace;
            this.SearchBar.Location = new System.Drawing.Point(73, 12);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(526, 20);
            this.SearchBar.TabIndex = 22;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sort by:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.OldLace;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "Abbrevation",
            "League name",
            "Squad size",
            "Average age"});
            this.comboBox1.Location = new System.Drawing.Point(510, 377);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RequestSigningBtn
            // 
            this.RequestSigningBtn.BackColor = System.Drawing.Color.OldLace;
            this.RequestSigningBtn.Location = new System.Drawing.Point(12, 394);
            this.RequestSigningBtn.Name = "RequestSigningBtn";
            this.RequestSigningBtn.Size = new System.Drawing.Size(126, 30);
            this.RequestSigningBtn.TabIndex = 18;
            this.RequestSigningBtn.Text = "Request Signing";
            this.RequestSigningBtn.UseVisualStyleBackColor = false;
            // 
            // ViewDetailsBtn
            // 
            this.ViewDetailsBtn.BackColor = System.Drawing.Color.OldLace;
            this.ViewDetailsBtn.Location = new System.Drawing.Point(276, 394);
            this.ViewDetailsBtn.Name = "ViewDetailsBtn";
            this.ViewDetailsBtn.Size = new System.Drawing.Size(126, 30);
            this.ViewDetailsBtn.TabIndex = 17;
            this.ViewDetailsBtn.Text = "View details";
            this.ViewDetailsBtn.UseVisualStyleBackColor = false;
            // 
            // RequestWorkingBtn
            // 
            this.RequestWorkingBtn.BackColor = System.Drawing.Color.OldLace;
            this.RequestWorkingBtn.Location = new System.Drawing.Point(144, 394);
            this.RequestWorkingBtn.Name = "RequestWorkingBtn";
            this.RequestWorkingBtn.Size = new System.Drawing.Size(126, 30);
            this.RequestWorkingBtn.TabIndex = 16;
            this.RequestWorkingBtn.Text = "Request Working";
            this.RequestWorkingBtn.UseVisualStyleBackColor = false;
            // 
            // ClubDataGridView
            // 
            this.ClubDataGridView.AllowUserToAddRows = false;
            this.ClubDataGridView.AllowUserToDeleteRows = false;
            this.ClubDataGridView.BackgroundColor = System.Drawing.Color.OldLace;
            this.ClubDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClubDataGridView.Location = new System.Drawing.Point(12, 38);
            this.ClubDataGridView.MultiSelect = false;
            this.ClubDataGridView.Name = "ClubDataGridView";
            this.ClubDataGridView.ReadOnly = true;
            this.ClubDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClubDataGridView.ShowEditingIcon = false;
            this.ClubDataGridView.Size = new System.Drawing.Size(619, 333);
            this.ClubDataGridView.TabIndex = 15;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(510, 402);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Decending";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Search :";
            // 
            // ViewClubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(642, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RequestSigningBtn);
            this.Controls.Add(this.ViewDetailsBtn);
            this.Controls.Add(this.RequestWorkingBtn);
            this.Controls.Add(this.ClubDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewClubs";
            this.Text = "ViewClubs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewClubs_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ClubDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button RequestSigningBtn;
        private System.Windows.Forms.Button ViewDetailsBtn;
        private System.Windows.Forms.Button RequestWorkingBtn;
        private System.Windows.Forms.DataGridView ClubDataGridView;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
    }
}