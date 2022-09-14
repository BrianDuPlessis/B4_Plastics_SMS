
namespace B4_Plastics_SMS
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.gbxReports = new System.Windows.Forms.GroupBox();
            this.dgvReportView = new System.Windows.Forms.DataGridView();
            this.gbxSortBy = new System.Windows.Forms.GroupBox();
            this.rbnPipeDiameter = new System.Windows.Forms.RadioButton();
            this.rbnPipeLength = new System.Windows.Forms.RadioButton();
            this.gbxOrderBy = new System.Windows.Forms.GroupBox();
            this.rbnDESC = new System.Windows.Forms.RadioButton();
            this.rbnASC = new System.Windows.Forms.RadioButton();
            this.rbnPipeQuantity = new System.Windows.Forms.RadioButton();
            this.rbnPipeID = new System.Windows.Forms.RadioButton();
            this.rbnPipeColour = new System.Windows.Forms.RadioButton();
            this.gbxFilterBy = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLengthHigh = new System.Windows.Forms.TextBox();
            this.txtLengthLow = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantityHigh = new System.Windows.Forms.TextBox();
            this.txtQuantityLow = new System.Windows.Forms.TextBox();
            this.cbxColour = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rtxReportErr = new System.Windows.Forms.RichTextBox();
            this.ppPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStockReport = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabTransactionReport = new System.Windows.Forms.TabPage();
            this.gbxReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportView)).BeginInit();
            this.gbxSortBy.SuspendLayout();
            this.gbxOrderBy.SuspendLayout();
            this.gbxFilterBy.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabStockReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxReports
            // 
            this.gbxReports.BackColor = System.Drawing.Color.White;
            this.gbxReports.Controls.Add(this.dgvReportView);
            this.gbxReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxReports.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.gbxReports.ForeColor = System.Drawing.Color.Navy;
            this.gbxReports.Location = new System.Drawing.Point(25, 350);
            this.gbxReports.Name = "gbxReports";
            this.gbxReports.Size = new System.Drawing.Size(874, 452);
            this.gbxReports.TabIndex = 0;
            this.gbxReports.TabStop = false;
            this.gbxReports.Text = "Stock Details";
            // 
            // dgvReportView
            // 
            this.dgvReportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportView.Location = new System.Drawing.Point(61, 35);
            this.dgvReportView.Name = "dgvReportView";
            this.dgvReportView.RowHeadersWidth = 51;
            this.dgvReportView.RowTemplate.Height = 24;
            this.dgvReportView.Size = new System.Drawing.Size(765, 397);
            this.dgvReportView.TabIndex = 6;
            // 
            // gbxSortBy
            // 
            this.gbxSortBy.BackColor = System.Drawing.Color.White;
            this.gbxSortBy.Controls.Add(this.rbnPipeDiameter);
            this.gbxSortBy.Controls.Add(this.rbnPipeLength);
            this.gbxSortBy.Controls.Add(this.gbxOrderBy);
            this.gbxSortBy.Controls.Add(this.rbnPipeQuantity);
            this.gbxSortBy.Controls.Add(this.rbnPipeID);
            this.gbxSortBy.Controls.Add(this.rbnPipeColour);
            this.gbxSortBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxSortBy.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.gbxSortBy.ForeColor = System.Drawing.Color.Navy;
            this.gbxSortBy.Location = new System.Drawing.Point(455, 32);
            this.gbxSortBy.Name = "gbxSortBy";
            this.gbxSortBy.Size = new System.Drawing.Size(444, 231);
            this.gbxSortBy.TabIndex = 5;
            this.gbxSortBy.TabStop = false;
            this.gbxSortBy.Text = "Sort";
            // 
            // rbnPipeDiameter
            // 
            this.rbnPipeDiameter.AutoSize = true;
            this.rbnPipeDiameter.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.rbnPipeDiameter.ForeColor = System.Drawing.Color.Black;
            this.rbnPipeDiameter.Location = new System.Drawing.Point(30, 179);
            this.rbnPipeDiameter.Name = "rbnPipeDiameter";
            this.rbnPipeDiameter.Size = new System.Drawing.Size(150, 29);
            this.rbnPipeDiameter.TabIndex = 8;
            this.rbnPipeDiameter.TabStop = true;
            this.rbnPipeDiameter.Text = "Pipe diameter";
            this.rbnPipeDiameter.UseVisualStyleBackColor = true;
            // 
            // rbnPipeLength
            // 
            this.rbnPipeLength.AutoSize = true;
            this.rbnPipeLength.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.rbnPipeLength.ForeColor = System.Drawing.Color.Black;
            this.rbnPipeLength.Location = new System.Drawing.Point(30, 144);
            this.rbnPipeLength.Name = "rbnPipeLength";
            this.rbnPipeLength.Size = new System.Drawing.Size(129, 29);
            this.rbnPipeLength.TabIndex = 7;
            this.rbnPipeLength.TabStop = true;
            this.rbnPipeLength.Text = "Pipe length";
            this.rbnPipeLength.UseVisualStyleBackColor = true;
            // 
            // gbxOrderBy
            // 
            this.gbxOrderBy.BackColor = System.Drawing.Color.White;
            this.gbxOrderBy.Controls.Add(this.rbnDESC);
            this.gbxOrderBy.Controls.Add(this.rbnASC);
            this.gbxOrderBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxOrderBy.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.gbxOrderBy.ForeColor = System.Drawing.Color.Navy;
            this.gbxOrderBy.Location = new System.Drawing.Point(213, 56);
            this.gbxOrderBy.Name = "gbxOrderBy";
            this.gbxOrderBy.Size = new System.Drawing.Size(204, 117);
            this.gbxOrderBy.TabIndex = 6;
            this.gbxOrderBy.TabStop = false;
            this.gbxOrderBy.Text = "Order by";
            // 
            // rbnDESC
            // 
            this.rbnDESC.AutoSize = true;
            this.rbnDESC.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.rbnDESC.ForeColor = System.Drawing.Color.Black;
            this.rbnDESC.Location = new System.Drawing.Point(26, 70);
            this.rbnDESC.Name = "rbnDESC";
            this.rbnDESC.Size = new System.Drawing.Size(157, 29);
            this.rbnDESC.TabIndex = 3;
            this.rbnDESC.TabStop = true;
            this.rbnDESC.Text = "DESC (Z --> A)";
            this.rbnDESC.UseVisualStyleBackColor = true;
            // 
            // rbnASC
            // 
            this.rbnASC.AutoSize = true;
            this.rbnASC.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.rbnASC.ForeColor = System.Drawing.Color.Black;
            this.rbnASC.Location = new System.Drawing.Point(26, 35);
            this.rbnASC.Name = "rbnASC";
            this.rbnASC.Size = new System.Drawing.Size(146, 29);
            this.rbnASC.TabIndex = 2;
            this.rbnASC.TabStop = true;
            this.rbnASC.Text = "ASC (A --> Z)";
            this.rbnASC.UseVisualStyleBackColor = true;
            // 
            // rbnPipeQuantity
            // 
            this.rbnPipeQuantity.AutoSize = true;
            this.rbnPipeQuantity.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.rbnPipeQuantity.ForeColor = System.Drawing.Color.Black;
            this.rbnPipeQuantity.Location = new System.Drawing.Point(30, 109);
            this.rbnPipeQuantity.Name = "rbnPipeQuantity";
            this.rbnPipeQuantity.Size = new System.Drawing.Size(144, 29);
            this.rbnPipeQuantity.TabIndex = 1;
            this.rbnPipeQuantity.TabStop = true;
            this.rbnPipeQuantity.Text = "Pipe quantity";
            this.rbnPipeQuantity.UseVisualStyleBackColor = true;
            // 
            // rbnPipeID
            // 
            this.rbnPipeID.AutoSize = true;
            this.rbnPipeID.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.rbnPipeID.ForeColor = System.Drawing.Color.Black;
            this.rbnPipeID.Location = new System.Drawing.Point(30, 39);
            this.rbnPipeID.Name = "rbnPipeID";
            this.rbnPipeID.Size = new System.Drawing.Size(93, 29);
            this.rbnPipeID.TabIndex = 0;
            this.rbnPipeID.TabStop = true;
            this.rbnPipeID.Text = "Pipe ID";
            this.rbnPipeID.UseVisualStyleBackColor = true;
            // 
            // rbnPipeColour
            // 
            this.rbnPipeColour.AutoSize = true;
            this.rbnPipeColour.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.rbnPipeColour.ForeColor = System.Drawing.Color.Black;
            this.rbnPipeColour.Location = new System.Drawing.Point(30, 74);
            this.rbnPipeColour.Name = "rbnPipeColour";
            this.rbnPipeColour.Size = new System.Drawing.Size(129, 29);
            this.rbnPipeColour.TabIndex = 0;
            this.rbnPipeColour.TabStop = true;
            this.rbnPipeColour.Text = "Pipe colour";
            this.rbnPipeColour.UseVisualStyleBackColor = true;
            // 
            // gbxFilterBy
            // 
            this.gbxFilterBy.BackColor = System.Drawing.Color.White;
            this.gbxFilterBy.Controls.Add(this.label7);
            this.gbxFilterBy.Controls.Add(this.txtLengthHigh);
            this.gbxFilterBy.Controls.Add(this.txtLengthLow);
            this.gbxFilterBy.Controls.Add(this.label6);
            this.gbxFilterBy.Controls.Add(this.txtQuantityHigh);
            this.gbxFilterBy.Controls.Add(this.txtQuantityLow);
            this.gbxFilterBy.Controls.Add(this.cbxColour);
            this.gbxFilterBy.Controls.Add(this.label4);
            this.gbxFilterBy.Controls.Add(this.label3);
            this.gbxFilterBy.Controls.Add(this.label2);
            this.gbxFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxFilterBy.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.gbxFilterBy.ForeColor = System.Drawing.Color.Navy;
            this.gbxFilterBy.Location = new System.Drawing.Point(25, 32);
            this.gbxFilterBy.Name = "gbxFilterBy";
            this.gbxFilterBy.Size = new System.Drawing.Size(392, 231);
            this.gbxFilterBy.TabIndex = 4;
            this.gbxFilterBy.TabStop = false;
            this.gbxFilterBy.Text = "Filter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(220, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "to";
            // 
            // txtLengthHigh
            // 
            this.txtLengthHigh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLengthHigh.Location = new System.Drawing.Point(261, 154);
            this.txtLengthHigh.Name = "txtLengthHigh";
            this.txtLengthHigh.Size = new System.Drawing.Size(81, 27);
            this.txtLengthHigh.TabIndex = 12;
            this.txtLengthHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLengthLow
            // 
            this.txtLengthLow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLengthLow.Location = new System.Drawing.Point(128, 151);
            this.txtLengthLow.Name = "txtLengthLow";
            this.txtLengthLow.Size = new System.Drawing.Size(80, 27);
            this.txtLengthLow.TabIndex = 11;
            this.txtLengthLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(220, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "to";
            // 
            // txtQuantityHigh
            // 
            this.txtQuantityHigh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantityHigh.Location = new System.Drawing.Point(261, 95);
            this.txtQuantityHigh.Name = "txtQuantityHigh";
            this.txtQuantityHigh.Size = new System.Drawing.Size(81, 27);
            this.txtQuantityHigh.TabIndex = 9;
            this.txtQuantityHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQuantityLow
            // 
            this.txtQuantityLow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantityLow.Location = new System.Drawing.Point(128, 95);
            this.txtQuantityLow.Name = "txtQuantityLow";
            this.txtQuantityLow.Size = new System.Drawing.Size(80, 27);
            this.txtQuantityLow.TabIndex = 8;
            this.txtQuantityLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxColour
            // 
            this.cbxColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxColour.FormattingEnabled = true;
            this.cbxColour.Location = new System.Drawing.Point(128, 40);
            this.cbxColour.Name = "cbxColour";
            this.cbxColour.Size = new System.Drawing.Size(214, 28);
            this.cbxColour.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Colour:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity:";
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(211)))));
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRequest.ForeColor = System.Drawing.Color.White;
            this.btnRequest.Location = new System.Drawing.Point(25, 279);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(874, 50);
            this.btnRequest.TabIndex = 3;
            this.btnRequest.Text = "&Generate report";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(211)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(743, 827);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(156, 47);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(211)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(575, 827);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(156, 47);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // rtxReportErr
            // 
            this.rtxReportErr.Location = new System.Drawing.Point(937, 32);
            this.rtxReportErr.Name = "rtxReportErr";
            this.rtxReportErr.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxReportErr.Size = new System.Drawing.Size(329, 50);
            this.rtxReportErr.TabIndex = 0;
            this.rtxReportErr.Text = "";
            this.rtxReportErr.Visible = false;
            // 
            // ppPreview
            // 
            this.ppPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.ppPreview.Document = this.printDoc;
            this.ppPreview.Enabled = true;
            this.ppPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("ppPreview.Icon")));
            this.ppPreview.Name = "ppPreview";
            this.ppPreview.Visible = false;
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStockReport);
            this.tabControl1.Controls.Add(this.tabTransactionReport);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(965, 950);
            this.tabControl1.TabIndex = 2;
            // 
            // tabStockReport
            // 
            this.tabStockReport.BackColor = System.Drawing.Color.White;
            this.tabStockReport.Controls.Add(this.btnReset);
            this.tabStockReport.Controls.Add(this.gbxReports);
            this.tabStockReport.Controls.Add(this.gbxSortBy);
            this.tabStockReport.Controls.Add(this.gbxFilterBy);
            this.tabStockReport.Controls.Add(this.rtxReportErr);
            this.tabStockReport.Controls.Add(this.btnRequest);
            this.tabStockReport.Controls.Add(this.btnPrint);
            this.tabStockReport.Controls.Add(this.btnExport);
            this.tabStockReport.Location = new System.Drawing.Point(4, 32);
            this.tabStockReport.Name = "tabStockReport";
            this.tabStockReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabStockReport.Size = new System.Drawing.Size(957, 914);
            this.tabStockReport.TabIndex = 0;
            this.tabStockReport.Text = "Stock";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(211)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(25, 827);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(165, 47);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Clear All";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tabTransactionReport
            // 
            this.tabTransactionReport.BackColor = System.Drawing.Color.White;
            this.tabTransactionReport.Location = new System.Drawing.Point(4, 32);
            this.tabTransactionReport.Name = "tabTransactionReport";
            this.tabTransactionReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransactionReport.Size = new System.Drawing.Size(957, 914);
            this.tabTransactionReport.TabIndex = 1;
            this.tabTransactionReport.Text = "Transaction";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(965, 950);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Reports";
            this.Text = "B4 Plastics - Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.gbxReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportView)).EndInit();
            this.gbxSortBy.ResumeLayout(false);
            this.gbxSortBy.PerformLayout();
            this.gbxOrderBy.ResumeLayout(false);
            this.gbxOrderBy.PerformLayout();
            this.gbxFilterBy.ResumeLayout(false);
            this.gbxFilterBy.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabStockReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxReports;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RichTextBox rtxReportErr;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.GroupBox gbxSortBy;
        private System.Windows.Forms.RadioButton rbnPipeQuantity;
        private System.Windows.Forms.RadioButton rbnPipeColour;
        private System.Windows.Forms.GroupBox gbxFilterBy;
        private System.Windows.Forms.GroupBox gbxOrderBy;
        private System.Windows.Forms.RadioButton rbnDESC;
        private System.Windows.Forms.RadioButton rbnASC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLengthHigh;
        private System.Windows.Forms.TextBox txtLengthLow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantityHigh;
        private System.Windows.Forms.TextBox txtQuantityLow;
        private System.Windows.Forms.ComboBox cbxColour;
        private System.Windows.Forms.RadioButton rbnPipeDiameter;
        private System.Windows.Forms.RadioButton rbnPipeLength;
        private System.Windows.Forms.DataGridView dgvReportView;
        private System.Windows.Forms.PrintPreviewDialog ppPreview;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStockReport;
        private System.Windows.Forms.TabPage tabTransactionReport;
        private System.Windows.Forms.RadioButton rbnPipeID;
        private System.Windows.Forms.Button btnReset;
    }
}