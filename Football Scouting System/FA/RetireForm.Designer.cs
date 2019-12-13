namespace Football_Scouting_System.FA
{
    partial class RetireForm
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
            this.playerComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.retPlayerBtn = new System.Windows.Forms.Button();
            this.retMgrBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mgrComboBox = new System.Windows.Forms.ComboBox();
            this.retCoachBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.coachComboBox = new System.Windows.Forms.ComboBox();
            this.retAgntBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.agentComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // playerComboBox
            // 
            this.playerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerComboBox.FormattingEnabled = true;
            this.playerComboBox.Location = new System.Drawing.Point(137, 31);
            this.playerComboBox.Name = "playerComboBox";
            this.playerComboBox.Size = new System.Drawing.Size(121, 24);
            this.playerComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player:";
            // 
            // retPlayerBtn
            // 
            this.retPlayerBtn.Location = new System.Drawing.Point(290, 32);
            this.retPlayerBtn.Name = "retPlayerBtn";
            this.retPlayerBtn.Size = new System.Drawing.Size(75, 23);
            this.retPlayerBtn.TabIndex = 2;
            this.retPlayerBtn.Text = "Retire";
            this.retPlayerBtn.UseVisualStyleBackColor = true;
            this.retPlayerBtn.Click += new System.EventHandler(this.retPlayerBtn_Click);
            // 
            // retMgrBtn
            // 
            this.retMgrBtn.Location = new System.Drawing.Point(290, 95);
            this.retMgrBtn.Name = "retMgrBtn";
            this.retMgrBtn.Size = new System.Drawing.Size(75, 23);
            this.retMgrBtn.TabIndex = 5;
            this.retMgrBtn.Text = "Retire";
            this.retMgrBtn.UseVisualStyleBackColor = true;
            this.retMgrBtn.Click += new System.EventHandler(this.retMgrBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Manager:";
            // 
            // mgrComboBox
            // 
            this.mgrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mgrComboBox.FormattingEnabled = true;
            this.mgrComboBox.Location = new System.Drawing.Point(137, 94);
            this.mgrComboBox.Name = "mgrComboBox";
            this.mgrComboBox.Size = new System.Drawing.Size(121, 24);
            this.mgrComboBox.TabIndex = 3;
            // 
            // retCoachBtn
            // 
            this.retCoachBtn.Location = new System.Drawing.Point(290, 160);
            this.retCoachBtn.Name = "retCoachBtn";
            this.retCoachBtn.Size = new System.Drawing.Size(75, 23);
            this.retCoachBtn.TabIndex = 8;
            this.retCoachBtn.Text = "Retire";
            this.retCoachBtn.UseVisualStyleBackColor = true;
            this.retCoachBtn.Click += new System.EventHandler(this.retCoachBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Coach:";
            // 
            // coachComboBox
            // 
            this.coachComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coachComboBox.FormattingEnabled = true;
            this.coachComboBox.Location = new System.Drawing.Point(137, 159);
            this.coachComboBox.Name = "coachComboBox";
            this.coachComboBox.Size = new System.Drawing.Size(121, 24);
            this.coachComboBox.TabIndex = 6;
            // 
            // retAgntBtn
            // 
            this.retAgntBtn.Location = new System.Drawing.Point(290, 222);
            this.retAgntBtn.Name = "retAgntBtn";
            this.retAgntBtn.Size = new System.Drawing.Size(75, 23);
            this.retAgntBtn.TabIndex = 11;
            this.retAgntBtn.Text = "Retire";
            this.retAgntBtn.UseVisualStyleBackColor = true;
            this.retAgntBtn.Click += new System.EventHandler(this.retAgntBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Agent:";
            // 
            // agentComboBox
            // 
            this.agentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agentComboBox.FormattingEnabled = true;
            this.agentComboBox.Location = new System.Drawing.Point(137, 221);
            this.agentComboBox.Name = "agentComboBox";
            this.agentComboBox.Size = new System.Drawing.Size(121, 24);
            this.agentComboBox.TabIndex = 9;
            // 
            // RetireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(440, 325);
            this.Controls.Add(this.retAgntBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.agentComboBox);
            this.Controls.Add(this.retCoachBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.coachComboBox);
            this.Controls.Add(this.retMgrBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mgrComboBox);
            this.Controls.Add(this.retPlayerBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerComboBox);
            this.Name = "RetireForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RetireForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RetireForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox playerComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button retPlayerBtn;
        private System.Windows.Forms.Button retMgrBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox mgrComboBox;
        private System.Windows.Forms.Button retCoachBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox coachComboBox;
        private System.Windows.Forms.Button retAgntBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox agentComboBox;
    }
}