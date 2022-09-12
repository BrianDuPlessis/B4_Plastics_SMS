
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxStockDetails = new System.Windows.Forms.GroupBox();
            this.dgvStockDetails = new System.Windows.Forms.DataGridView();
            this.tabInsert = new System.Windows.Forms.TabPage();
            this.gbxInsertAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtIEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtILastName = new System.Windows.Forms.TextBox();
            this.txtIFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUpdateStock = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.gbxDelete = new System.Windows.Forms.GroupBox();
            this.cbConfirm = new System.Windows.Forms.CheckBox();
            this.cbDeleteStock = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbSearchPipeID = new System.Windows.Forms.ComboBox();
            this.cbFilterColour = new System.Windows.Forms.ComboBox();
            this.cbIColour = new System.Windows.Forms.ComboBox();
            this.cbUColour = new System.Windows.Forms.ComboBox();
            this.txtULength = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUPipeQuantity = new System.Windows.Forms.TextBox();
            this.txtUDiameter = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.gbxStockDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockDetails)).BeginInit();
            this.tabInsert.SuspendLayout();
            this.gbxInsertAdd.SuspendLayout();
            this.tabUpdate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.gbxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Controls.Add(this.tabInsert);
            this.tabControl1.Controls.Add(this.tabUpdate);
            this.tabControl1.Controls.Add(this.tabDelete);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1023, 883);
            this.tabControl1.TabIndex = 9;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.groupBox2);
            this.tabSearch.Controls.Add(this.gbxSearch);
            this.tabSearch.Controls.Add(this.gbxStockDetails);
            this.tabSearch.Location = new System.Drawing.Point(4, 32);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(1015, 847);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.cbFilterColour);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(524, 490);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 255);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter Stock by:";
            // 
            // gbxSearch
            // 
            this.gbxSearch.BackColor = System.Drawing.Color.White;
            this.gbxSearch.Controls.Add(this.cbSearchPipeID);
            this.gbxSearch.Controls.Add(this.txtSearchQuantity);
            this.gbxSearch.Controls.Add(this.label2);
            this.gbxSearch.Controls.Add(this.label1);
            this.gbxSearch.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.gbxSearch.ForeColor = System.Drawing.Color.Navy;
            this.gbxSearch.Location = new System.Drawing.Point(29, 490);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(468, 255);
            this.gbxSearch.TabIndex = 4;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search Stock by:";
            // 
            // txtSearchQuantity
            // 
            this.txtSearchQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchQuantity.Location = new System.Drawing.Point(212, 137);
            this.txtSearchQuantity.Name = "txtSearchQuantity";
            this.txtSearchQuantity.Size = new System.Drawing.Size(217, 27);
            this.txtSearchQuantity.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(44, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Colour:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pipe quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(87, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pipe ID:";
            // 
            // gbxStockDetails
            // 
            this.gbxStockDetails.BackColor = System.Drawing.Color.White;
            this.gbxStockDetails.Controls.Add(this.dgvStockDetails);
            this.gbxStockDetails.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.gbxStockDetails.ForeColor = System.Drawing.Color.Navy;
            this.gbxStockDetails.Location = new System.Drawing.Point(29, 37);
            this.gbxStockDetails.Name = "gbxStockDetails";
            this.gbxStockDetails.Size = new System.Drawing.Size(909, 415);
            this.gbxStockDetails.TabIndex = 7;
            this.gbxStockDetails.TabStop = false;
            this.gbxStockDetails.Text = "Stock Details";
            // 
            // dgvStockDetails
            // 
            this.dgvStockDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockDetails.Location = new System.Drawing.Point(26, 59);
            this.dgvStockDetails.Name = "dgvStockDetails";
            this.dgvStockDetails.RowHeadersWidth = 51;
            this.dgvStockDetails.RowTemplate.Height = 24;
            this.dgvStockDetails.Size = new System.Drawing.Size(855, 326);
            this.dgvStockDetails.TabIndex = 0;
            // 
            // tabInsert
            // 
            this.tabInsert.Controls.Add(this.gbxInsertAdd);
            this.tabInsert.Location = new System.Drawing.Point(4, 32);
            this.tabInsert.Name = "tabInsert";
            this.tabInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsert.Size = new System.Drawing.Size(1015, 847);
            this.tabInsert.TabIndex = 1;
            this.tabInsert.Text = "Insert";
            this.tabInsert.UseVisualStyleBackColor = true;
            // 
            // gbxInsertAdd
            // 
            this.gbxInsertAdd.BackColor = System.Drawing.Color.White;
            this.gbxInsertAdd.Controls.Add(this.cbIColour);
            this.gbxInsertAdd.Controls.Add(this.btnAdd);
            this.gbxInsertAdd.Controls.Add(this.txtIEmail);
            this.gbxInsertAdd.Controls.Add(this.label9);
            this.gbxInsertAdd.Controls.Add(this.label10);
            this.gbxInsertAdd.Controls.Add(this.txtILastName);
            this.gbxInsertAdd.Controls.Add(this.txtIFirstName);
            this.gbxInsertAdd.Controls.Add(this.label5);
            this.gbxInsertAdd.Controls.Add(this.label6);
            this.gbxInsertAdd.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.gbxInsertAdd.ForeColor = System.Drawing.Color.Navy;
            this.gbxInsertAdd.Location = new System.Drawing.Point(70, 70);
            this.gbxInsertAdd.Name = "gbxInsertAdd";
            this.gbxInsertAdd.Size = new System.Drawing.Size(585, 419);
            this.gbxInsertAdd.TabIndex = 6;
            this.gbxInsertAdd.TabStop = false;
            this.gbxInsertAdd.Text = "Insert/ Add Stock";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(211)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(234, 292);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(265, 55);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtIEmail
            // 
            this.txtIEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIEmail.Location = new System.Drawing.Point(234, 60);
            this.txtIEmail.Name = "txtIEmail";
            this.txtIEmail.Size = new System.Drawing.Size(264, 27);
            this.txtIEmail.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(135, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Colour:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(135, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Length:";
            // 
            // txtILastName
            // 
            this.txtILastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtILastName.Location = new System.Drawing.Point(234, 170);
            this.txtILastName.Name = "txtILastName";
            this.txtILastName.Size = new System.Drawing.Size(264, 27);
            this.txtILastName.TabIndex = 2;
            // 
            // txtIFirstName
            // 
            this.txtIFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIFirstName.Location = new System.Drawing.Point(234, 115);
            this.txtIFirstName.Name = "txtIFirstName";
            this.txtIFirstName.Size = new System.Drawing.Size(264, 27);
            this.txtIFirstName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(79, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pipe Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(115, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Diameter:";
            // 
            // tabUpdate
            // 
            this.tabUpdate.Controls.Add(this.groupBox1);
            this.tabUpdate.Location = new System.Drawing.Point(4, 32);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdate.Size = new System.Drawing.Size(1015, 847);
            this.tabUpdate.TabIndex = 2;
            this.tabUpdate.Text = "Update";
            this.tabUpdate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbUColour);
            this.groupBox1.Controls.Add(this.txtULength);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtUPipeQuantity);
            this.groupBox1.Controls.Add(this.txtUDiameter);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbUpdateStock);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(70, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 466);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Stock Details";
            // 
            // cbUpdateStock
            // 
            this.cbUpdateStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbUpdateStock.FormattingEnabled = true;
            this.cbUpdateStock.Location = new System.Drawing.Point(234, 58);
            this.cbUpdateStock.Name = "cbUpdateStock";
            this.cbUpdateStock.Size = new System.Drawing.Size(265, 28);
            this.cbUpdateStock.TabIndex = 22;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(211)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(234, 357);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(265, 55);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(120, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 25);
            this.label17.TabIndex = 13;
            this.label17.Text = "Staff ID:";
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.gbxDelete);
            this.tabDelete.Location = new System.Drawing.Point(4, 32);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(1015, 847);
            this.tabDelete.TabIndex = 3;
            this.tabDelete.Text = "Delete";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // gbxDelete
            // 
            this.gbxDelete.BackColor = System.Drawing.Color.White;
            this.gbxDelete.Controls.Add(this.cbConfirm);
            this.gbxDelete.Controls.Add(this.cbDeleteStock);
            this.gbxDelete.Controls.Add(this.label4);
            this.gbxDelete.Controls.Add(this.btnDelete);
            this.gbxDelete.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.gbxDelete.ForeColor = System.Drawing.Color.Navy;
            this.gbxDelete.Location = new System.Drawing.Point(70, 70);
            this.gbxDelete.Name = "gbxDelete";
            this.gbxDelete.Size = new System.Drawing.Size(429, 277);
            this.gbxDelete.TabIndex = 7;
            this.gbxDelete.TabStop = false;
            this.gbxDelete.Text = "Delete Stock";
            // 
            // cbConfirm
            // 
            this.cbConfirm.AutoSize = true;
            this.cbConfirm.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.cbConfirm.ForeColor = System.Drawing.Color.Black;
            this.cbConfirm.Location = new System.Drawing.Point(139, 137);
            this.cbConfirm.Name = "cbConfirm";
            this.cbConfirm.Size = new System.Drawing.Size(161, 29);
            this.cbConfirm.TabIndex = 25;
            this.cbConfirm.Text = "Confirm Delete";
            this.cbConfirm.UseVisualStyleBackColor = true;
            // 
            // cbDeleteStock
            // 
            this.cbDeleteStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbDeleteStock.FormattingEnabled = true;
            this.cbDeleteStock.Location = new System.Drawing.Point(139, 71);
            this.cbDeleteStock.Name = "cbDeleteStock";
            this.cbDeleteStock.Size = new System.Drawing.Size(217, 28);
            this.cbDeleteStock.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 31);
            this.label4.TabIndex = 23;
            this.label4.Text = "Stock ID:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(211)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(139, 202);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(217, 55);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // cbSearchPipeID
            // 
            this.cbSearchPipeID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbSearchPipeID.FormattingEnabled = true;
            this.cbSearchPipeID.Location = new System.Drawing.Point(212, 72);
            this.cbSearchPipeID.Name = "cbSearchPipeID";
            this.cbSearchPipeID.Size = new System.Drawing.Size(217, 28);
            this.cbSearchPipeID.TabIndex = 2;
            // 
            // cbFilterColour
            // 
            this.cbFilterColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbFilterColour.FormattingEnabled = true;
            this.cbFilterColour.Location = new System.Drawing.Point(169, 71);
            this.cbFilterColour.Name = "cbFilterColour";
            this.cbFilterColour.Size = new System.Drawing.Size(217, 28);
            this.cbFilterColour.TabIndex = 2;
            // 
            // cbIColour
            // 
            this.cbIColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbIColour.FormattingEnabled = true;
            this.cbIColour.Location = new System.Drawing.Point(234, 230);
            this.cbIColour.Name = "cbIColour";
            this.cbIColour.Size = new System.Drawing.Size(264, 28);
            this.cbIColour.TabIndex = 22;
            // 
            // cbUColour
            // 
            this.cbUColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbUColour.FormattingEnabled = true;
            this.cbUColour.Location = new System.Drawing.Point(234, 284);
            this.cbUColour.Name = "cbUColour";
            this.cbUColour.Size = new System.Drawing.Size(265, 28);
            this.cbUColour.TabIndex = 30;
            // 
            // txtULength
            // 
            this.txtULength.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtULength.Location = new System.Drawing.Point(234, 114);
            this.txtULength.Name = "txtULength";
            this.txtULength.Size = new System.Drawing.Size(265, 27);
            this.txtULength.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(122, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Colour:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(122, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Length:";
            // 
            // txtUPipeQuantity
            // 
            this.txtUPipeQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUPipeQuantity.Location = new System.Drawing.Point(234, 224);
            this.txtUPipeQuantity.Name = "txtUPipeQuantity";
            this.txtUPipeQuantity.Size = new System.Drawing.Size(265, 27);
            this.txtUPipeQuantity.TabIndex = 24;
            // 
            // txtUDiameter
            // 
            this.txtUDiameter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUDiameter.Location = new System.Drawing.Point(234, 169);
            this.txtUDiameter.Name = "txtUDiameter";
            this.txtUDiameter.Size = new System.Drawing.Size(265, 27);
            this.txtUDiameter.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(66, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Pipe Quantity:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(102, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "Diameter:";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 883);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stock";
            this.Text = "B4 Plastics - Stock";
            this.tabControl1.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxStockDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockDetails)).EndInit();
            this.tabInsert.ResumeLayout(false);
            this.gbxInsertAdd.ResumeLayout(false);
            this.gbxInsertAdd.PerformLayout();
            this.tabUpdate.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.gbxDelete.ResumeLayout(false);
            this.gbxDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox txtSearchQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxStockDetails;
        private System.Windows.Forms.DataGridView dgvStockDetails;
        private System.Windows.Forms.TabPage tabInsert;
        private System.Windows.Forms.GroupBox gbxInsertAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtIEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtILastName;
        private System.Windows.Forms.TextBox txtIFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbUpdateStock;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.GroupBox gbxDelete;
        private System.Windows.Forms.CheckBox cbConfirm;
        private System.Windows.Forms.ComboBox cbDeleteStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbFilterColour;
        private System.Windows.Forms.ComboBox cbSearchPipeID;
        private System.Windows.Forms.ComboBox cbIColour;
        private System.Windows.Forms.ComboBox cbUColour;
        private System.Windows.Forms.TextBox txtULength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUPipeQuantity;
        private System.Windows.Forms.TextBox txtUDiameter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}