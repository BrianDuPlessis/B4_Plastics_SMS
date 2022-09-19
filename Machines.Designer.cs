
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Machines));
            this.tclMachines = new System.Windows.Forms.TabControl();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbMaintianed = new System.Windows.Forms.RadioButton();
            this.rbNeedsService = new System.Windows.Forms.RadioButton();
            this.cbFilterStatus = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.gbxMachineDetails = new System.Windows.Forms.GroupBox();
            this.dgvMachineDetails = new System.Windows.Forms.DataGridView();
            this.tabInsert = new System.Windows.Forms.TabPage();
            this.gbxInsertAdd = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbIInActive = new System.Windows.Forms.RadioButton();
            this.rbIActive = new System.Windows.Forms.RadioButton();
            this.dtpIServiceDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtICapacity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbUInActive = new System.Windows.Forms.RadioButton();
            this.rbUActive = new System.Windows.Forms.RadioButton();
            this.dtpUServiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtUCapacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUpdateMachine = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.gbxDelete = new System.Windows.Forms.GroupBox();
            this.cbConfirm = new System.Windows.Forms.CheckBox();
            this.cbDeleteMachine = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tclMachines.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbxMachineDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineDetails)).BeginInit();
            this.tabInsert.SuspendLayout();
            this.gbxInsertAdd.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabUpdate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.gbxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tclMachines
            // 
            this.tclMachines.Controls.Add(this.tabSearch);
            this.tclMachines.Controls.Add(this.tabInsert);
            this.tclMachines.Controls.Add(this.tabUpdate);
            this.tclMachines.Controls.Add(this.tabDelete);
            this.tclMachines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclMachines.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F);
            this.tclMachines.Location = new System.Drawing.Point(0, 0);
            this.tclMachines.Name = "tclMachines";
            this.tclMachines.SelectedIndex = 0;
            this.tclMachines.Size = new System.Drawing.Size(1023, 883);
            this.tclMachines.TabIndex = 9;
            this.tclMachines.SelectedIndexChanged += new System.EventHandler(this.tclMachines_SelectedIndexChanged);
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.groupBox2);
            this.tabSearch.Controls.Add(this.gbxMachineDetails);
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
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.cbFilterStatus);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(184, 489);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 314);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter Machines by:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbMaintianed);
            this.groupBox5.Controls.Add(this.rbNeedsService);
            this.groupBox5.ForeColor = System.Drawing.Color.Navy;
            this.groupBox5.Location = new System.Drawing.Point(240, 134);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 149);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Machines Service:";
            // 
            // rbMaintianed
            // 
            this.rbMaintianed.AutoSize = true;
            this.rbMaintianed.ForeColor = System.Drawing.Color.Black;
            this.rbMaintianed.Location = new System.Drawing.Point(25, 88);
            this.rbMaintianed.Name = "rbMaintianed";
            this.rbMaintianed.Size = new System.Drawing.Size(140, 34);
            this.rbMaintianed.TabIndex = 0;
            this.rbMaintianed.TabStop = true;
            this.rbMaintianed.Text = "Maintained";
            this.rbMaintianed.UseVisualStyleBackColor = true;
            this.rbMaintianed.CheckedChanged += new System.EventHandler(this.rbMaintianed_CheckedChanged);
            // 
            // rbNeedsService
            // 
            this.rbNeedsService.AutoSize = true;
            this.rbNeedsService.ForeColor = System.Drawing.Color.Black;
            this.rbNeedsService.Location = new System.Drawing.Point(25, 48);
            this.rbNeedsService.Name = "rbNeedsService";
            this.rbNeedsService.Size = new System.Drawing.Size(166, 34);
            this.rbNeedsService.TabIndex = 0;
            this.rbNeedsService.TabStop = true;
            this.rbNeedsService.Text = "Needs Service";
            this.rbNeedsService.UseVisualStyleBackColor = true;
            this.rbNeedsService.CheckedChanged += new System.EventHandler(this.rbNeedsService_CheckedChanged);
            // 
            // cbFilterStatus
            // 
            this.cbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbFilterStatus.FormattingEnabled = true;
            this.cbFilterStatus.Location = new System.Drawing.Point(240, 68);
            this.cbFilterStatus.Name = "cbFilterStatus";
            this.cbFilterStatus.Size = new System.Drawing.Size(264, 28);
            this.cbFilterStatus.TabIndex = 2;
            this.cbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cbFilterStatus_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(41, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(140, 31);
            this.label20.TabIndex = 1;
            this.label20.Text = "Machine ID:";
            // 
            // gbxMachineDetails
            // 
            this.gbxMachineDetails.BackColor = System.Drawing.Color.White;
            this.gbxMachineDetails.Controls.Add(this.dgvMachineDetails);
            this.gbxMachineDetails.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.gbxMachineDetails.ForeColor = System.Drawing.Color.Navy;
            this.gbxMachineDetails.Location = new System.Drawing.Point(29, 37);
            this.gbxMachineDetails.Name = "gbxMachineDetails";
            this.gbxMachineDetails.Size = new System.Drawing.Size(909, 415);
            this.gbxMachineDetails.TabIndex = 7;
            this.gbxMachineDetails.TabStop = false;
            this.gbxMachineDetails.Text = "Machine Details";
            // 
            // dgvMachineDetails
            // 
            this.dgvMachineDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachineDetails.Location = new System.Drawing.Point(26, 59);
            this.dgvMachineDetails.Name = "dgvMachineDetails";
            this.dgvMachineDetails.RowHeadersWidth = 51;
            this.dgvMachineDetails.RowTemplate.Height = 24;
            this.dgvMachineDetails.Size = new System.Drawing.Size(855, 326);
            this.dgvMachineDetails.TabIndex = 0;
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
            this.gbxInsertAdd.Controls.Add(this.groupBox3);
            this.gbxInsertAdd.Controls.Add(this.dtpIServiceDate);
            this.gbxInsertAdd.Controls.Add(this.btnAdd);
            this.gbxInsertAdd.Controls.Add(this.txtICapacity);
            this.gbxInsertAdd.Controls.Add(this.label10);
            this.gbxInsertAdd.Controls.Add(this.label6);
            this.gbxInsertAdd.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.gbxInsertAdd.ForeColor = System.Drawing.Color.Navy;
            this.gbxInsertAdd.Location = new System.Drawing.Point(33, 34);
            this.gbxInsertAdd.Name = "gbxInsertAdd";
            this.gbxInsertAdd.Size = new System.Drawing.Size(585, 464);
            this.gbxInsertAdd.TabIndex = 6;
            this.gbxInsertAdd.TabStop = false;
            this.gbxInsertAdd.Text = "Insert/ Add Machines";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbIInActive);
            this.groupBox3.Controls.Add(this.rbIActive);
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(234, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 149);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // rbIInActive
            // 
            this.rbIInActive.AutoSize = true;
            this.rbIInActive.ForeColor = System.Drawing.Color.Black;
            this.rbIInActive.Location = new System.Drawing.Point(25, 88);
            this.rbIInActive.Name = "rbIInActive";
            this.rbIInActive.Size = new System.Drawing.Size(135, 43);
            this.rbIInActive.TabIndex = 0;
            this.rbIInActive.TabStop = true;
            this.rbIInActive.Text = "InActive";
            this.rbIInActive.UseVisualStyleBackColor = true;
            // 
            // rbIActive
            // 
            this.rbIActive.AutoSize = true;
            this.rbIActive.ForeColor = System.Drawing.Color.Black;
            this.rbIActive.Location = new System.Drawing.Point(25, 48);
            this.rbIActive.Name = "rbIActive";
            this.rbIActive.Size = new System.Drawing.Size(91, 34);
            this.rbIActive.TabIndex = 0;
            this.rbIActive.TabStop = true;
            this.rbIActive.Text = "Active";
            this.rbIActive.UseVisualStyleBackColor = true;
            // 
            // dtpIServiceDate
            // 
            this.dtpIServiceDate.CustomFormat = "dd MMM, yyyy";
            this.dtpIServiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIServiceDate.Location = new System.Drawing.Point(235, 119);
            this.dtpIServiceDate.Name = "dtpIServiceDate";
            this.dtpIServiceDate.Size = new System.Drawing.Size(264, 23);
            this.dtpIServiceDate.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(211)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(233, 358);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(265, 55);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtICapacity
            // 
            this.txtICapacity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtICapacity.Location = new System.Drawing.Point(234, 60);
            this.txtICapacity.Name = "txtICapacity";
            this.txtICapacity.Size = new System.Drawing.Size(264, 27);
            this.txtICapacity.TabIndex = 3;
            this.txtICapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(118, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Capacity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(85, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Service Date:";
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
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.dtpUServiceDate);
            this.groupBox1.Controls.Add(this.txtUCapacity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbUpdateMachine);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(34, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 527);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Machine Details";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbUInActive);
            this.groupBox4.Controls.Add(this.rbUActive);
            this.groupBox4.ForeColor = System.Drawing.Color.Navy;
            this.groupBox4.Location = new System.Drawing.Point(236, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 149);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
            // rbUInActive
            // 
            this.rbUInActive.AutoSize = true;
            this.rbUInActive.ForeColor = System.Drawing.Color.Black;
            this.rbUInActive.Location = new System.Drawing.Point(25, 88);
            this.rbUInActive.Name = "rbUInActive";
            this.rbUInActive.Size = new System.Drawing.Size(135, 43);
            this.rbUInActive.TabIndex = 0;
            this.rbUInActive.TabStop = true;
            this.rbUInActive.Text = "InActive";
            this.rbUInActive.UseVisualStyleBackColor = true;
            // 
            // rbUActive
            // 
            this.rbUActive.AutoSize = true;
            this.rbUActive.ForeColor = System.Drawing.Color.Black;
            this.rbUActive.Location = new System.Drawing.Point(25, 48);
            this.rbUActive.Name = "rbUActive";
            this.rbUActive.Size = new System.Drawing.Size(91, 34);
            this.rbUActive.TabIndex = 0;
            this.rbUActive.TabStop = true;
            this.rbUActive.Text = "Active";
            this.rbUActive.UseVisualStyleBackColor = true;
            // 
            // dtpUServiceDate
            // 
            this.dtpUServiceDate.CustomFormat = "dd MMM, yyyy";
            this.dtpUServiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUServiceDate.Location = new System.Drawing.Point(237, 181);
            this.dtpUServiceDate.Name = "dtpUServiceDate";
            this.dtpUServiceDate.Size = new System.Drawing.Size(264, 23);
            this.dtpUServiceDate.TabIndex = 27;
            // 
            // txtUCapacity
            // 
            this.txtUCapacity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUCapacity.Location = new System.Drawing.Point(236, 122);
            this.txtUCapacity.Name = "txtUCapacity";
            this.txtUCapacity.Size = new System.Drawing.Size(264, 27);
            this.txtUCapacity.TabIndex = 24;
            this.txtUCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(120, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Capacity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(87, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Service Date:";
            // 
            // cbUpdateMachine
            // 
            this.cbUpdateMachine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbUpdateMachine.FormattingEnabled = true;
            this.cbUpdateMachine.Location = new System.Drawing.Point(234, 58);
            this.cbUpdateMachine.Name = "cbUpdateMachine";
            this.cbUpdateMachine.Size = new System.Drawing.Size(265, 28);
            this.cbUpdateMachine.TabIndex = 22;
            this.cbUpdateMachine.SelectedIndexChanged += new System.EventHandler(this.cbUpdateMachine_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(211)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(234, 425);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(265, 55);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(96, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 25);
            this.label17.TabIndex = 13;
            this.label17.Text = "Machine ID:";
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
            this.gbxDelete.Controls.Add(this.cbDeleteMachine);
            this.gbxDelete.Controls.Add(this.label4);
            this.gbxDelete.Controls.Add(this.btnDelete);
            this.gbxDelete.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.gbxDelete.ForeColor = System.Drawing.Color.Navy;
            this.gbxDelete.Location = new System.Drawing.Point(31, 33);
            this.gbxDelete.Name = "gbxDelete";
            this.gbxDelete.Size = new System.Drawing.Size(429, 277);
            this.gbxDelete.TabIndex = 7;
            this.gbxDelete.TabStop = false;
            this.gbxDelete.Text = "Delete Machine";
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
            // cbDeleteMachine
            // 
            this.cbDeleteMachine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbDeleteMachine.FormattingEnabled = true;
            this.cbDeleteMachine.Location = new System.Drawing.Point(139, 71);
            this.cbDeleteMachine.Name = "cbDeleteMachine";
            this.cbDeleteMachine.Size = new System.Drawing.Size(217, 28);
            this.cbDeleteMachine.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Machine ID:";
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Machines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 883);
            this.Controls.Add(this.tclMachines);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Machines";
            this.Text = "B4 Plastics - Machines";
            this.Load += new System.EventHandler(this.Machines_Load);
            this.tclMachines.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbxMachineDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineDetails)).EndInit();
            this.tabInsert.ResumeLayout(false);
            this.gbxInsertAdd.ResumeLayout(false);
            this.gbxInsertAdd.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabUpdate.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.gbxDelete.ResumeLayout(false);
            this.gbxDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tclMachines;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbFilterStatus;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox gbxMachineDetails;
        private System.Windows.Forms.DataGridView dgvMachineDetails;
        private System.Windows.Forms.TabPage tabInsert;
        private System.Windows.Forms.GroupBox gbxInsertAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtICapacity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbUpdateMachine;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.GroupBox gbxDelete;
        private System.Windows.Forms.CheckBox cbConfirm;
        private System.Windows.Forms.ComboBox cbDeleteMachine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpIServiceDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbIInActive;
        private System.Windows.Forms.RadioButton rbIActive;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbUInActive;
        private System.Windows.Forms.RadioButton rbUActive;
        private System.Windows.Forms.DateTimePicker dtpUServiceDate;
        private System.Windows.Forms.TextBox txtUCapacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbMaintianed;
        private System.Windows.Forms.RadioButton rbNeedsService;
    }
}