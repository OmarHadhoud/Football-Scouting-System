namespace Football_Scouting_System.FA
{
    partial class UpdateFA
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
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.telNumTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailBtn = new System.Windows.Forms.Button();
            this.addressBtn = new System.Windows.Forms.Button();
            this.telNumBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(176, 50);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(194, 22);
            this.emailTxtBox.TabIndex = 1;
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(176, 131);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(194, 22);
            this.addressTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address:";
            // 
            // telNumTxtBox
            // 
            this.telNumTxtBox.Location = new System.Drawing.Point(176, 209);
            this.telNumTxtBox.Name = "telNumTxtBox";
            this.telNumTxtBox.Size = new System.Drawing.Size(194, 22);
            this.telNumTxtBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telephone:";
            // 
            // emailBtn
            // 
            this.emailBtn.Location = new System.Drawing.Point(411, 46);
            this.emailBtn.Name = "emailBtn";
            this.emailBtn.Size = new System.Drawing.Size(98, 31);
            this.emailBtn.TabIndex = 6;
            this.emailBtn.Text = "Update";
            this.emailBtn.UseVisualStyleBackColor = true;
            // 
            // addressBtn
            // 
            this.addressBtn.Location = new System.Drawing.Point(411, 122);
            this.addressBtn.Name = "addressBtn";
            this.addressBtn.Size = new System.Drawing.Size(98, 31);
            this.addressBtn.TabIndex = 7;
            this.addressBtn.Text = "Update";
            this.addressBtn.UseVisualStyleBackColor = true;
            // 
            // telNumBtn
            // 
            this.telNumBtn.Location = new System.Drawing.Point(411, 200);
            this.telNumBtn.Name = "telNumBtn";
            this.telNumBtn.Size = new System.Drawing.Size(98, 31);
            this.telNumBtn.TabIndex = 8;
            this.telNumBtn.Text = "Add";
            this.telNumBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateFA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(573, 305);
            this.Controls.Add(this.telNumBtn);
            this.Controls.Add(this.addressBtn);
            this.Controls.Add(this.emailBtn);
            this.Controls.Add(this.telNumTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpdateFA";
            this.Text = "UpdateFA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateFA_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox telNumTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button emailBtn;
        private System.Windows.Forms.Button addressBtn;
        private System.Windows.Forms.Button telNumBtn;
    }
}