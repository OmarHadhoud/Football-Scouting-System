namespace Football_Scouting_System.FA
{
    partial class AddClubForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clubNameTxtBox = new System.Windows.Forms.TextBox();
            this.clubAbbvTxtBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.foundDate = new System.Windows.Forms.DateTimePicker();
            this.clubPassTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.clubCityTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Club Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Club Abbreviation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Club League:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Club Foundation Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Club Password:";
            // 
            // clubNameTxtBox
            // 
            this.clubNameTxtBox.Location = new System.Drawing.Point(154, 36);
            this.clubNameTxtBox.MaxLength = 50;
            this.clubNameTxtBox.Name = "clubNameTxtBox";
            this.clubNameTxtBox.Size = new System.Drawing.Size(119, 22);
            this.clubNameTxtBox.TabIndex = 7;
            // 
            // clubAbbvTxtBox
            // 
            this.clubAbbvTxtBox.Location = new System.Drawing.Point(233, 92);
            this.clubAbbvTxtBox.MaxLength = 3;
            this.clubAbbvTxtBox.Name = "clubAbbvTxtBox";
            this.clubAbbvTxtBox.Size = new System.Drawing.Size(66, 22);
            this.clubAbbvTxtBox.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // foundDate
            // 
            this.foundDate.Location = new System.Drawing.Point(265, 260);
            this.foundDate.Name = "foundDate";
            this.foundDate.Size = new System.Drawing.Size(247, 22);
            this.foundDate.TabIndex = 10;
            // 
            // clubPassTxtBox
            // 
            this.clubPassTxtBox.Location = new System.Drawing.Point(202, 315);
            this.clubPassTxtBox.MaxLength = 50;
            this.clubPassTxtBox.Name = "clubPassTxtBox";
            this.clubPassTxtBox.PasswordChar = '*';
            this.clubPassTxtBox.Size = new System.Drawing.Size(135, 22);
            this.clubPassTxtBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(597, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 262);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Club";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clubCityTxtBox
            // 
            this.clubCityTxtBox.Location = new System.Drawing.Point(150, 147);
            this.clubCityTxtBox.MaxLength = 50;
            this.clubCityTxtBox.Name = "clubCityTxtBox";
            this.clubCityTxtBox.Size = new System.Drawing.Size(104, 22);
            this.clubCityTxtBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Club City:";
            // 
            // AddClubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.clubCityTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clubPassTxtBox);
            this.Controls.Add(this.foundDate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.clubAbbvTxtBox);
            this.Controls.Add(this.clubNameTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddClubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClubForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddClubForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox clubNameTxtBox;
        private System.Windows.Forms.TextBox clubAbbvTxtBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker foundDate;
        private System.Windows.Forms.TextBox clubPassTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox clubCityTxtBox;
        private System.Windows.Forms.Label label7;
    }
}