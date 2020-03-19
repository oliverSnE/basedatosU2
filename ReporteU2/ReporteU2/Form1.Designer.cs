namespace ReporteU2
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
            this.wbReport = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbReport
            // 
            this.wbReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbReport.Location = new System.Drawing.Point(0, 0);
            this.wbReport.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbReport.Name = "wbReport";
            this.wbReport.Size = new System.Drawing.Size(705, 562);
            this.wbReport.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 562);
            this.Controls.Add(this.wbReport);
            this.Name = "Form1";
            this.Text = "ReporteDBU2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbReport;
    }
}

