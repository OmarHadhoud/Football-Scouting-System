namespace Football_Scouting_System.Club
{
	partial class Recievedoffers
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
			this.actualoffersbutton = new System.Windows.Forms.RadioButton();
			this.suggestedoffersbutton = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.suggestednonfree = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.offersGridView = new System.Windows.Forms.DataGridView();
			this.acceptbutton = new System.Windows.Forms.Button();
			this.rejectbutton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.offersGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// actualoffersbutton
			// 
			this.actualoffersbutton.AutoSize = true;
			this.actualoffersbutton.ForeColor = System.Drawing.SystemColors.Window;
			this.actualoffersbutton.Location = new System.Drawing.Point(22, 17);
			this.actualoffersbutton.Name = "actualoffersbutton";
			this.actualoffersbutton.Size = new System.Drawing.Size(104, 21);
			this.actualoffersbutton.TabIndex = 0;
			this.actualoffersbutton.TabStop = true;
			this.actualoffersbutton.Text = "Actual offers";
			this.actualoffersbutton.UseVisualStyleBackColor = true;
			this.actualoffersbutton.CheckedChanged += new System.EventHandler(this.actualoffersbutton_CheckedChanged);
			// 
			// suggestedoffersbutton
			// 
			this.suggestedoffersbutton.AutoSize = true;
			this.suggestedoffersbutton.ForeColor = System.Drawing.SystemColors.Window;
			this.suggestedoffersbutton.Location = new System.Drawing.Point(132, 17);
			this.suggestedoffersbutton.Name = "suggestedoffersbutton";
			this.suggestedoffersbutton.Size = new System.Drawing.Size(168, 21);
			this.suggestedoffersbutton.TabIndex = 1;
			this.suggestedoffersbutton.TabStop = true;
			this.suggestedoffersbutton.Text = "Suggested free players";
			this.suggestedoffersbutton.UseVisualStyleBackColor = true;
			this.suggestedoffersbutton.CheckedChanged += new System.EventHandler(this.suggestedoffersbutton_CheckedChanged);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.suggestednonfree);
			this.panel1.Controls.Add(this.suggestedoffersbutton);
			this.panel1.Controls.Add(this.actualoffersbutton);
			this.panel1.Location = new System.Drawing.Point(23, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(518, 59);
			this.panel1.TabIndex = 2;
			// 
			// suggestednonfree
			// 
			this.suggestednonfree.AutoSize = true;
			this.suggestednonfree.ForeColor = System.Drawing.SystemColors.Control;
			this.suggestednonfree.Location = new System.Drawing.Point(306, 17);
			this.suggestednonfree.Name = "suggestednonfree";
			this.suggestednonfree.Size = new System.Drawing.Size(197, 21);
			this.suggestednonfree.TabIndex = 2;
			this.suggestednonfree.TabStop = true;
			this.suggestednonfree.Text = "Suggested non-free players";
			this.suggestednonfree.UseVisualStyleBackColor = true;
			this.suggestednonfree.CheckedChanged += new System.EventHandler(this.suggestednonfree_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(601, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(149, 59);
			this.button1.TabIndex = 2;
			this.button1.Text = "View all";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// offersGridView
			// 
			this.offersGridView.AllowUserToAddRows = false;
			this.offersGridView.AllowUserToDeleteRows = false;
			this.offersGridView.AllowUserToResizeColumns = false;
			this.offersGridView.AllowUserToResizeRows = false;
			this.offersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.offersGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.offersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.offersGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.offersGridView.Location = new System.Drawing.Point(23, 89);
			this.offersGridView.Name = "offersGridView";
			this.offersGridView.RowTemplate.Height = 26;
			this.offersGridView.Size = new System.Drawing.Size(727, 278);
			this.offersGridView.TabIndex = 3;
			// 
			// acceptbutton
			// 
			this.acceptbutton.ForeColor = System.Drawing.Color.Green;
			this.acceptbutton.Location = new System.Drawing.Point(23, 373);
			this.acceptbutton.Name = "acceptbutton";
			this.acceptbutton.Size = new System.Drawing.Size(149, 59);
			this.acceptbutton.TabIndex = 4;
			this.acceptbutton.Text = "Accept";
			this.acceptbutton.UseVisualStyleBackColor = true;
			this.acceptbutton.Click += new System.EventHandler(this.acceptbutton_Click);
			// 
			// rejectbutton
			// 
			this.rejectbutton.ForeColor = System.Drawing.Color.Red;
			this.rejectbutton.Location = new System.Drawing.Point(392, 373);
			this.rejectbutton.Name = "rejectbutton";
			this.rejectbutton.Size = new System.Drawing.Size(149, 59);
			this.rejectbutton.TabIndex = 5;
			this.rejectbutton.Text = "Reject";
			this.rejectbutton.UseVisualStyleBackColor = true;
			this.rejectbutton.Click += new System.EventHandler(this.rejectbutton_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Blue;
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(620, 432);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(130, 49);
			this.button2.TabIndex = 6;
			this.button2.Text = "Back";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Recievedoffers
			// 
			this.AcceptButton = this.acceptbutton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkBlue;
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(762, 493);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.rejectbutton);
			this.Controls.Add(this.acceptbutton);
			this.Controls.Add(this.offersGridView);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Recievedoffers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Received offers";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ApproachedtransfersotherclubForm_FormClosed);
			this.Load += new System.EventHandler(this.Approchedtransfersotherclubs_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.offersGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RadioButton actualoffersbutton;
		private System.Windows.Forms.RadioButton suggestedoffersbutton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView offersGridView;
		private System.Windows.Forms.Button acceptbutton;
		private System.Windows.Forms.Button rejectbutton;
		private System.Windows.Forms.RadioButton suggestednonfree;
		private System.Windows.Forms.Button button2;
	}
}