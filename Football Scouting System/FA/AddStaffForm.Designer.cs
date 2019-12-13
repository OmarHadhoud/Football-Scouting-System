namespace Football_Scouting_System.FA
{
    partial class AddStaffForm
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
            this.addManagerBtn = new System.Windows.Forms.Button();
            this.addCoachBtn = new System.Windows.Forms.Button();
            this.addAgentBtn = new System.Windows.Forms.Button();
            this.addJournalistBtn = new System.Windows.Forms.Button();
            this.addScoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addManagerBtn
            // 
            this.addManagerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addManagerBtn.Location = new System.Drawing.Point(42, 58);
            this.addManagerBtn.Name = "addManagerBtn";
            this.addManagerBtn.Size = new System.Drawing.Size(169, 77);
            this.addManagerBtn.TabIndex = 0;
            this.addManagerBtn.Text = "Add Manager";
            this.addManagerBtn.UseVisualStyleBackColor = true;
            this.addManagerBtn.Click += new System.EventHandler(this.addManagerBtn_Click);
            // 
            // addCoachBtn
            // 
            this.addCoachBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCoachBtn.Location = new System.Drawing.Point(311, 58);
            this.addCoachBtn.Name = "addCoachBtn";
            this.addCoachBtn.Size = new System.Drawing.Size(169, 77);
            this.addCoachBtn.TabIndex = 1;
            this.addCoachBtn.Text = "Add Coach";
            this.addCoachBtn.UseVisualStyleBackColor = true;
            this.addCoachBtn.Click += new System.EventHandler(this.addCoachBtn_Click);
            // 
            // addAgentBtn
            // 
            this.addAgentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAgentBtn.Location = new System.Drawing.Point(567, 58);
            this.addAgentBtn.Name = "addAgentBtn";
            this.addAgentBtn.Size = new System.Drawing.Size(169, 77);
            this.addAgentBtn.TabIndex = 2;
            this.addAgentBtn.Text = "Add Agent";
            this.addAgentBtn.UseVisualStyleBackColor = true;
            this.addAgentBtn.Click += new System.EventHandler(this.addAgentBtn_Click);
            // 
            // addJournalistBtn
            // 
            this.addJournalistBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addJournalistBtn.Location = new System.Drawing.Point(42, 221);
            this.addJournalistBtn.Name = "addJournalistBtn";
            this.addJournalistBtn.Size = new System.Drawing.Size(169, 77);
            this.addJournalistBtn.TabIndex = 3;
            this.addJournalistBtn.Text = "Add Journalist";
            this.addJournalistBtn.UseVisualStyleBackColor = true;
            this.addJournalistBtn.Click += new System.EventHandler(this.addJournalistBtn_Click);
            // 
            // addScoutBtn
            // 
            this.addScoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addScoutBtn.Location = new System.Drawing.Point(567, 221);
            this.addScoutBtn.Name = "addScoutBtn";
            this.addScoutBtn.Size = new System.Drawing.Size(169, 77);
            this.addScoutBtn.TabIndex = 4;
            this.addScoutBtn.Text = "Add Scout";
            this.addScoutBtn.UseVisualStyleBackColor = true;
            this.addScoutBtn.Click += new System.EventHandler(this.addScoutBtn_Click);
            // 
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addScoutBtn);
            this.Controls.Add(this.addJournalistBtn);
            this.Controls.Add(this.addAgentBtn);
            this.Controls.Add(this.addCoachBtn);
            this.Controls.Add(this.addManagerBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddStaffForm";
            this.Text = "AddStaffForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddStaffForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addManagerBtn;
        private System.Windows.Forms.Button addCoachBtn;
        private System.Windows.Forms.Button addAgentBtn;
        private System.Windows.Forms.Button addJournalistBtn;
        private System.Windows.Forms.Button addScoutBtn;
    }
}