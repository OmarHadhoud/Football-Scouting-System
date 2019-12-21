namespace Football_Scouting_System.Scout
{
    partial class AddYouthPlayer
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.IDtext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.minutesplayedtext = new System.Windows.Forms.TextBox();
            this.gamesplayedtext = new System.Windows.Forms.TextBox();
            this.ratingtext = new System.Windows.Forms.TextBox();
            this.birthplacetext = new System.Windows.Forms.TextBox();
            this.statustext = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fnametext = new System.Windows.Forms.TextBox();
            this.middlenametext = new System.Windows.Forms.TextBox();
            this.lastnametext = new System.Windows.Forms.TextBox();
            this.nationalitytext = new System.Windows.Forms.TextBox();
            this.heighttext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubIDName = new Football_Scouting_System.ClubIDName();
            this.clubTableAdapter = new Football_Scouting_System.ClubIDNameTableAdapters.ClubTableAdapter();
            this.logOutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubIDName)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 154);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1960, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker1.TabIndex = 56;
            // 
            // IDtext
            // 
            this.IDtext.Location = new System.Drawing.Point(356, 157);
            this.IDtext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(86, 20);
            this.IDtext.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LemonChiffon;
            this.label5.Location = new System.Drawing.Point(321, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Age:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LemonChiffon;
            this.label12.Location = new System.Drawing.Point(256, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Rating:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LemonChiffon;
            this.label11.Location = new System.Drawing.Point(256, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Minutes Played:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LemonChiffon;
            this.label10.Location = new System.Drawing.Point(256, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Games played:";
            // 
            // minutesplayedtext
            // 
            this.minutesplayedtext.Location = new System.Drawing.Point(356, 120);
            this.minutesplayedtext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minutesplayedtext.Name = "minutesplayedtext";
            this.minutesplayedtext.Size = new System.Drawing.Size(86, 20);
            this.minutesplayedtext.TabIndex = 50;
            // 
            // gamesplayedtext
            // 
            this.gamesplayedtext.Location = new System.Drawing.Point(356, 83);
            this.gamesplayedtext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gamesplayedtext.Name = "gamesplayedtext";
            this.gamesplayedtext.Size = new System.Drawing.Size(86, 20);
            this.gamesplayedtext.TabIndex = 49;
            // 
            // ratingtext
            // 
            this.ratingtext.Location = new System.Drawing.Point(356, 48);
            this.ratingtext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ratingtext.Name = "ratingtext";
            this.ratingtext.Size = new System.Drawing.Size(86, 20);
            this.ratingtext.TabIndex = 48;
            // 
            // birthplacetext
            // 
            this.birthplacetext.Location = new System.Drawing.Point(125, 196);
            this.birthplacetext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthplacetext.Name = "birthplacetext";
            this.birthplacetext.Size = new System.Drawing.Size(86, 20);
            this.birthplacetext.TabIndex = 47;
            // 
            // statustext
            // 
            this.statustext.Location = new System.Drawing.Point(125, 310);
            this.statustext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statustext.Name = "statustext";
            this.statustext.Size = new System.Drawing.Size(86, 20);
            this.statustext.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LemonChiffon;
            this.label9.Location = new System.Drawing.Point(53, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Birthplace:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LemonChiffon;
            this.label8.Location = new System.Drawing.Point(53, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Status:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(256, 276);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 56);
            this.button1.TabIndex = 43;
            this.button1.Text = "Add Player";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fnametext
            // 
            this.fnametext.Location = new System.Drawing.Point(125, 48);
            this.fnametext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fnametext.Name = "fnametext";
            this.fnametext.Size = new System.Drawing.Size(86, 20);
            this.fnametext.TabIndex = 42;
            // 
            // middlenametext
            // 
            this.middlenametext.Location = new System.Drawing.Point(125, 83);
            this.middlenametext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.middlenametext.Name = "middlenametext";
            this.middlenametext.Size = new System.Drawing.Size(86, 20);
            this.middlenametext.TabIndex = 41;
            // 
            // lastnametext
            // 
            this.lastnametext.Location = new System.Drawing.Point(125, 120);
            this.lastnametext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastnametext.Name = "lastnametext";
            this.lastnametext.Size = new System.Drawing.Size(86, 20);
            this.lastnametext.TabIndex = 40;
            // 
            // nationalitytext
            // 
            this.nationalitytext.Location = new System.Drawing.Point(125, 235);
            this.nationalitytext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nationalitytext.Name = "nationalitytext";
            this.nationalitytext.Size = new System.Drawing.Size(86, 20);
            this.nationalitytext.TabIndex = 39;
            // 
            // heighttext
            // 
            this.heighttext.Location = new System.Drawing.Point(125, 273);
            this.heighttext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heighttext.Name = "heighttext";
            this.heighttext.Size = new System.Drawing.Size(86, 20);
            this.heighttext.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LemonChiffon;
            this.label7.Location = new System.Drawing.Point(53, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LemonChiffon;
            this.label6.Location = new System.Drawing.Point(53, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Nationality:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LemonChiffon;
            this.label4.Location = new System.Drawing.Point(53, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Birthdate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LemonChiffon;
            this.label3.Location = new System.Drawing.Point(53, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Last:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(53, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Middle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(53, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "First name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(256, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "Club:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clubBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(321, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 58;
            this.comboBox1.ValueMember = "CID";
            // 
            // clubBindingSource
            // 
            this.clubBindingSource.DataMember = "Club";
            this.clubBindingSource.DataSource = this.clubIDName;
            // 
            // clubIDName
            // 
            this.clubIDName.DataSetName = "ClubIDName";
            this.clubIDName.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clubTableAdapter
            // 
            this.clubTableAdapter.ClearBeforeFill = true;
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logOutBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.Location = new System.Drawing.Point(400, 364);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(87, 25);
            this.logOutBtn.TabIndex = 59;
            this.logOutBtn.Text = "Back";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // AddYouthPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(498, 400);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.IDtext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.minutesplayedtext);
            this.Controls.Add(this.gamesplayedtext);
            this.Controls.Add(this.ratingtext);
            this.Controls.Add(this.birthplacetext);
            this.Controls.Add(this.statustext);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fnametext);
            this.Controls.Add(this.middlenametext);
            this.Controls.Add(this.lastnametext);
            this.Controls.Add(this.nationalitytext);
            this.Controls.Add(this.heighttext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddYouthPlayer";
            this.Text = "AddYouthPlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddYouthPlayer_FormClosed);
            this.Load += new System.EventHandler(this.AddYouthPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubIDName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox IDtext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox minutesplayedtext;
        private System.Windows.Forms.TextBox gamesplayedtext;
        private System.Windows.Forms.TextBox ratingtext;
        private System.Windows.Forms.TextBox birthplacetext;
        private System.Windows.Forms.TextBox statustext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fnametext;
        private System.Windows.Forms.TextBox middlenametext;
        private System.Windows.Forms.TextBox lastnametext;
        private System.Windows.Forms.TextBox nationalitytext;
        private System.Windows.Forms.TextBox heighttext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private ClubIDName clubIDName;
        private System.Windows.Forms.BindingSource clubBindingSource;
        private ClubIDNameTableAdapters.ClubTableAdapter clubTableAdapter;
        private System.Windows.Forms.Button logOutBtn;
    }
}