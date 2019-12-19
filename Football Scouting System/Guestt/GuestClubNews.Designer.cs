namespace Football_Scouting_System.Guestt
{
    partial class GuestClubNews
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
            this.clbsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.readNewsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // clbsComboBox
            // 
            this.clbsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clbsComboBox.FormattingEnabled = true;
            this.clbsComboBox.Location = new System.Drawing.Point(86, 24);
            this.clbsComboBox.Name = "clbsComboBox";
            this.clbsComboBox.Size = new System.Drawing.Size(121, 24);
            this.clbsComboBox.TabIndex = 0;
            this.clbsComboBox.SelectedIndexChanged += new System.EventHandler(this.clbsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Club:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 77);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(737, 251);
            this.dataGridView1.TabIndex = 2;
            // 
            // readNewsBtn
            // 
            this.readNewsBtn.Location = new System.Drawing.Point(80, 376);
            this.readNewsBtn.Name = "readNewsBtn";
            this.readNewsBtn.Size = new System.Drawing.Size(173, 46);
            this.readNewsBtn.TabIndex = 3;
            this.readNewsBtn.Text = "Read Selected News";
            this.readNewsBtn.UseVisualStyleBackColor = true;
            this.readNewsBtn.Click += new System.EventHandler(this.readNewsBtn_Click);
            // 
            // GuestClubNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.readNewsBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbsComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GuestClubNews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestClubNews";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuestClubNews_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox clbsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button readNewsBtn;
    }
}