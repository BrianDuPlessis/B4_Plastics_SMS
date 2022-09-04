
namespace B4_Plastics_SMS
{
    partial class frmReports
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
            this.gbxReports = new System.Windows.Forms.GroupBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rtxReportPreview = new System.Windows.Forms.RichTextBox();
            this.gbxReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxReports
            // 
            this.gbxReports.BackColor = System.Drawing.Color.RoyalBlue;
            this.gbxReports.Controls.Add(this.btnRequest);
            this.gbxReports.Controls.Add(this.btnExport);
            this.gbxReports.Controls.Add(this.btnPrint);
            this.gbxReports.Controls.Add(this.rtxReportPreview);
            this.gbxReports.Location = new System.Drawing.Point(35, 28);
            this.gbxReports.Name = "gbxReports";
            this.gbxReports.Size = new System.Drawing.Size(1411, 699);
            this.gbxReports.TabIndex = 0;
            this.gbxReports.TabStop = false;
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.ForeColor = System.Drawing.Color.White;
            this.btnRequest.Location = new System.Drawing.Point(402, 239);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(600, 50);
            this.btnRequest.TabIndex = 3;
            this.btnRequest.Text = "&Request report";
            this.btnRequest.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1275, 639);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(115, 47);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1137, 639);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(115, 47);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // rtxReportPreview
            // 
            this.rtxReportPreview.Location = new System.Drawing.Point(25, 306);
            this.rtxReportPreview.Name = "rtxReportPreview";
            this.rtxReportPreview.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxReportPreview.Size = new System.Drawing.Size(1365, 321);
            this.rtxReportPreview.TabIndex = 0;
            this.rtxReportPreview.Text = "";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.gbxReports);
            this.MaximizeBox = false;
            this.Name = "frmReports";
            this.Text = "B4 Plastics - Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.gbxReports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxReports;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RichTextBox rtxReportPreview;
        private System.Windows.Forms.Button btnRequest;
    }
}