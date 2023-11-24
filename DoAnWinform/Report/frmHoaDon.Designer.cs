namespace DoAnWinform.Report
{
    partial class frmHoaDon
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
            this.rptHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptHoaDon
            // 
            this.rptHoaDon.ActiveViewIndex = -1;
            this.rptHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptHoaDon.Location = new System.Drawing.Point(0, 0);
            this.rptHoaDon.Name = "rptHoaDon";
            this.rptHoaDon.Size = new System.Drawing.Size(800, 450);
            this.rptHoaDon.TabIndex = 0;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptHoaDon);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rptHoaDon;
    }
}