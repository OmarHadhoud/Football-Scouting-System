namespace Football_Scouting_System.Scout
{
    partial class PlayerSearchForm
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
			this.PlayerSearchF = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.PlayerSearchF)).BeginInit();
			this.SuspendLayout();
			// 
			// PlayerSearchF
			// 
			this.PlayerSearchF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PlayerSearchF.Location = new System.Drawing.Point(0, 41);
			this.PlayerSearchF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.PlayerSearchF.Name = "PlayerSearchF";
			this.PlayerSearchF.Size = new System.Drawing.Size(684, 351);
			this.PlayerSearchF.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 412);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(147, 37);
			this.button1.TabIndex = 1;
			this.button1.Text = "View stats";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(14, 457);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(147, 37);
			this.button2.TabIndex = 2;
			this.button2.Text = "Favorite";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(201, 412);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(147, 37);
			this.button3.TabIndex = 3;
			this.button3.Text = "View attributes";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(201, 457);
			this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(147, 37);
			this.button4.TabIndex = 4;
			this.button4.Text = "Suggest rating";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(528, 420);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(140, 24);
			this.comboBox1.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(470, 423);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "Sort by:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(15, 10);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(535, 24);
			this.textBox1.TabIndex = 8;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(569, 5);
			this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(87, 28);
			this.button5.TabIndex = 9;
			this.button5.Text = "Search";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// PlayerSearchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 529);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.PlayerSearchF);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "PlayerSearchForm";
			this.Text = "Player search";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayerSearchForm_FormClosed);
			this.Load += new System.EventHandler(this.PlayerSearchForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.PlayerSearchF)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PlayerSearchF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
    }
}