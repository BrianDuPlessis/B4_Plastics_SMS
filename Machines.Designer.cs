
namespace B4_Plastics_SMS
{
    partial class Machines
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
            this.gbxMachines = new System.Windows.Forms.GroupBox();
            this.gbxMachineDetails = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.gbxChangeState = new System.Windows.Forms.GroupBox();
            this.cbxMachineID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxMachines.SuspendLayout();
            this.gbxMachineDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMachines
            // 
            this.gbxMachines.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbxMachines.Controls.Add(this.gbxChangeState);
            this.gbxMachines.Controls.Add(this.gbxSearch);
            this.gbxMachines.Controls.Add(this.gbxMachineDetails);
            this.gbxMachines.Location = new System.Drawing.Point(23, 12);
            this.gbxMachines.Name = "gbxMachines";
            this.gbxMachines.Size = new System.Drawing.Size(1307, 656);
            this.gbxMachines.TabIndex = 0;
            this.gbxMachines.TabStop = false;
            // 
            // gbxMachineDetails
            // 
            this.gbxMachineDetails.BackColor = System.Drawing.Color.SteelBlue;
            this.gbxMachineDetails.Controls.Add(this.dataGridView1);
            this.gbxMachineDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMachineDetails.ForeColor = System.Drawing.Color.Cyan;
            this.gbxMachineDetails.Location = new System.Drawing.Point(22, 323);
            this.gbxMachineDetails.Name = "gbxMachineDetails";
            this.gbxMachineDetails.Size = new System.Drawing.Size(1266, 310);
            this.gbxMachineDetails.TabIndex = 0;
            this.gbxMachineDetails.TabStop = false;
            this.gbxMachineDetails.Text = "Machine Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1224, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbxSearch
            // 
            this.gbxSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.gbxSearch.Controls.Add(this.cbxMachineID);
            this.gbxSearch.Controls.Add(this.label1);
            this.gbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSearch.ForeColor = System.Drawing.Color.Cyan;
            this.gbxSearch.Location = new System.Drawing.Point(161, 21);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(465, 278);
            this.gbxSearch.TabIndex = 1;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // gbxChangeState
            // 
            this.gbxChangeState.BackColor = System.Drawing.Color.SteelBlue;
            this.gbxChangeState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxChangeState.ForeColor = System.Drawing.Color.Cyan;
            this.gbxChangeState.Location = new System.Drawing.Point(684, 21);
            this.gbxChangeState.Name = "gbxChangeState";
            this.gbxChangeState.Size = new System.Drawing.Size(476, 278);
            this.gbxChangeState.TabIndex = 2;
            this.gbxChangeState.TabStop = false;
            this.gbxChangeState.Text = "Change machine state";
            // 
            // cbxMachineID
            // 
            this.cbxMachineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMachineID.FormattingEnabled = true;
            this.cbxMachineID.Location = new System.Drawing.Point(162, 91);
            this.cbxMachineID.Name = "cbxMachineID";
            this.cbxMachineID.Size = new System.Drawing.Size(191, 28);
            this.cbxMachineID.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Machine ID:";
            // 
            // frmMachines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 693);
            this.Controls.Add(this.gbxMachines);
            this.Name = "frmMachines";
            this.Text = "B4 Plastics - Machines";
//            this.Load += new System.EventHandler(this.frmMachines_Load);
            this.gbxMachines.ResumeLayout(false);
            this.gbxMachineDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMachines;
        private System.Windows.Forms.GroupBox gbxMachineDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.GroupBox gbxChangeState;
        private System.Windows.Forms.ComboBox cbxMachineID;
        private System.Windows.Forms.Label label1;
    }
}