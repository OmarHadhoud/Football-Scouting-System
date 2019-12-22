namespace Football_Scouting_System.Guestt
{
    partial class ViewStadiumsForm
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
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = "Guestt\\ViewStadiums.rpt";
            this.crystalReportViewer2.Size = new System.Drawing.Size(1056, 673);
            this.crystalReportViewer2.TabIndex = 0;
            // 
            // ViewStadiumsForm
            // 
            this.ClientSize = new System.Drawing.Size(1056, 673);
            this.Controls.Add(this.crystalReportViewer2);
            this.Name = "ViewStadiumsForm";
            this.Load += new System.EventHandler(this.ViewStadiumsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private ViewStadiums ViewStadiums1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
    }
}