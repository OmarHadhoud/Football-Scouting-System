namespace Football_Scouting_System.FA
{
    partial class AddFa
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.adrsTxtBox = new System.Windows.Forms.TextBox();
            this.passTxtBox = new System.Windows.Forms.TextBox();
            this.addFaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(112, 38);
            this.emailTxtBox.MaxLength = 50;
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(153, 22);
            this.emailTxtBox.TabIndex = 5;
            // 
            // adrsTxtBox
            // 
            this.adrsTxtBox.Location = new System.Drawing.Point(129, 107);
            this.adrsTxtBox.MaxLength = 50;
            this.adrsTxtBox.Name = "adrsTxtBox";
            this.adrsTxtBox.Size = new System.Drawing.Size(184, 22);
            this.adrsTxtBox.TabIndex = 6;
            // 
            // passTxtBox
            // 
            this.passTxtBox.Location = new System.Drawing.Point(143, 181);
            this.passTxtBox.MaxLength = 50;
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.PasswordChar = '*';
            this.passTxtBox.Size = new System.Drawing.Size(110, 22);
            this.passTxtBox.TabIndex = 7;
            // 
            // addFaBtn
            // 
            this.addFaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFaBtn.Location = new System.Drawing.Point(126, 247);
            this.addFaBtn.Name = "addFaBtn";
            this.addFaBtn.Size = new System.Drawing.Size(148, 55);
            this.addFaBtn.TabIndex = 8;
            this.addFaBtn.Text = "Add";
            this.addFaBtn.UseVisualStyleBackColor = true;
            this.addFaBtn.Click += new System.EventHandler(this.addFaBtn_Click);
            // 
            // AddFa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(353, 363);
            this.Controls.Add(this.addFaBtn);
            this.Controls.Add(this.passTxtBox);
            this.Controls.Add(this.adrsTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddFa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddFa_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.TextBox adrsTxtBox;
        private System.Windows.Forms.TextBox passTxtBox;
        private System.Windows.Forms.Button addFaBtn;
    }
}