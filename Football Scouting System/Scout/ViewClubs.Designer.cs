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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RequestSigningBtn = new System.Windows.Forms.Button();
            this.ViewDetailsBtn = new System.Windows.Forms.Button();
            this.RequestWorkingBtn = new System.Windows.Forms.Button();
            this.PlayerDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logOutBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.Location = new System.Drawing.Point(544, 416);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(87, 25);
            this.logOutBtn.TabIndex = 24;
            this.logOutBtn.Text = "Back";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.OldLace;
            this.SearchBtn.Location = new System.Drawing.Point(544, 9);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 23;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.OldLace;
            this.SearchBar.Location = new System.Drawing.Point(12, 13);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(526, 20);
            this.SearchBar.TabIndex = 22;
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
            "First Name",
            "Last Name",
            "Age",
            "Position",
            "Height"});
            this.comboBox1.Location = new System.Drawing.Point(510, 377);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
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
            // PlayerDataGridView
            // 
            this.PlayerDataGridView.AllowUserToAddRows = false;
            this.PlayerDataGridView.AllowUserToDeleteRows = false;
            this.PlayerDataGridView.BackgroundColor = System.Drawing.Color.OldLace;
            this.PlayerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerDataGridView.Location = new System.Drawing.Point(12, 38);
            this.PlayerDataGridView.MultiSelect = false;
            this.PlayerDataGridView.Name = "PlayerDataGridView";
            this.PlayerDataGridView.ReadOnly = true;
            this.PlayerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PlayerDataGridView.ShowEditingIcon = false;
            this.PlayerDataGridView.Size = new System.Drawing.Size(619, 333);
            this.PlayerDataGridView.TabIndex = 15;
            // 
            // ViewClubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RequestSigningBtn);
            this.Controls.Add(this.ViewDetailsBtn);
            this.Controls.Add(this.RequestWorkingBtn);
            this.Controls.Add(this.PlayerDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewClubs";
            this.Text = "ViewClubs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewClubs_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button RequestSigningBtn;
        private System.Windows.Forms.Button ViewDetailsBtn;
        private System.Windows.Forms.Button RequestWorkingBtn;
        private System.Windows.Forms.DataGridView PlayerDataGridView;
    }
}