﻿
namespace B4_Plastics_SMS
{
    partial class TransactLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactLoad));
            this.tclTransactions = new System.Windows.Forms.TabControl();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbnFNo = new System.Windows.Forms.RadioButton();
            this.rbnFYes = new System.Windows.Forms.RadioButton();
            this.cbxFTransID = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.gbxTransactionDetails = new System.Windows.Forms.GroupBox();
            this.dgvTransactionDetails = new System.Windows.Forms.DataGridView();
            this.tabInsert = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvPipeDetails = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMakeTrans = new System.Windows.Forms.Button();
            this.dtpMDelivDate = new System.Windows.Forms.DateTimePicker();
            this.dtpMTransDate = new System.Windows.Forms.DateTimePicker();
            this.cbxMEmployID = new System.Windows.Forms.ComboBox();
            this.cbxMPipeID = new System.Windows.Forms.ComboBox();
            this.cbxMDispatchID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtMLocation = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtMQuantity = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCompleted = new System.Windows.Forms.CheckBox();
            this.dtpUDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpUTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.cbxUEmployeeStaff = new System.Windows.Forms.ComboBox();
            this.cbxUPipeID = new System.Windows.Forms.ComboBox();
            this.cbUDispatchStaff = new System.Windows.Forms.ComboBox();
            this.cbUpdateDispatchID = new System.Windows.Forms.ComboBox();
            this.cbxUpdateTransaction = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtULocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUQuantity = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.gbxDelete = new System.Windows.Forms.GroupBox();
            this.cbConfirmDel = new System.Windows.Forms.CheckBox();
            this.cbxDTransID = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tclTransactions.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbxTransactionDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDetails)).BeginInit();
            this.tabInsert.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPipeDetails)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabUpdate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.gbxDelete.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tclTransactions
            // 
            this.tclTransactions.Controls.Add(this.tabSearch);
            this.tclTransactions.Controls.Add(this.tabInsert);
            this.tclTransactions.Controls.Add(this.tabUpdate);
            this.tclTransactions.Controls.Add(this.tabDelete);
            this.tclTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclTransactions.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F);
            this.tclTransactions.Location = new System.Drawing.Point(0, 0);
            this.tclTransactions.Name = "tclTransactions";
            this.tclTransactions.SelectedIndex = 0;
            this.tclTransactions.Size = new System.Drawing.Size(1182, 973);
            this.tclTransactions.TabIndex = 3;
            this.tclTransactions.SelectedIndexChanged += new System.EventHandler(this.tclTransactions_SelectedIndexChanged);
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.btnDisplayAll);
            this.tabSearch.Controls.Add(this.groupBox5);
            this.tabSearch.Controls.Add(this.groupBox2);
            this.tabSearch.Controls.Add(this.gbxTransactionDetails);
            this.tabSearch.Location = new System.Drawing.Point(4, 32);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(1174, 937);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(498, 594);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 214);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter Transaction by:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbnFNo);
            this.groupBox6.Controls.Add(this.rbnFYes);
            this.groupBox6.ForeColor = System.Drawing.Color.Navy;
            this.groupBox6.Location = new System.Drawing.Point(27, 46);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(217, 138);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Is Completed:";
            // 
            // rbnFNo
            // 
            this.rbnFNo.AutoSize = true;
            this.rbnFNo.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.rbnFNo.ForeColor = System.Drawing.Color.Black;
            this.rbnFNo.Location = new System.Drawing.Point(25, 88);
            this.rbnFNo.Name = "rbnFNo";
            this.rbnFNo.Size = new System.Drawing.Size(58, 29);
            this.rbnFNo.TabIndex = 1;
            this.rbnFNo.TabStop = true;
            this.rbnFNo.Text = "No";
            this.rbnFNo.UseVisualStyleBackColor = true;
            this.rbnFNo.CheckedChanged += new System.EventHandler(this.rbnFNo_CheckedChanged);
            // 
            // rbnFYes
            // 
            this.rbnFYes.AutoSize = true;
            this.rbnFYes.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.rbnFYes.ForeColor = System.Drawing.Color.Black;
            this.rbnFYes.Location = new System.Drawing.Point(25, 48);
            this.rbnFYes.Name = "rbnFYes";
            this.rbnFYes.Size = new System.Drawing.Size(60, 29);
            this.rbnFYes.TabIndex = 0;
            this.rbnFYes.TabStop = true;
            this.rbnFYes.Text = "Yes";
            this.rbnFYes.UseVisualStyleBackColor = true;
            this.rbnFYes.CheckedChanged += new System.EventHandler(this.rbnFYes_CheckedChanged);
            // 
            // cbxFTransID
            // 
            this.cbxFTransID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxFTransID.FormattingEnabled = true;
            this.cbxFTransID.Location = new System.Drawing.Point(164, 49);
            this.cbxFTransID.Name = "cbxFTransID";
            this.cbxFTransID.Size = new System.Drawing.Size(217, 28);
            this.cbxFTransID.TabIndex = 0;
            this.cbxFTransID.SelectedIndexChanged += new System.EventHandler(this.cbxFTransID_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(16, 52);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 25);
            this.label20.TabIndex = 1;
            this.label20.Text = "Transaction ID:";
            // 
            // gbxTransactionDetails
            // 
            this.gbxTransactionDetails.BackColor = System.Drawing.Color.White;
            this.gbxTransactionDetails.Controls.Add(this.dgvTransactionDetails);
            this.gbxTransactionDetails.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.gbxTransactionDetails.ForeColor = System.Drawing.Color.Navy;
            this.gbxTransactionDetails.Location = new System.Drawing.Point(32, 63);
            this.gbxTransactionDetails.Name = "gbxTransactionDetails";
            this.gbxTransactionDetails.Size = new System.Drawing.Size(1067, 513);
            this.gbxTransactionDetails.TabIndex = 2;
            this.gbxTransactionDetails.TabStop = false;
            this.gbxTransactionDetails.Text = "Transaction Details";
            // 
            // dgvTransactionDetails
            // 
            this.dgvTransactionDetails.AllowUserToAddRows = false;
            this.dgvTransactionDetails.AllowUserToDeleteRows = false;
            this.dgvTransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionDetails.Location = new System.Drawing.Point(11, 35);
            this.dgvTransactionDetails.Name = "dgvTransactionDetails";
            this.dgvTransactionDetails.ReadOnly = true;
            this.dgvTransactionDetails.RowHeadersWidth = 51;
            this.dgvTransactionDetails.RowTemplate.Height = 24;
            this.dgvTransactionDetails.Size = new System.Drawing.Size(1038, 464);
            this.dgvTransactionDetails.TabIndex = 0;
            // 
            // tabInsert
            // 
            this.tabInsert.Controls.Add(this.groupBox4);
            this.tabInsert.Controls.Add(this.groupBox3);
            this.tabInsert.Location = new System.Drawing.Point(4, 32);
            this.tabInsert.Name = "tabInsert";
            this.tabInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsert.Size = new System.Drawing.Size(1174, 937);
            this.tabInsert.TabIndex = 1;
            this.tabInsert.Text = "Insert";
            this.tabInsert.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvPipeDetails);
            this.groupBox4.Font = new System.Drawing.Font("Nirmala UI Semilight", 11F);
            this.groupBox4.ForeColor = System.Drawing.Color.Navy;
            this.groupBox4.Location = new System.Drawing.Point(27, 474);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(836, 387);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pipe Details";
            // 
            // dgvPipeDetails
            // 
            this.dgvPipeDetails.AllowUserToAddRows = false;
            this.dgvPipeDetails.AllowUserToDeleteRows = false;
            this.dgvPipeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPipeDetails.Location = new System.Drawing.Point(29, 46);
            this.dgvPipeDetails.Name = "dgvPipeDetails";
            this.dgvPipeDetails.ReadOnly = true;
            this.dgvPipeDetails.RowHeadersWidth = 51;
            this.dgvPipeDetails.RowTemplate.Height = 24;
            this.dgvPipeDetails.Size = new System.Drawing.Size(783, 313);
            this.dgvPipeDetails.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnMakeTrans);
            this.groupBox3.Controls.Add(this.dtpMDelivDate);
            this.groupBox3.Controls.Add(this.dtpMTransDate);
            this.groupBox3.Controls.Add(this.cbxMEmployID);
            this.groupBox3.Controls.Add(this.cbxMPipeID);
            this.groupBox3.Controls.Add(this.cbxMDispatchID);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.txtMLocation);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.txtMQuantity);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(27, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(836, 394);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Make Transaction";
            // 
            // btnMakeTrans
            // 
            this.btnMakeTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(211)))));
            this.btnMakeTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeTrans.ForeColor = System.Drawing.Color.White;
            this.btnMakeTrans.Location = new System.Drawing.Point(357, 302);
            this.btnMakeTrans.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeTrans.Name = "btnMakeTrans";
            this.btnMakeTrans.Size = new System.Drawing.Size(265, 55);
            this.btnMakeTrans.TabIndex = 7;
            this.btnMakeTrans.Text = "&Make Transaction";
            this.btnMakeTrans.UseVisualStyleBackColor = false;
            this.btnMakeTrans.Click += new System.EventHandler(this.btnMakeTrans_Click);
            // 
            // dtpMDelivDate
            // 
            this.dtpMDelivDate.CustomFormat = "dd MMM, yyyy";
            this.dtpMDelivDate.Enabled = false;
            this.dtpMDelivDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMDelivDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMDelivDate.Location = new System.Drawing.Point(617, 118);
            this.dtpMDelivDate.Name = "dtpMDelivDate";
            this.dtpMDelivDate.Size = new System.Drawing.Size(195, 23);
            this.dtpMDelivDate.TabIndex = 5;
            // 
            // dtpMTransDate
            // 
            this.dtpMTransDate.CustomFormat = "dd MMM, yyyy";
            this.dtpMTransDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMTransDate.Location = new System.Drawing.Point(212, 235);
            this.dtpMTransDate.Name = "dtpMTransDate";
            this.dtpMTransDate.Size = new System.Drawing.Size(206, 23);
            this.dtpMTransDate.TabIndex = 3;
            this.dtpMTransDate.ValueChanged += new System.EventHandler(this.dtpMTransDate_ValueChanged);
            // 
            // cbxMEmployID
            // 
            this.cbxMEmployID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxMEmployID.FormattingEnabled = true;
            this.cbxMEmployID.Location = new System.Drawing.Point(212, 116);
            this.cbxMEmployID.Name = "cbxMEmployID";
            this.cbxMEmployID.Size = new System.Drawing.Size(207, 28);
            this.cbxMEmployID.TabIndex = 1;
            // 
            // cbxMPipeID
            // 
            this.cbxMPipeID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxMPipeID.FormattingEnabled = true;
            this.cbxMPipeID.Location = new System.Drawing.Point(211, 63);
            this.cbxMPipeID.Name = "cbxMPipeID";
            this.cbxMPipeID.Size = new System.Drawing.Size(207, 28);
            this.cbxMPipeID.TabIndex = 0;
            // 
            // cbxMDispatchID
            // 
            this.cbxMDispatchID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxMDispatchID.FormattingEnabled = true;
            this.cbxMDispatchID.Location = new System.Drawing.Point(618, 60);
            this.cbxMDispatchID.Name = "cbxMDispatchID";
            this.cbxMDispatchID.Size = new System.Drawing.Size(196, 28);
            this.cbxMDispatchID.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(483, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Delivery Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(46, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tansaction Date:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(117, 66);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(76, 25);
            this.label29.TabIndex = 13;
            this.label29.Text = "Pipe ID:";
            // 
            // txtMLocation
            // 
            this.txtMLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMLocation.Location = new System.Drawing.Point(618, 174);
            this.txtMLocation.Name = "txtMLocation";
            this.txtMLocation.Size = new System.Drawing.Size(196, 27);
            this.txtMLocation.TabIndex = 6;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(523, 176);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(88, 25);
            this.label30.TabIndex = 10;
            this.label30.Text = "Location:";
            // 
            // txtMQuantity
            // 
            this.txtMQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMQuantity.Location = new System.Drawing.Point(212, 174);
            this.txtMQuantity.Name = "txtMQuantity";
            this.txtMQuantity.Size = new System.Drawing.Size(207, 27);
            this.txtMQuantity.TabIndex = 2;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(105, 176);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(88, 25);
            this.label31.TabIndex = 10;
            this.label31.Text = "Quantity:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(459, 63);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(153, 25);
            this.label32.TabIndex = 8;
            this.label32.Text = "Dispacth staff ID:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(31, 119);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(162, 25);
            this.label33.TabIndex = 8;
            this.label33.Text = "Employee staff ID:";
            // 
            // tabUpdate
            // 
            this.tabUpdate.Controls.Add(this.groupBox1);
            this.tabUpdate.Location = new System.Drawing.Point(4, 32);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdate.Size = new System.Drawing.Size(1174, 937);
            this.tabUpdate.TabIndex = 2;
            this.tabUpdate.Text = "Update";
            this.tabUpdate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbCompleted);
            this.groupBox1.Controls.Add(this.dtpUDeliveryDate);
            this.groupBox1.Controls.Add(this.dtpUTransactionDate);
            this.groupBox1.Controls.Add(this.cbxUEmployeeStaff);
            this.groupBox1.Controls.Add(this.cbxUPipeID);
            this.groupBox1.Controls.Add(this.cbUDispatchStaff);
            this.groupBox1.Controls.Add(this.cbUpdateDispatchID);
            this.groupBox1.Controls.Add(this.cbxUpdateTransaction);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txtULocation);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUQuantity);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 521);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Transaction Details";
            // 
            // cbCompleted
            // 
            this.cbCompleted.AutoSize = true;
            this.cbCompleted.ForeColor = System.Drawing.Color.Black;
            this.cbCompleted.Location = new System.Drawing.Point(214, 345);
            this.cbCompleted.Name = "cbCompleted";
            this.cbCompleted.Size = new System.Drawing.Size(65, 34);
            this.cbCompleted.TabIndex = 5;
            this.cbCompleted.Text = "Yes";
            this.cbCompleted.UseVisualStyleBackColor = true;
            // 
            // dtpUDeliveryDate
            // 
            this.dtpUDeliveryDate.CustomFormat = "dd MMM, yyyy";
            this.dtpUDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUDeliveryDate.Location = new System.Drawing.Point(676, 170);
            this.dtpUDeliveryDate.Name = "dtpUDeliveryDate";
            this.dtpUDeliveryDate.Size = new System.Drawing.Size(264, 23);
            this.dtpUDeliveryDate.TabIndex = 8;
            // 
            // dtpUTransactionDate
            // 
            this.dtpUTransactionDate.CustomFormat = "dd MMM, yyyy";
            this.dtpUTransactionDate.Enabled = false;
            this.dtpUTransactionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUTransactionDate.Location = new System.Drawing.Point(215, 284);
            this.dtpUTransactionDate.Name = "dtpUTransactionDate";
            this.dtpUTransactionDate.Size = new System.Drawing.Size(264, 23);
            this.dtpUTransactionDate.TabIndex = 4;
            // 
            // cbxUEmployeeStaff
            // 
            this.cbxUEmployeeStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxUEmployeeStaff.FormattingEnabled = true;
            this.cbxUEmployeeStaff.Location = new System.Drawing.Point(215, 165);
            this.cbxUEmployeeStaff.Name = "cbxUEmployeeStaff";
            this.cbxUEmployeeStaff.Size = new System.Drawing.Size(265, 28);
            this.cbxUEmployeeStaff.TabIndex = 2;
            // 
            // cbxUPipeID
            // 
            this.cbxUPipeID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxUPipeID.FormattingEnabled = true;
            this.cbxUPipeID.Location = new System.Drawing.Point(214, 112);
            this.cbxUPipeID.Name = "cbxUPipeID";
            this.cbxUPipeID.Size = new System.Drawing.Size(265, 28);
            this.cbxUPipeID.TabIndex = 1;
            // 
            // cbUDispatchStaff
            // 
            this.cbUDispatchStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbUDispatchStaff.FormattingEnabled = true;
            this.cbUDispatchStaff.Location = new System.Drawing.Point(677, 112);
            this.cbUDispatchStaff.Name = "cbUDispatchStaff";
            this.cbUDispatchStaff.Size = new System.Drawing.Size(265, 28);
            this.cbUDispatchStaff.TabIndex = 7;
            // 
            // cbUpdateDispatchID
            // 
            this.cbUpdateDispatchID.Enabled = false;
            this.cbUpdateDispatchID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbUpdateDispatchID.FormattingEnabled = true;
            this.cbUpdateDispatchID.Location = new System.Drawing.Point(677, 57);
            this.cbUpdateDispatchID.Name = "cbUpdateDispatchID";
            this.cbUpdateDispatchID.Size = new System.Drawing.Size(265, 28);
            this.cbUpdateDispatchID.TabIndex = 6;
            // 
            // cbxUpdateTransaction
            // 
            this.cbxUpdateTransaction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxUpdateTransaction.FormattingEnabled = true;
            this.cbxUpdateTransaction.Location = new System.Drawing.Point(215, 58);
            this.cbxUpdateTransaction.Name = "cbxUpdateTransaction";
            this.cbxUpdateTransaction.Size = new System.Drawing.Size(265, 28);
            this.cbxUpdateTransaction.TabIndex = 0;
            this.cbxUpdateTransaction.SelectedIndexChanged += new System.EventHandler(this.cbxUpdateTransaction_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(211)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(214, 412);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(265, 55);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(24, 399);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 25);
            this.label18.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(70, 345);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 25);
            this.label19.TabIndex = 18;
            this.label19.Text = "Is Completed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(530, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Delivery Date:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(49, 282);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(149, 25);
            this.label21.TabIndex = 14;
            this.label21.Text = "Tansaction Date:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(61, 61);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(135, 25);
            this.label22.TabIndex = 13;
            this.label22.Text = "Transaction ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(547, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dispatch ID:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(120, 115);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 25);
            this.label23.TabIndex = 13;
            this.label23.Text = "Pipe ID:";
            // 
            // txtULocation
            // 
            this.txtULocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtULocation.Location = new System.Drawing.Point(677, 226);
            this.txtULocation.Name = "txtULocation";
            this.txtULocation.Size = new System.Drawing.Size(265, 27);
            this.txtULocation.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(570, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Location:";
            // 
            // txtUQuantity
            // 
            this.txtUQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUQuantity.Location = new System.Drawing.Point(215, 223);
            this.txtUQuantity.Name = "txtUQuantity";
            this.txtUQuantity.Size = new System.Drawing.Size(265, 27);
            this.txtUQuantity.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(108, 225);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 25);
            this.label24.TabIndex = 10;
            this.label24.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(506, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dispacth staff ID:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(34, 168);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(162, 25);
            this.label25.TabIndex = 8;
            this.label25.Text = "Employee staff ID:";
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.gbxDelete);
            this.tabDelete.Location = new System.Drawing.Point(4, 32);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(1174, 937);
            this.tabDelete.TabIndex = 3;
            this.tabDelete.Text = "Delete";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // gbxDelete
            // 
            this.gbxDelete.BackColor = System.Drawing.Color.White;
            this.gbxDelete.Controls.Add(this.cbConfirmDel);
            this.gbxDelete.Controls.Add(this.cbxDTransID);
            this.gbxDelete.Controls.Add(this.label26);
            this.gbxDelete.Controls.Add(this.btnDelete);
            this.gbxDelete.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.gbxDelete.ForeColor = System.Drawing.Color.Navy;
            this.gbxDelete.Location = new System.Drawing.Point(26, 28);
            this.gbxDelete.Name = "gbxDelete";
            this.gbxDelete.Size = new System.Drawing.Size(505, 292);
            this.gbxDelete.TabIndex = 0;
            this.gbxDelete.TabStop = false;
            this.gbxDelete.Text = "Delete Transaction";
            // 
            // cbConfirmDel
            // 
            this.cbConfirmDel.AutoSize = true;
            this.cbConfirmDel.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.cbConfirmDel.ForeColor = System.Drawing.Color.Black;
            this.cbConfirmDel.Location = new System.Drawing.Point(213, 134);
            this.cbConfirmDel.Name = "cbConfirmDel";
            this.cbConfirmDel.Size = new System.Drawing.Size(161, 29);
            this.cbConfirmDel.TabIndex = 1;
            this.cbConfirmDel.Text = "Confirm Delete";
            this.cbConfirmDel.UseVisualStyleBackColor = true;
            // 
            // cbxDTransID
            // 
            this.cbxDTransID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxDTransID.FormattingEnabled = true;
            this.cbxDTransID.Location = new System.Drawing.Point(213, 70);
            this.cbxDTransID.Name = "cbxDTransID";
            this.cbxDTransID.Size = new System.Drawing.Size(217, 28);
            this.cbxDTransID.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(72, 70);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(135, 25);
            this.label26.TabIndex = 23;
            this.label26.Text = "Transaction ID:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(211)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(137, 197);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(217, 55);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(211)))));
            this.btnDisplayAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAll.ForeColor = System.Drawing.Color.White;
            this.btnDisplayAll.Location = new System.Drawing.Point(859, 604);
            this.btnDisplayAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(240, 52);
            this.btnDisplayAll.TabIndex = 9;
            this.btnDisplayAll.Text = "&Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = false;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.cbxFTransID);
            this.groupBox5.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.groupBox5.ForeColor = System.Drawing.Color.Navy;
            this.groupBox5.Location = new System.Drawing.Point(32, 594);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(427, 214);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search Transaction by:";
            // 
            // TransactLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 973);
            this.Controls.Add(this.tclTransactions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TransactLoad";
            this.Text = "B4 Plastics - Transactions";
            this.Load += new System.EventHandler(this.TransactLoad_Load);
            this.tclTransactions.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gbxTransactionDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDetails)).EndInit();
            this.tabInsert.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPipeDetails)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabUpdate.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.gbxDelete.ResumeLayout(false);
            this.gbxDelete.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tclTransactions;
        private System.Windows.Forms.TabPage tabInsert;
        private System.Windows.Forms.Button btnMakeTrans;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxUpdateTransaction;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtUQuantity;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.GroupBox gbxDelete;
        private System.Windows.Forms.CheckBox cbConfirmDel;
        private System.Windows.Forms.ComboBox cbxDTransID;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxFTransID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox gbxTransactionDetails;
        private System.Windows.Forms.DataGridView dgvTransactionDetails;
        private System.Windows.Forms.CheckBox cbCompleted;
        private System.Windows.Forms.DateTimePicker dtpUDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtpUTransactionDate;
        private System.Windows.Forms.ComboBox cbxUEmployeeStaff;
        private System.Windows.Forms.ComboBox cbxUPipeID;
        private System.Windows.Forms.ComboBox cbUDispatchStaff;
        private System.Windows.Forms.ComboBox cbUpdateDispatchID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtULocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvPipeDetails;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpMDelivDate;
        private System.Windows.Forms.DateTimePicker dtpMTransDate;
        private System.Windows.Forms.ComboBox cbxMEmployID;
        private System.Windows.Forms.ComboBox cbxMPipeID;
        private System.Windows.Forms.ComboBox cbxMDispatchID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtMLocation;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtMQuantity;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbnFNo;
        private System.Windows.Forms.RadioButton rbnFYes;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}