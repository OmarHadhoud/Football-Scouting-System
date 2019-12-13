namespace Football_Scouting_System.FA
{
    partial class AddManagerForm
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
            this.addFaBtn = new System.Windows.Forms.Button();
            this.nationalityTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.clbComboBox = new System.Windows.Forms.ComboBox();
            this.agntComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addFaBtn
            // 
            this.addFaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFaBtn.Location = new System.Drawing.Point(203, 246);
            this.addFaBtn.Name = "addFaBtn";
            this.addFaBtn.Size = new System.Drawing.Size(148, 55);
            this.addFaBtn.TabIndex = 15;
            this.addFaBtn.Text = "Add";
            this.addFaBtn.UseVisualStyleBackColor = true;
            this.addFaBtn.Click += new System.EventHandler(this.addFaBtn_Click);
            // 
            // nationalityTxtBox
            // 
            this.nationalityTxtBox.Location = new System.Drawing.Point(209, 119);
            this.nationalityTxtBox.MaxLength = 50;
            this.nationalityTxtBox.Name = "nationalityTxtBox";
            this.nationalityTxtBox.Size = new System.Drawing.Size(184, 22);
            this.nationalityTxtBox.TabIndex = 13;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(189, 37);
            this.nameTxtBox.MaxLength = 50;
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(153, 22);
            this.nameTxtBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Club:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nationality:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Birthdate:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Agent:";
            // 
            // clbComboBox
            // 
            this.clbComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clbComboBox.FormattingEnabled = true;
            this.clbComboBox.Location = new System.Drawing.Point(189, 166);
            this.clbComboBox.Name = "clbComboBox";
            this.clbComboBox.Size = new System.Drawing.Size(121, 24);
            this.clbComboBox.TabIndex = 19;
            // 
            // agntComboBox
            // 
            this.agntComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agntComboBox.FormattingEnabled = true;
            this.agntComboBox.Location = new System.Drawing.Point(189, 204);
            this.agntComboBox.Name = "agntComboBox";
            this.agntComboBox.Size = new System.Drawing.Size(121, 24);
            this.agntComboBox.TabIndex = 20;
            // 
            // AddManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(526, 369);
            this.Controls.Add(this.agntComboBox);
            this.Controls.Add(this.clbComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addFaBtn);
            this.Controls.Add(this.nationalityTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddManagerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddManagerForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFaBtn;
        private System.Windows.Forms.TextBox nationalityTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox clbComboBox;
        private System.Windows.Forms.ComboBox agntComboBox;
    }
}