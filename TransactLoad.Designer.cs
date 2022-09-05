
namespace B4_Plastics_SMS
{
    partial class frmTransactLoad
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
            this.gbxTransactions = new System.Windows.Forms.GroupBox();
            this.gbxMakeEditTransact = new System.Windows.Forms.GroupBox();
            this.cbxDispatchID = new System.Windows.Forms.ComboBox();
            this.cbxEmployID = new System.Windows.Forms.ComboBox();
            this.cbxPipeID = new System.Windows.Forms.ComboBox();
            this.btnUpdateEditTransact = new System.Windows.Forms.Button();
            this.btnMakeTransact = new System.Windows.Forms.Button();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxSearchDelete = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxTransactionID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxTransactionDetails = new System.Windows.Forms.GroupBox();
            this.dgvTransactionDetails = new System.Windows.Forms.DataGridView();
            this.gbxLoadCalculator = new System.Windows.Forms.GroupBox();
            this.gbxTransactions.SuspendLayout();
            this.gbxMakeEditTransact.SuspendLayout();
            this.gbxSearchDelete.SuspendLayout();
            this.gbxTransactionDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxTransactions
            // 
            this.gbxTransactions.BackColor = System.Drawing.Color.Teal;
            this.gbxTransactions.Controls.Add(this.gbxMakeEditTransact);
            this.gbxTransactions.Controls.Add(this.gbxSearchDelete);
            this.gbxTransactions.Controls.Add(this.gbxTransactionDetails);
            this.gbxTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTransactions.ForeColor = System.Drawing.Color.Aqua;
            this.gbxTransactions.Location = new System.Drawing.Point(15, 14);
            this.gbxTransactions.Name = "gbxTransactions";
            this.gbxTransactions.Size = new System.Drawing.Size(1450, 520);
            this.gbxTransactions.TabIndex = 0;
            this.gbxTransactions.TabStop = false;
            this.gbxTransactions.Text = "Transactions";
            // 
            // gbxMakeEditTransact
            // 
            this.gbxMakeEditTransact.BackColor = System.Drawing.Color.LightSeaGreen;
            this.gbxMakeEditTransact.Controls.Add(this.cbxDispatchID);
            this.gbxMakeEditTransact.Controls.Add(this.cbxEmployID);
            this.gbxMakeEditTransact.Controls.Add(this.cbxPipeID);
            this.gbxMakeEditTransact.Controls.Add(this.btnUpdateEditTransact);
            this.gbxMakeEditTransact.Controls.Add(this.btnMakeTransact);
            this.gbxMakeEditTransact.Controls.Add(this.txtAmountPaid);
            this.gbxMakeEditTransact.Controls.Add(this.label8);
            this.gbxMakeEditTransact.Controls.Add(this.txtDate);
            this.gbxMakeEditTransact.Controls.Add(this.label7);
            this.gbxMakeEditTransact.Controls.Add(this.txtQuantity);
            this.gbxMakeEditTransact.Controls.Add(this.label6);
            this.gbxMakeEditTransact.Controls.Add(this.label5);
            this.gbxMakeEditTransact.Controls.Add(this.label4);
            this.gbxMakeEditTransact.Controls.Add(this.label3);
            this.gbxMakeEditTransact.Controls.Add(this.txtTransID);
            this.gbxMakeEditTransact.Controls.Add(this.label2);
            this.gbxMakeEditTransact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMakeEditTransact.ForeColor = System.Drawing.Color.Lime;
            this.gbxMakeEditTransact.Location = new System.Drawing.Point(494, 29);
            this.gbxMakeEditTransact.Name = "gbxMakeEditTransact";
            this.gbxMakeEditTransact.Size = new System.Drawing.Size(940, 185);
            this.gbxMakeEditTransact.TabIndex = 2;
            this.gbxMakeEditTransact.TabStop = false;
            this.gbxMakeEditTransact.Text = "Make/ Edit Transaction";
            // 
            // cbxDispatchID
            // 
            this.cbxDispatchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDispatchID.FormattingEnabled = true;
            this.cbxDispatchID.Location = new System.Drawing.Point(473, 30);
            this.cbxDispatchID.Name = "cbxDispatchID";
            this.cbxDispatchID.Size = new System.Drawing.Size(126, 28);
            this.cbxDispatchID.TabIndex = 29;
            // 
            // cbxEmployID
            // 
            this.cbxEmployID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmployID.FormattingEnabled = true;
            this.cbxEmployID.Location = new System.Drawing.Point(161, 124);
            this.cbxEmployID.Name = "cbxEmployID";
            this.cbxEmployID.Size = new System.Drawing.Size(126, 28);
            this.cbxEmployID.TabIndex = 28;
            // 
            // cbxPipeID
            // 
            this.cbxPipeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPipeID.FormattingEnabled = true;
            this.cbxPipeID.Location = new System.Drawing.Point(161, 78);
            this.cbxPipeID.Name = "cbxPipeID";
            this.cbxPipeID.Size = new System.Drawing.Size(126, 28);
            this.cbxPipeID.TabIndex = 27;
            // 
            // btnUpdateEditTransact
            // 
            this.btnUpdateEditTransact.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpdateEditTransact.Location = new System.Drawing.Point(628, 128);
            this.btnUpdateEditTransact.Name = "btnUpdateEditTransact";
            this.btnUpdateEditTransact.Size = new System.Drawing.Size(277, 40);
            this.btnUpdateEditTransact.TabIndex = 26;
            this.btnUpdateEditTransact.Text = "&Update/ Edit transaction";
            this.btnUpdateEditTransact.UseVisualStyleBackColor = false;
            // 
            // btnMakeTransact
            // 
            this.btnMakeTransact.BackColor = System.Drawing.Color.DarkGray;
            this.btnMakeTransact.Location = new System.Drawing.Point(628, 78);
            this.btnMakeTransact.Name = "btnMakeTransact";
            this.btnMakeTransact.Size = new System.Drawing.Size(277, 40);
            this.btnMakeTransact.TabIndex = 25;
            this.btnMakeTransact.Text = "&Make transaction";
            this.btnMakeTransact.UseVisualStyleBackColor = false;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaid.Location = new System.Drawing.Point(779, 30);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(126, 26);
            this.txtAmountPaid.TabIndex = 24;
            this.txtAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(624, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Amount paid:";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(473, 124);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(126, 26);
            this.txtDate.TabIndex = 22;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(318, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Date:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(473, 78);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(126, 26);
            this.txtQuantity.TabIndex = 20;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(318, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Dispatch ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Pipe ID:";
            // 
            // txtTransID
            // 
            this.txtTransID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransID.Location = new System.Drawing.Point(161, 30);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(126, 26);
            this.txtTransID.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Transaction ID:";
            // 
            // gbxSearchDelete
            // 
            this.gbxSearchDelete.BackColor = System.Drawing.Color.CadetBlue;
            this.gbxSearchDelete.Controls.Add(this.btnDelete);
            this.gbxSearchDelete.Controls.Add(this.btnSearch);
            this.gbxSearchDelete.Controls.Add(this.cbxTransactionID);
            this.gbxSearchDelete.Controls.Add(this.label1);
            this.gbxSearchDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSearchDelete.ForeColor = System.Drawing.Color.Aqua;
            this.gbxSearchDelete.Location = new System.Drawing.Point(18, 29);
            this.gbxSearchDelete.Name = "gbxSearchDelete";
            this.gbxSearchDelete.Size = new System.Drawing.Size(452, 185);
            this.gbxSearchDelete.TabIndex = 1;
            this.gbxSearchDelete.TabStop = false;
            this.gbxSearchDelete.Text = "Search/ Delete";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkGray;
            this.btnDelete.Location = new System.Drawing.Point(238, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(195, 61);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.Location = new System.Drawing.Point(16, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(195, 61);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // cbxTransactionID
            // 
            this.cbxTransactionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTransactionID.FormattingEnabled = true;
            this.cbxTransactionID.Location = new System.Drawing.Point(167, 61);
            this.cbxTransactionID.Name = "cbxTransactionID";
            this.cbxTransactionID.Size = new System.Drawing.Size(215, 28);
            this.cbxTransactionID.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Transaction ID:";
            // 
            // gbxTransactionDetails
            // 
            this.gbxTransactionDetails.BackColor = System.Drawing.Color.CadetBlue;
            this.gbxTransactionDetails.Controls.Add(this.dgvTransactionDetails);
            this.gbxTransactionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTransactionDetails.ForeColor = System.Drawing.Color.Aqua;
            this.gbxTransactionDetails.Location = new System.Drawing.Point(18, 232);
            this.gbxTransactionDetails.Name = "gbxTransactionDetails";
            this.gbxTransactionDetails.Size = new System.Drawing.Size(1416, 271);
            this.gbxTransactionDetails.TabIndex = 0;
            this.gbxTransactionDetails.TabStop = false;
            this.gbxTransactionDetails.Text = "Transaction Details";
            // 
            // dgvTransactionDetails
            // 
            this.dgvTransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionDetails.Location = new System.Drawing.Point(16, 29);
            this.dgvTransactionDetails.Name = "dgvTransactionDetails";
            this.dgvTransactionDetails.RowHeadersWidth = 51;
            this.dgvTransactionDetails.RowTemplate.Height = 24;
            this.dgvTransactionDetails.Size = new System.Drawing.Size(1387, 229);
            this.dgvTransactionDetails.TabIndex = 0;
            // 
            // gbxLoadCalculator
            // 
            this.gbxLoadCalculator.BackColor = System.Drawing.Color.CadetBlue;
            this.gbxLoadCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLoadCalculator.ForeColor = System.Drawing.Color.Aqua;
            this.gbxLoadCalculator.Location = new System.Drawing.Point(15, 555);
            this.gbxLoadCalculator.Name = "gbxLoadCalculator";
            this.gbxLoadCalculator.Size = new System.Drawing.Size(1450, 380);
            this.gbxLoadCalculator.TabIndex = 1;
            this.gbxLoadCalculator.TabStop = false;
            this.gbxLoadCalculator.Text = "Load Calculator";
            // 
            // frmTransactLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 949);
            this.Controls.Add(this.gbxLoadCalculator);
            this.Controls.Add(this.gbxTransactions);
            this.MaximizeBox = false;
            this.Name = "frmTransactLoad";
            this.Text = "B4 Plastics - Transactions & Load Calculation";
            this.Load += new System.EventHandler(this.frmTransactLoad_Load);
            this.gbxTransactions.ResumeLayout(false);
            this.gbxMakeEditTransact.ResumeLayout(false);
            this.gbxMakeEditTransact.PerformLayout();
            this.gbxSearchDelete.ResumeLayout(false);
            this.gbxSearchDelete.PerformLayout();
            this.gbxTransactionDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTransactions;
        private System.Windows.Forms.GroupBox gbxLoadCalculator;
        private System.Windows.Forms.GroupBox gbxMakeEditTransact;
        private System.Windows.Forms.GroupBox gbxSearchDelete;
        private System.Windows.Forms.GroupBox gbxTransactionDetails;
        private System.Windows.Forms.DataGridView dgvTransactionDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxTransactionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTransID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateEditTransact;
        private System.Windows.Forms.Button btnMakeTransact;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxDispatchID;
        private System.Windows.Forms.ComboBox cbxEmployID;
        private System.Windows.Forms.ComboBox cbxPipeID;
    }
}