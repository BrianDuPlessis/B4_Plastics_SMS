
namespace B4_Plastics_SMS
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.gbxStockDetails = new System.Windows.Forms.GroupBox();
            this.dgvStockDetails = new System.Windows.Forms.DataGridView();
            this.gbxRemoveDelete = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.cbxSColour = new System.Windows.Forms.ComboBox();
            this.cbxPipeID = new System.Windows.Forms.ComboBox();
            this.txtSPrice = new System.Windows.Forms.TextBox();
            this.txtSQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxInsert = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtIDiameter = new System.Windows.Forms.TextBox();
            this.txtILength = new System.Windows.Forms.TextBox();
            this.txtIPipeID = new System.Windows.Forms.TextBox();
            this.cbxIColour = new System.Windows.Forms.ComboBox();
            this.txtIPrice = new System.Windows.Forms.TextBox();
            this.txtIPipeQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbxStockDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockDetails)).BeginInit();
            this.gbxRemoveDelete.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.gbxInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxStockDetails
            // 
            this.gbxStockDetails.BackColor = System.Drawing.Color.DarkCyan;
            this.gbxStockDetails.Controls.Add(this.dgvStockDetails);
            this.gbxStockDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxStockDetails.ForeColor = System.Drawing.Color.Cyan;
            this.gbxStockDetails.Location = new System.Drawing.Point(30, 402);
            this.gbxStockDetails.Name = "gbxStockDetails";
            this.gbxStockDetails.Size = new System.Drawing.Size(1327, 372);
            this.gbxStockDetails.TabIndex = 0;
            this.gbxStockDetails.TabStop = false;
            this.gbxStockDetails.Text = "Stock details";
            // 
            // dgvStockDetails
            // 
            this.dgvStockDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockDetails.Location = new System.Drawing.Point(17, 29);
            this.dgvStockDetails.Name = "dgvStockDetails";
            this.dgvStockDetails.RowHeadersWidth = 51;
            this.dgvStockDetails.RowTemplate.Height = 24;
            this.dgvStockDetails.Size = new System.Drawing.Size(1294, 323);
            this.dgvStockDetails.TabIndex = 0;
            // 
            // gbxRemoveDelete
            // 
            this.gbxRemoveDelete.BackColor = System.Drawing.Color.CadetBlue;
            this.gbxRemoveDelete.Controls.Add(this.btnDelete);
            this.gbxRemoveDelete.Controls.Add(this.comboBox1);
            this.gbxRemoveDelete.Controls.Add(this.label11);
            this.gbxRemoveDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRemoveDelete.ForeColor = System.Drawing.Color.Cyan;
            this.gbxRemoveDelete.Location = new System.Drawing.Point(1007, 33);
            this.gbxRemoveDelete.Name = "gbxRemoveDelete";
            this.gbxRemoveDelete.Size = new System.Drawing.Size(350, 340);
            this.gbxRemoveDelete.TabIndex = 3;
            this.gbxRemoveDelete.TabStop = false;
            this.gbxRemoveDelete.Text = "Delete/ Remove";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightGray;
            this.btnDelete.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.Location = new System.Drawing.Point(38, 237);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(267, 66);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "&Delete/ Remove";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Pipe ID:";
            // 
            // gbxSearch
            // 
            this.gbxSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.gbxSearch.Controls.Add(this.cbxSColour);
            this.gbxSearch.Controls.Add(this.cbxPipeID);
            this.gbxSearch.Controls.Add(this.txtSPrice);
            this.gbxSearch.Controls.Add(this.txtSQuantity);
            this.gbxSearch.Controls.Add(this.label4);
            this.gbxSearch.Controls.Add(this.label3);
            this.gbxSearch.Controls.Add(this.label2);
            this.gbxSearch.Controls.Add(this.label1);
            this.gbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSearch.ForeColor = System.Drawing.Color.Cyan;
            this.gbxSearch.Location = new System.Drawing.Point(30, 33);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(350, 340);
            this.gbxSearch.TabIndex = 2;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // cbxSColour
            // 
            this.cbxSColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSColour.FormattingEnabled = true;
            this.cbxSColour.Location = new System.Drawing.Point(92, 206);
            this.cbxSColour.Name = "cbxSColour";
            this.cbxSColour.Size = new System.Drawing.Size(191, 28);
            this.cbxSColour.TabIndex = 9;
            // 
            // cbxPipeID
            // 
            this.cbxPipeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPipeID.FormattingEnabled = true;
            this.cbxPipeID.Location = new System.Drawing.Point(92, 65);
            this.cbxPipeID.Name = "cbxPipeID";
            this.cbxPipeID.Size = new System.Drawing.Size(191, 28);
            this.cbxPipeID.TabIndex = 8;
            // 
            // txtSPrice
            // 
            this.txtSPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSPrice.Location = new System.Drawing.Point(154, 277);
            this.txtSPrice.Name = "txtSPrice";
            this.txtSPrice.Size = new System.Drawing.Size(129, 26);
            this.txtSPrice.TabIndex = 7;
            this.txtSPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSQuantity
            // 
            this.txtSQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQuantity.Location = new System.Drawing.Point(154, 143);
            this.txtSQuantity.Name = "txtSQuantity";
            this.txtSQuantity.Size = new System.Drawing.Size(129, 26);
            this.txtSQuantity.TabIndex = 5;
            this.txtSQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Colour:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pipe quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pipe ID:";
            // 
            // gbxInsert
            // 
            this.gbxInsert.BackColor = System.Drawing.Color.SteelBlue;
            this.gbxInsert.Controls.Add(this.btnInsert);
            this.gbxInsert.Controls.Add(this.txtIDiameter);
            this.gbxInsert.Controls.Add(this.txtILength);
            this.gbxInsert.Controls.Add(this.txtIPipeID);
            this.gbxInsert.Controls.Add(this.cbxIColour);
            this.gbxInsert.Controls.Add(this.txtIPrice);
            this.gbxInsert.Controls.Add(this.txtIPipeQuantity);
            this.gbxInsert.Controls.Add(this.label9);
            this.gbxInsert.Controls.Add(this.label10);
            this.gbxInsert.Controls.Add(this.label5);
            this.gbxInsert.Controls.Add(this.label6);
            this.gbxInsert.Controls.Add(this.label7);
            this.gbxInsert.Controls.Add(this.label8);
            this.gbxInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInsert.ForeColor = System.Drawing.Color.Cyan;
            this.gbxInsert.Location = new System.Drawing.Point(422, 33);
            this.gbxInsert.Name = "gbxInsert";
            this.gbxInsert.Size = new System.Drawing.Size(550, 340);
            this.gbxInsert.TabIndex = 4;
            this.gbxInsert.TabStop = false;
            this.gbxInsert.Text = "Insert";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.LightGray;
            this.btnInsert.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnInsert.Location = new System.Drawing.Point(322, 237);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(188, 66);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "&Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // txtIDiameter
            // 
            this.txtIDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDiameter.Location = new System.Drawing.Point(381, 143);
            this.txtIDiameter.Name = "txtIDiameter";
            this.txtIDiameter.Size = new System.Drawing.Size(129, 26);
            this.txtIDiameter.TabIndex = 15;
            this.txtIDiameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtILength
            // 
            this.txtILength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtILength.Location = new System.Drawing.Point(381, 65);
            this.txtILength.Name = "txtILength";
            this.txtILength.Size = new System.Drawing.Size(129, 26);
            this.txtILength.TabIndex = 14;
            this.txtILength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIPipeID
            // 
            this.txtIPipeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPipeID.Location = new System.Drawing.Point(83, 65);
            this.txtIPipeID.Name = "txtIPipeID";
            this.txtIPipeID.Size = new System.Drawing.Size(191, 26);
            this.txtIPipeID.TabIndex = 13;
            // 
            // cbxIColour
            // 
            this.cbxIColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIColour.FormattingEnabled = true;
            this.cbxIColour.Location = new System.Drawing.Point(83, 206);
            this.cbxIColour.Name = "cbxIColour";
            this.cbxIColour.Size = new System.Drawing.Size(191, 28);
            this.cbxIColour.TabIndex = 12;
            // 
            // txtIPrice
            // 
            this.txtIPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPrice.Location = new System.Drawing.Point(145, 277);
            this.txtIPrice.Name = "txtIPrice";
            this.txtIPrice.Size = new System.Drawing.Size(129, 26);
            this.txtIPrice.TabIndex = 11;
            this.txtIPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIPipeQuantity
            // 
            this.txtIPipeQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPipeQuantity.Location = new System.Drawing.Point(145, 143);
            this.txtIPipeQuantity.Name = "txtIPipeQuantity";
            this.txtIPipeQuantity.Size = new System.Drawing.Size(129, 26);
            this.txtIPipeQuantity.TabIndex = 10;
            this.txtIPipeQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(294, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Diameter:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(294, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Length:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Colour:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Pipe quantity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Pipe ID:";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 803);
            this.Controls.Add(this.gbxInsert);
            this.Controls.Add(this.gbxRemoveDelete);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxStockDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stock";
            this.Text = "B4 Plastics - Stock";
            this.gbxStockDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockDetails)).EndInit();
            this.gbxRemoveDelete.ResumeLayout(false);
            this.gbxRemoveDelete.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxInsert.ResumeLayout(false);
            this.gbxInsert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStockDetails;
        private System.Windows.Forms.GroupBox gbxRemoveDelete;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.GroupBox gbxInsert;
        private System.Windows.Forms.DataGridView dgvStockDetails;
        private System.Windows.Forms.ComboBox cbxPipeID;
        private System.Windows.Forms.TextBox txtSPrice;
        private System.Windows.Forms.TextBox txtSQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSColour;
        private System.Windows.Forms.TextBox txtIDiameter;
        private System.Windows.Forms.TextBox txtILength;
        private System.Windows.Forms.TextBox txtIPipeID;
        private System.Windows.Forms.ComboBox cbxIColour;
        private System.Windows.Forms.TextBox txtIPrice;
        private System.Windows.Forms.TextBox txtIPipeQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnInsert;
    }
}