namespace Football_Scouting_System.FA
{
    partial class AddScoutForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.addScoutBtn = new System.Windows.Forms.Button();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clbComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 22);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Birthdate:";
            // 
            // addScoutBtn
            // 
            this.addScoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addScoutBtn.Location = new System.Drawing.Point(160, 235);
            this.addScoutBtn.Name = "addScoutBtn";
            this.addScoutBtn.Size = new System.Drawing.Size(148, 55);
            this.addScoutBtn.TabIndex = 26;
            this.addScoutBtn.Text = "Add";
            this.addScoutBtn.UseVisualStyleBackColor = true;
            this.addScoutBtn.Click += new System.EventHandler(this.addScoutBtn_Click);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(160, 52);
            this.nameTxtBox.MaxLength = 50;
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(153, 22);
            this.nameTxtBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name:";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(194, 177);
            this.passwordTxtBox.MaxLength = 50;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(153, 22);
            this.passwordTxtBox.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Club:";
            // 
            // clbComboBox
            // 
            this.clbComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clbComboBox.FormattingEnabled = true;
            this.clbComboBox.Location = new System.Drawing.Point(160, 139);
            this.clbComboBox.Name = "clbComboBox";
            this.clbComboBox.Size = new System.Drawing.Size(121, 24);
            this.clbComboBox.TabIndex = 30;
            // 
            // AddScoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(492, 385);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.clbComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addScoutBtn);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddScoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddScoutForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddScoutForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addScoutBtn;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox clbComboBox;
    }
}