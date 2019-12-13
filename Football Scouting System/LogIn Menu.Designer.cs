namespace Football_Scouting_System
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.userNameTxtbox = new System.Windows.Forms.TextBox();
			this.passTxtBox = new System.Windows.Forms.TextBox();
			this.LogInBtn = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// userNameTxtbox
			// 
			this.userNameTxtbox.BackColor = System.Drawing.Color.DarkGray;
			this.userNameTxtbox.Location = new System.Drawing.Point(135, 276);
			this.userNameTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.userNameTxtbox.Name = "userNameTxtbox";
			this.userNameTxtbox.Size = new System.Drawing.Size(203, 24);
			this.userNameTxtbox.TabIndex = 0;
			this.userNameTxtbox.Text = "Username";
			// 
			// passTxtBox
			// 
			this.passTxtBox.BackColor = System.Drawing.Color.DarkGray;
			this.passTxtBox.Location = new System.Drawing.Point(135, 321);
			this.passTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.passTxtBox.Name = "passTxtBox";
			this.passTxtBox.Size = new System.Drawing.Size(203, 24);
			this.passTxtBox.TabIndex = 1;
			this.passTxtBox.Text = "Password";
			// 
			// LogInBtn
			// 
			this.LogInBtn.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.LogInBtn.Location = new System.Drawing.Point(47, 367);
			this.LogInBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.LogInBtn.Name = "LogInBtn";
			this.LogInBtn.Size = new System.Drawing.Size(120, 39);
			this.LogInBtn.TabIndex = 2;
			this.LogInBtn.Text = "Login";
			this.LogInBtn.UseVisualStyleBackColor = false;
			this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
			this.button2.Location = new System.Drawing.Point(218, 369);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 37);
			this.button2.TabIndex = 3;
			this.button2.Text = "View As Guest";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.DimGray;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(47, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(363, 28);
			this.label1.TabIndex = 4;
			this.label1.Text = "Football Scouting System";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(47, 64);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(291, 174);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.DimGray;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(47, 276);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 19);
			this.label2.TabIndex = 6;
			this.label2.Text = "Username";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.DimGray;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(47, 321);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 19);
			this.label3.TabIndex = 7;
			this.label3.Text = "Password";
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.SlateGray;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(391, 445);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.LogInBtn);
			this.Controls.Add(this.passTxtBox);
			this.Controls.Add(this.userNameTxtbox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Football Scouting System";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTxtbox;
        private System.Windows.Forms.TextBox passTxtBox;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

