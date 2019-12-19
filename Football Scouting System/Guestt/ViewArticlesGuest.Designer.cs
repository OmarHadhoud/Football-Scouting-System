namespace Football_Scouting_System.Guestt
{
    partial class ViewArticlesGuest
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
            this.journalistComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allJournalistsComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.indpJBtn = new System.Windows.Forms.Button();
            this.depJBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // journalistComboBox
            // 
            this.journalistComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.journalistComboBox.FormattingEnabled = true;
            this.journalistComboBox.Location = new System.Drawing.Point(188, 37);
            this.journalistComboBox.Name = "journalistComboBox";
            this.journalistComboBox.Size = new System.Drawing.Size(121, 24);
            this.journalistComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Independent Journalist:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "All journalists:";
            // 
            // allJournalistsComboBox
            // 
            this.allJournalistsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allJournalistsComboBox.FormattingEnabled = true;
            this.allJournalistsComboBox.Location = new System.Drawing.Point(553, 37);
            this.allJournalistsComboBox.Name = "allJournalistsComboBox";
            this.allJournalistsComboBox.Size = new System.Drawing.Size(121, 24);
            this.allJournalistsComboBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 90);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 312);
            this.dataGridView1.TabIndex = 4;
            // 
            // indpJBtn
            // 
            this.indpJBtn.Location = new System.Drawing.Point(328, 40);
            this.indpJBtn.Name = "indpJBtn";
            this.indpJBtn.Size = new System.Drawing.Size(75, 23);
            this.indpJBtn.TabIndex = 5;
            this.indpJBtn.Text = "Show";
            this.indpJBtn.UseVisualStyleBackColor = true;
            this.indpJBtn.Click += new System.EventHandler(this.indpJBtn_Click);
            // 
            // depJBtn
            // 
            this.depJBtn.Location = new System.Drawing.Point(700, 37);
            this.depJBtn.Name = "depJBtn";
            this.depJBtn.Size = new System.Drawing.Size(75, 23);
            this.depJBtn.TabIndex = 6;
            this.depJBtn.Text = "Show";
            this.depJBtn.UseVisualStyleBackColor = true;
            this.depJBtn.Click += new System.EventHandler(this.depJBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Read Article";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewArticlesGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.depJBtn);
            this.Controls.Add(this.indpJBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.allJournalistsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.journalistComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewArticlesGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewArticlesGuest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewArticlesGuest_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox journalistComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox allJournalistsComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button indpJBtn;
        private System.Windows.Forms.Button depJBtn;
        private System.Windows.Forms.Button button1;
    }
}