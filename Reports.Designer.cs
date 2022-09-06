
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.gbxReports = new System.Windows.Forms.GroupBox();
            this.gbxSortBy = new System.Windows.Forms.GroupBox();
            this.rbnPipeDiameter = new System.Windows.Forms.RadioButton();
            this.rbnPipeLength = new System.Windows.Forms.RadioButton();
            this.gbxOrderBy = new System.Windows.Forms.GroupBox();
            this.rbnDESC = new System.Windows.Forms.RadioButton();
            this.rbnASC = new System.Windows.Forms.RadioButton();
            this.rbnPipePrice = new System.Windows.Forms.RadioButton();
            this.rbnPipeQuantity = new System.Windows.Forms.RadioButton();
            this.rbnPipeColour = new System.Windows.Forms.RadioButton();
            this.gbxFilterBy = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLengthHigh = new System.Windows.Forms.TextBox();
            this.txtLengthLow = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantityHigh = new System.Windows.Forms.TextBox();
            this.txtQuantityLow = new System.Windows.Forms.TextBox();
            this.cbxColour = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPriceHigh = new System.Windows.Forms.TextBox();
            this.txtPriceLow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rtxReportPreview = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxReports.SuspendLayout();
            this.gbxSortBy.SuspendLayout();
            this.gbxOrderBy.SuspendLayout();
            this.gbxFilterBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxReports
            // 
            this.gbxReports.BackColor = System.Drawing.Color.RoyalBlue;
            this.gbxReports.Controls.Add(this.gbxSortBy);
            this.gbxReports.Controls.Add(this.gbxFilterBy);
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
            // gbxSortBy
            // 
            this.gbxSortBy.BackColor = System.Drawing.Color.SteelBlue;
            this.gbxSortBy.Controls.Add(this.rbnPipeDiameter);
            this.gbxSortBy.Controls.Add(this.rbnPipeLength);
            this.gbxSortBy.Controls.Add(this.gbxOrderBy);
            this.gbxSortBy.Controls.Add(this.rbnPipePrice);
            this.gbxSortBy.Controls.Add(this.rbnPipeQuantity);
            this.gbxSortBy.Controls.Add(this.rbnPipeColour);
            this.gbxSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSortBy.ForeColor = System.Drawing.Color.Cyan;
            this.gbxSortBy.Location = new System.Drawing.Point(723, 30);
            this.gbxSortBy.Name = "gbxSortBy";
            this.gbxSortBy.Size = new System.Drawing.Size(650, 180);
            this.gbxSortBy.TabIndex = 5;
            this.gbxSortBy.TabStop = false;
            this.gbxSortBy.Text = "Sort";
            // 
            // rbnPipeDiameter
            // 
            this.rbnPipeDiameter.AutoSize = true;
            this.rbnPipeDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnPipeDiameter.Location = new System.Drawing.Point(197, 85);
            this.rbnPipeDiameter.Name = "rbnPipeDiameter";
            this.rbnPipeDiameter.Size = new System.Drawing.Size(146, 24);
            this.rbnPipeDiameter.TabIndex = 8;
            this.rbnPipeDiameter.TabStop = true;
            this.rbnPipeDiameter.Text = "Pipe diameter";
            this.rbnPipeDiameter.UseVisualStyleBackColor = true;
            // 
            // rbnPipeLength
            // 
            this.rbnPipeLength.AutoSize = true;
            this.rbnPipeLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnPipeLength.Location = new System.Drawing.Point(197, 50);
            this.rbnPipeLength.Name = "rbnPipeLength";
            this.rbnPipeLength.Size = new System.Drawing.Size(124, 24);
            this.rbnPipeLength.TabIndex = 7;
            this.rbnPipeLength.TabStop = true;
            this.rbnPipeLength.Text = "Pipe length";
            this.rbnPipeLength.UseVisualStyleBackColor = true;
            // 
            // gbxOrderBy
            // 
            this.gbxOrderBy.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gbxOrderBy.Controls.Add(this.rbnDESC);
            this.gbxOrderBy.Controls.Add(this.rbnASC);
            this.gbxOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOrderBy.ForeColor = System.Drawing.Color.Cyan;
            this.gbxOrderBy.Location = new System.Drawing.Point(388, 39);
            this.gbxOrderBy.Name = "gbxOrderBy";
            this.gbxOrderBy.Size = new System.Drawing.Size(235, 114);
            this.gbxOrderBy.TabIndex = 6;
            this.gbxOrderBy.TabStop = false;
            this.gbxOrderBy.Text = "Order by";
            // 
            // rbnDESC
            // 
            this.rbnDESC.AutoSize = true;
            this.rbnDESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnDESC.Location = new System.Drawing.Point(26, 70);
            this.rbnDESC.Name = "rbnDESC";
            this.rbnDESC.Size = new System.Drawing.Size(160, 24);
            this.rbnDESC.TabIndex = 3;
            this.rbnDESC.TabStop = true;
            this.rbnDESC.Text = "DESC (Z --> A)";
            this.rbnDESC.UseVisualStyleBackColor = true;
            // 
            // rbnASC
            // 
            this.rbnASC.AutoSize = true;
            this.rbnASC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnASC.Location = new System.Drawing.Point(26, 35);
            this.rbnASC.Name = "rbnASC";
            this.rbnASC.Size = new System.Drawing.Size(146, 24);
            this.rbnASC.TabIndex = 2;
            this.rbnASC.TabStop = true;
            this.rbnASC.Text = "ASC (A --> Z)";
            this.rbnASC.UseVisualStyleBackColor = true;
            // 
            // rbnPipePrice
            // 
            this.rbnPipePrice.AutoSize = true;
            this.rbnPipePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnPipePrice.Location = new System.Drawing.Point(24, 119);
            this.rbnPipePrice.Name = "rbnPipePrice";
            this.rbnPipePrice.Size = new System.Drawing.Size(115, 24);
            this.rbnPipePrice.TabIndex = 2;
            this.rbnPipePrice.TabStop = true;
            this.rbnPipePrice.Text = "Pipe price";
            this.rbnPipePrice.UseVisualStyleBackColor = true;
            // 
            // rbnPipeQuantity
            // 
            this.rbnPipeQuantity.AutoSize = true;
            this.rbnPipeQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnPipeQuantity.Location = new System.Drawing.Point(24, 85);
            this.rbnPipeQuantity.Name = "rbnPipeQuantity";
            this.rbnPipeQuantity.Size = new System.Drawing.Size(139, 24);
            this.rbnPipeQuantity.TabIndex = 1;
            this.rbnPipeQuantity.TabStop = true;
            this.rbnPipeQuantity.Text = "Pipe quantity";
            this.rbnPipeQuantity.UseVisualStyleBackColor = true;
            // 
            // rbnPipeColour
            // 
            this.rbnPipeColour.AutoSize = true;
            this.rbnPipeColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnPipeColour.Location = new System.Drawing.Point(24, 50);
            this.rbnPipeColour.Name = "rbnPipeColour";
            this.rbnPipeColour.Size = new System.Drawing.Size(125, 24);
            this.rbnPipeColour.TabIndex = 0;
            this.rbnPipeColour.TabStop = true;
            this.rbnPipeColour.Text = "Pipe colour";
            this.rbnPipeColour.UseVisualStyleBackColor = true;
            // 
            // gbxFilterBy
            // 
            this.gbxFilterBy.BackColor = System.Drawing.Color.SteelBlue;
            this.gbxFilterBy.Controls.Add(this.label7);
            this.gbxFilterBy.Controls.Add(this.txtLengthHigh);
            this.gbxFilterBy.Controls.Add(this.txtLengthLow);
            this.gbxFilterBy.Controls.Add(this.label6);
            this.gbxFilterBy.Controls.Add(this.txtQuantityHigh);
            this.gbxFilterBy.Controls.Add(this.txtQuantityLow);
            this.gbxFilterBy.Controls.Add(this.cbxColour);
            this.gbxFilterBy.Controls.Add(this.label5);
            this.gbxFilterBy.Controls.Add(this.txtPriceHigh);
            this.gbxFilterBy.Controls.Add(this.txtPriceLow);
            this.gbxFilterBy.Controls.Add(this.label4);
            this.gbxFilterBy.Controls.Add(this.label3);
            this.gbxFilterBy.Controls.Add(this.label2);
            this.gbxFilterBy.Controls.Add(this.label1);
            this.gbxFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFilterBy.ForeColor = System.Drawing.Color.Cyan;
            this.gbxFilterBy.Location = new System.Drawing.Point(39, 30);
            this.gbxFilterBy.Name = "gbxFilterBy";
            this.gbxFilterBy.Size = new System.Drawing.Size(650, 180);
            this.gbxFilterBy.TabIndex = 4;
            this.gbxFilterBy.TabStop = false;
            this.gbxFilterBy.Text = "Filter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(450, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "to";
            // 
            // txtLengthHigh
            // 
            this.txtLengthHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLengthHigh.Location = new System.Drawing.Point(492, 132);
            this.txtLengthHigh.Name = "txtLengthHigh";
            this.txtLengthHigh.Size = new System.Drawing.Size(104, 26);
            this.txtLengthHigh.TabIndex = 12;
            this.txtLengthHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLengthLow
            // 
            this.txtLengthLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLengthLow.Location = new System.Drawing.Point(334, 132);
            this.txtLengthLow.Name = "txtLengthLow";
            this.txtLengthLow.Size = new System.Drawing.Size(104, 26);
            this.txtLengthLow.TabIndex = 11;
            this.txtLengthLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "to";
            // 
            // txtQuantityHigh
            // 
            this.txtQuantityHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityHigh.Location = new System.Drawing.Point(184, 132);
            this.txtQuantityHigh.Name = "txtQuantityHigh";
            this.txtQuantityHigh.Size = new System.Drawing.Size(104, 26);
            this.txtQuantityHigh.TabIndex = 9;
            this.txtQuantityHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQuantityLow
            // 
            this.txtQuantityLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityLow.Location = new System.Drawing.Point(26, 132);
            this.txtQuantityLow.Name = "txtQuantityLow";
            this.txtQuantityLow.Size = new System.Drawing.Size(104, 26);
            this.txtQuantityLow.TabIndex = 8;
            this.txtQuantityLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxColour
            // 
            this.cbxColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxColour.FormattingEnabled = true;
            this.cbxColour.Location = new System.Drawing.Point(402, 63);
            this.cbxColour.Name = "cbxColour";
            this.cbxColour.Size = new System.Drawing.Size(214, 28);
            this.cbxColour.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "to";
            // 
            // txtPriceHigh
            // 
            this.txtPriceHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceHigh.Location = new System.Drawing.Point(184, 63);
            this.txtPriceHigh.Name = "txtPriceHigh";
            this.txtPriceHigh.Size = new System.Drawing.Size(104, 26);
            this.txtPriceHigh.TabIndex = 5;
            this.txtPriceHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPriceLow
            // 
            this.txtPriceLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceLow.Location = new System.Drawing.Point(26, 63);
            this.txtPriceLow.Name = "txtPriceLow";
            this.txtPriceLow.Size = new System.Drawing.Size(104, 26);
            this.txtPriceLow.TabIndex = 4;
            this.txtPriceLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Colour:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price:";
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
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1481, 765);
            this.Controls.Add(this.gbxReports);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Reports";
            this.Text = "B4 Plastics - Reports";
            this.gbxReports.ResumeLayout(false);
            this.gbxSortBy.ResumeLayout(false);
            this.gbxSortBy.PerformLayout();
            this.gbxOrderBy.ResumeLayout(false);
            this.gbxOrderBy.PerformLayout();
            this.gbxFilterBy.ResumeLayout(false);
            this.gbxFilterBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxReports;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RichTextBox rtxReportPreview;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.GroupBox gbxSortBy;
        private System.Windows.Forms.RadioButton rbnPipePrice;
        private System.Windows.Forms.RadioButton rbnPipeQuantity;
        private System.Windows.Forms.RadioButton rbnPipeColour;
        private System.Windows.Forms.GroupBox gbxFilterBy;
        private System.Windows.Forms.GroupBox gbxOrderBy;
        private System.Windows.Forms.RadioButton rbnDESC;
        private System.Windows.Forms.RadioButton rbnASC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLengthHigh;
        private System.Windows.Forms.TextBox txtLengthLow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantityHigh;
        private System.Windows.Forms.TextBox txtQuantityLow;
        private System.Windows.Forms.ComboBox cbxColour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPriceHigh;
        private System.Windows.Forms.TextBox txtPriceLow;
        private System.Windows.Forms.RadioButton rbnPipeDiameter;
        private System.Windows.Forms.RadioButton rbnPipeLength;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}