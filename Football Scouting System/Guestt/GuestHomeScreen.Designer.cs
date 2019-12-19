namespace Football_Scouting_System.Guestt
{
    partial class GuestHomeScreen
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
            this.clbNewsBtn = new System.Windows.Forms.Button();
            this.articlesBtn = new System.Windows.Forms.Button();
            this.scoutsBtn = new System.Windows.Forms.Button();
            this.stadiumsBtn = new System.Windows.Forms.Button();
            this.leaguesBtn = new System.Windows.Forms.Button();
            this.clubsBtn = new System.Windows.Forms.Button();
            this.playersBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbNewsBtn
            // 
            this.clbNewsBtn.Location = new System.Drawing.Point(51, 50);
            this.clbNewsBtn.Name = "clbNewsBtn";
            this.clbNewsBtn.Size = new System.Drawing.Size(105, 65);
            this.clbNewsBtn.TabIndex = 1;
            this.clbNewsBtn.Text = "View Club News";
            this.clbNewsBtn.UseVisualStyleBackColor = true;
            this.clbNewsBtn.Click += new System.EventHandler(this.clbNewsBtn_Click);
            // 
            // articlesBtn
            // 
            this.articlesBtn.Location = new System.Drawing.Point(296, 50);
            this.articlesBtn.Name = "articlesBtn";
            this.articlesBtn.Size = new System.Drawing.Size(105, 65);
            this.articlesBtn.TabIndex = 2;
            this.articlesBtn.Text = "View Articles";
            this.articlesBtn.UseVisualStyleBackColor = true;
            this.articlesBtn.Click += new System.EventHandler(this.articlesBtn_Click);
            // 
            // scoutsBtn
            // 
            this.scoutsBtn.Location = new System.Drawing.Point(552, 50);
            this.scoutsBtn.Name = "scoutsBtn";
            this.scoutsBtn.Size = new System.Drawing.Size(105, 65);
            this.scoutsBtn.TabIndex = 3;
            this.scoutsBtn.Text = "View Scouts";
            this.scoutsBtn.UseVisualStyleBackColor = true;
            this.scoutsBtn.Click += new System.EventHandler(this.scoutsBtn_Click);
            // 
            // stadiumsBtn
            // 
            this.stadiumsBtn.Location = new System.Drawing.Point(51, 180);
            this.stadiumsBtn.Name = "stadiumsBtn";
            this.stadiumsBtn.Size = new System.Drawing.Size(105, 65);
            this.stadiumsBtn.TabIndex = 4;
            this.stadiumsBtn.Text = "View Stadiums";
            this.stadiumsBtn.UseVisualStyleBackColor = true;
            this.stadiumsBtn.Click += new System.EventHandler(this.stadiumsBtn_Click);
            // 
            // leaguesBtn
            // 
            this.leaguesBtn.Location = new System.Drawing.Point(296, 180);
            this.leaguesBtn.Name = "leaguesBtn";
            this.leaguesBtn.Size = new System.Drawing.Size(105, 65);
            this.leaguesBtn.TabIndex = 5;
            this.leaguesBtn.Text = "View Leagues";
            this.leaguesBtn.UseVisualStyleBackColor = true;
            this.leaguesBtn.Click += new System.EventHandler(this.leaguesBtn_Click);
            // 
            // clubsBtn
            // 
            this.clubsBtn.Location = new System.Drawing.Point(552, 180);
            this.clubsBtn.Name = "clubsBtn";
            this.clubsBtn.Size = new System.Drawing.Size(105, 65);
            this.clubsBtn.TabIndex = 6;
            this.clubsBtn.Text = "View Clubs";
            this.clubsBtn.UseVisualStyleBackColor = true;
            this.clubsBtn.Click += new System.EventHandler(this.clubsBtn_Click);
            // 
            // playersBtn
            // 
            this.playersBtn.Location = new System.Drawing.Point(296, 309);
            this.playersBtn.Name = "playersBtn";
            this.playersBtn.Size = new System.Drawing.Size(105, 65);
            this.playersBtn.TabIndex = 7;
            this.playersBtn.Text = "View Players";
            this.playersBtn.UseVisualStyleBackColor = true;
            this.playersBtn.Click += new System.EventHandler(this.playersBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(590, 408);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(105, 30);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // GuestHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.playersBtn);
            this.Controls.Add(this.clubsBtn);
            this.Controls.Add(this.leaguesBtn);
            this.Controls.Add(this.stadiumsBtn);
            this.Controls.Add(this.scoutsBtn);
            this.Controls.Add(this.articlesBtn);
            this.Controls.Add(this.clbNewsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GuestHomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestHomeScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuestHomeScreen_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clbNewsBtn;
        private System.Windows.Forms.Button articlesBtn;
        private System.Windows.Forms.Button scoutsBtn;
        private System.Windows.Forms.Button stadiumsBtn;
        private System.Windows.Forms.Button leaguesBtn;
        private System.Windows.Forms.Button clubsBtn;
        private System.Windows.Forms.Button playersBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}