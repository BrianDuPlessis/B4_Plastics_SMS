
namespace B4_Plastics_SMS
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvUnderstock = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.btnOkCustomDate = new System.Windows.Forms.Button();
            this.btnCustomDate = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.btnLast30Days = new System.Windows.Forms.Button();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.chartTransactionsVSDate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMachinesNeedsService = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblMachinesNeedsService = new System.Windows.Forms.Label();
            this.lblTitleMachinesNeedsService = new System.Windows.Forms.Label();
            this.pnlMachinesNotActive = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblMachinesNotActive = new System.Windows.Forms.Label();
            this.lblTitleMachinesNotActive = new System.Windows.Forms.Label();
            this.pnlMachinesActive = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblMachinesActive = new System.Windows.Forms.Label();
            this.lblTitleMachinesActive = new System.Windows.Forms.Label();
            this.pnlTransactionsCompleted = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTransactionsCompleted = new System.Windows.Forms.Label();
            this.lblTitleTransactionsCompleted = new System.Windows.Forms.Label();
            this.pnlTransactionsActive = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTransactionsActive = new System.Windows.Forms.Label();
            this.lblTitleTransactionsActive = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTransactionsVSDate)).BeginInit();
            this.pnlMachinesNeedsService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlMachinesNotActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlMachinesActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlTransactionsCompleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlTransactionsActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dgvUnderstock);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(732, 77);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(312, 503);
            this.panel5.TabIndex = 39;
            // 
            // dgvUnderstock
            // 
            this.dgvUnderstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnderstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnderstock.Location = new System.Drawing.Point(15, 57);
            this.dgvUnderstock.Name = "dgvUnderstock";
            this.dgvUnderstock.RowHeadersWidth = 51;
            this.dgvUnderstock.Size = new System.Drawing.Size(272, 424);
            this.dgvUnderstock.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 29);
            this.label13.TabIndex = 2;
            this.label13.Text = "Low stock products";
            // 
            // btnOkCustomDate
            // 
            this.btnOkCustomDate.Font = new System.Drawing.Font("Nirmala UI", 8.5F);
            this.btnOkCustomDate.Location = new System.Drawing.Point(333, 14);
            this.btnOkCustomDate.Margin = new System.Windows.Forms.Padding(5);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(40, 35);
            this.btnOkCustomDate.TabIndex = 38;
            this.btnOkCustomDate.Text = "Ok";
            this.btnOkCustomDate.UseVisualStyleBackColor = true;
            this.btnOkCustomDate.Visible = false;
            this.btnOkCustomDate.Click += new System.EventHandler(this.btnOkCustomDate_Click);
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.Font = new System.Drawing.Font("Nirmala UI", 8.5F);
            this.btnCustomDate.Location = new System.Drawing.Point(379, 14);
            this.btnCustomDate.Margin = new System.Windows.Forms.Padding(5);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(130, 35);
            this.btnCustomDate.TabIndex = 37;
            this.btnCustomDate.Text = "Custom";
            this.btnCustomDate.UseVisualStyleBackColor = true;
            this.btnCustomDate.Click += new System.EventHandler(this.btnCustomDate_Click);
            // 
            // btnToday
            // 
            this.btnToday.Font = new System.Drawing.Font("Nirmala UI", 8.5F);
            this.btnToday.Location = new System.Drawing.Point(515, 14);
            this.btnToday.Margin = new System.Windows.Forms.Padding(5);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(130, 35);
            this.btnToday.TabIndex = 36;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.Font = new System.Drawing.Font("Nirmala UI", 8.5F);
            this.btnLast7Days.Location = new System.Drawing.Point(649, 14);
            this.btnLast7Days.Margin = new System.Windows.Forms.Padding(5);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(130, 35);
            this.btnLast7Days.TabIndex = 35;
            this.btnLast7Days.Text = "Last 7 days";
            this.btnLast7Days.UseVisualStyleBackColor = true;
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.Font = new System.Drawing.Font("Nirmala UI", 8.5F);
            this.btnLast30Days.Location = new System.Drawing.Point(782, 14);
            this.btnLast30Days.Margin = new System.Windows.Forms.Padding(5);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(130, 35);
            this.btnLast30Days.TabIndex = 34;
            this.btnLast30Days.Text = "Last 30 days";
            this.btnLast30Days.UseVisualStyleBackColor = true;
            this.btnLast30Days.Click += new System.EventHandler(this.btnLast30Days_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.Font = new System.Drawing.Font("Nirmala UI", 8.5F);
            this.btnThisMonth.Location = new System.Drawing.Point(914, 14);
            this.btnThisMonth.Margin = new System.Windows.Forms.Padding(5);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(130, 35);
            this.btnThisMonth.TabIndex = 33;
            this.btnThisMonth.Text = "This month";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(203, 22);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(122, 23);
            this.dtpEndDate.TabIndex = 32;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(57, 22);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(122, 23);
            this.dtpStartDate.TabIndex = 31;
            // 
            // chartTransactionsVSDate
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTransactionsVSDate.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTransactionsVSDate.Legends.Add(legend1);
            this.chartTransactionsVSDate.Location = new System.Drawing.Point(57, 275);
            this.chartTransactionsVSDate.Name = "chartTransactionsVSDate";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Quantity";
            this.chartTransactionsVSDate.Series.Add(series1);
            this.chartTransactionsVSDate.Size = new System.Drawing.Size(648, 305);
            this.chartTransactionsVSDate.TabIndex = 30;
            this.chartTransactionsVSDate.Text = "chartTransactionsVSDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 35);
            this.label2.TabIndex = 29;
            this.label2.Text = "Stock out flow";
            // 
            // pnlMachinesNeedsService
            // 
            this.pnlMachinesNeedsService.BackColor = System.Drawing.Color.White;
            this.pnlMachinesNeedsService.Controls.Add(this.pictureBox5);
            this.pnlMachinesNeedsService.Controls.Add(this.lblMachinesNeedsService);
            this.pnlMachinesNeedsService.Controls.Add(this.lblTitleMachinesNeedsService);
            this.pnlMachinesNeedsService.Location = new System.Drawing.Point(732, 619);
            this.pnlMachinesNeedsService.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMachinesNeedsService.Name = "pnlMachinesNeedsService";
            this.pnlMachinesNeedsService.Size = new System.Drawing.Size(312, 122);
            this.pnlMachinesNeedsService.TabIndex = 24;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Image = global::B4_Plastics_SMS.Properties.Resources.Dot_Red;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(24, 73);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(16, 15);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // lblMachinesNeedsService
            // 
            this.lblMachinesNeedsService.AutoSize = true;
            this.lblMachinesNeedsService.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachinesNeedsService.Location = new System.Drawing.Point(52, 57);
            this.lblMachinesNeedsService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMachinesNeedsService.Name = "lblMachinesNeedsService";
            this.lblMachinesNeedsService.Size = new System.Drawing.Size(36, 39);
            this.lblMachinesNeedsService.TabIndex = 6;
            this.lblMachinesNeedsService.Text = "4";
            // 
            // lblTitleMachinesNeedsService
            // 
            this.lblTitleMachinesNeedsService.AutoSize = true;
            this.lblTitleMachinesNeedsService.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMachinesNeedsService.Location = new System.Drawing.Point(19, 17);
            this.lblTitleMachinesNeedsService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleMachinesNeedsService.Name = "lblTitleMachinesNeedsService";
            this.lblTitleMachinesNeedsService.Size = new System.Drawing.Size(222, 28);
            this.lblTitleMachinesNeedsService.TabIndex = 6;
            this.lblTitleMachinesNeedsService.Text = "Machines Needs Service";
            // 
            // pnlMachinesNotActive
            // 
            this.pnlMachinesNotActive.BackColor = System.Drawing.Color.White;
            this.pnlMachinesNotActive.Controls.Add(this.pictureBox4);
            this.pnlMachinesNotActive.Controls.Add(this.lblMachinesNotActive);
            this.pnlMachinesNotActive.Controls.Add(this.lblTitleMachinesNotActive);
            this.pnlMachinesNotActive.Location = new System.Drawing.Point(393, 619);
            this.pnlMachinesNotActive.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMachinesNotActive.Name = "pnlMachinesNotActive";
            this.pnlMachinesNotActive.Size = new System.Drawing.Size(312, 122);
            this.pnlMachinesNotActive.TabIndex = 25;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Image = global::B4_Plastics_SMS.Properties.Resources.Dot_Yellow;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(24, 73);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 15);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // lblMachinesNotActive
            // 
            this.lblMachinesNotActive.AutoSize = true;
            this.lblMachinesNotActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachinesNotActive.Location = new System.Drawing.Point(52, 57);
            this.lblMachinesNotActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMachinesNotActive.Name = "lblMachinesNotActive";
            this.lblMachinesNotActive.Size = new System.Drawing.Size(36, 39);
            this.lblMachinesNotActive.TabIndex = 6;
            this.lblMachinesNotActive.Text = "4";
            // 
            // lblTitleMachinesNotActive
            // 
            this.lblTitleMachinesNotActive.AutoSize = true;
            this.lblTitleMachinesNotActive.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMachinesNotActive.Location = new System.Drawing.Point(19, 17);
            this.lblTitleMachinesNotActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleMachinesNotActive.Name = "lblTitleMachinesNotActive";
            this.lblTitleMachinesNotActive.Size = new System.Drawing.Size(192, 28);
            this.lblTitleMachinesNotActive.TabIndex = 6;
            this.lblTitleMachinesNotActive.Text = "Machines Not Active";
            // 
            // pnlMachinesActive
            // 
            this.pnlMachinesActive.BackColor = System.Drawing.Color.White;
            this.pnlMachinesActive.Controls.Add(this.pictureBox3);
            this.pnlMachinesActive.Controls.Add(this.lblMachinesActive);
            this.pnlMachinesActive.Controls.Add(this.lblTitleMachinesActive);
            this.pnlMachinesActive.Location = new System.Drawing.Point(57, 619);
            this.pnlMachinesActive.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMachinesActive.Name = "pnlMachinesActive";
            this.pnlMachinesActive.Size = new System.Drawing.Size(312, 122);
            this.pnlMachinesActive.TabIndex = 26;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::B4_Plastics_SMS.Properties.Resources.Dot_Green;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(24, 73);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // lblMachinesActive
            // 
            this.lblMachinesActive.AutoSize = true;
            this.lblMachinesActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachinesActive.Location = new System.Drawing.Point(52, 57);
            this.lblMachinesActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMachinesActive.Name = "lblMachinesActive";
            this.lblMachinesActive.Size = new System.Drawing.Size(36, 39);
            this.lblMachinesActive.TabIndex = 6;
            this.lblMachinesActive.Text = "4";
            // 
            // lblTitleMachinesActive
            // 
            this.lblTitleMachinesActive.AutoSize = true;
            this.lblTitleMachinesActive.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMachinesActive.Location = new System.Drawing.Point(19, 17);
            this.lblTitleMachinesActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleMachinesActive.Name = "lblTitleMachinesActive";
            this.lblTitleMachinesActive.Size = new System.Drawing.Size(153, 28);
            this.lblTitleMachinesActive.TabIndex = 6;
            this.lblTitleMachinesActive.Text = "Machines Active";
            // 
            // pnlTransactionsCompleted
            // 
            this.pnlTransactionsCompleted.BackColor = System.Drawing.Color.White;
            this.pnlTransactionsCompleted.Controls.Add(this.pictureBox2);
            this.pnlTransactionsCompleted.Controls.Add(this.lblTransactionsCompleted);
            this.pnlTransactionsCompleted.Controls.Add(this.lblTitleTransactionsCompleted);
            this.pnlTransactionsCompleted.Location = new System.Drawing.Point(393, 77);
            this.pnlTransactionsCompleted.Margin = new System.Windows.Forms.Padding(5);
            this.pnlTransactionsCompleted.Name = "pnlTransactionsCompleted";
            this.pnlTransactionsCompleted.Size = new System.Drawing.Size(312, 122);
            this.pnlTransactionsCompleted.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::B4_Plastics_SMS.Properties.Resources.Dot_Green;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(24, 73);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // lblTransactionsCompleted
            // 
            this.lblTransactionsCompleted.AutoSize = true;
            this.lblTransactionsCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionsCompleted.Location = new System.Drawing.Point(52, 57);
            this.lblTransactionsCompleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionsCompleted.Name = "lblTransactionsCompleted";
            this.lblTransactionsCompleted.Size = new System.Drawing.Size(36, 39);
            this.lblTransactionsCompleted.TabIndex = 6;
            this.lblTransactionsCompleted.Text = "3";
            // 
            // lblTitleTransactionsCompleted
            // 
            this.lblTitleTransactionsCompleted.AutoSize = true;
            this.lblTitleTransactionsCompleted.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTransactionsCompleted.Location = new System.Drawing.Point(19, 17);
            this.lblTitleTransactionsCompleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleTransactionsCompleted.Name = "lblTitleTransactionsCompleted";
            this.lblTitleTransactionsCompleted.Size = new System.Drawing.Size(220, 28);
            this.lblTitleTransactionsCompleted.TabIndex = 6;
            this.lblTitleTransactionsCompleted.Text = "Transactions Completed";
            // 
            // pnlTransactionsActive
            // 
            this.pnlTransactionsActive.BackColor = System.Drawing.Color.White;
            this.pnlTransactionsActive.Controls.Add(this.pictureBox1);
            this.pnlTransactionsActive.Controls.Add(this.lblTransactionsActive);
            this.pnlTransactionsActive.Controls.Add(this.lblTitleTransactionsActive);
            this.pnlTransactionsActive.Location = new System.Drawing.Point(57, 77);
            this.pnlTransactionsActive.Margin = new System.Windows.Forms.Padding(5);
            this.pnlTransactionsActive.Name = "pnlTransactionsActive";
            this.pnlTransactionsActive.Size = new System.Drawing.Size(312, 122);
            this.pnlTransactionsActive.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::B4_Plastics_SMS.Properties.Resources.Dot_Blue;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(24, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblTransactionsActive
            // 
            this.lblTransactionsActive.AutoSize = true;
            this.lblTransactionsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionsActive.Location = new System.Drawing.Point(52, 57);
            this.lblTransactionsActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionsActive.Name = "lblTransactionsActive";
            this.lblTransactionsActive.Size = new System.Drawing.Size(55, 39);
            this.lblTransactionsActive.TabIndex = 6;
            this.lblTransactionsActive.Text = "17";
            // 
            // lblTitleTransactionsActive
            // 
            this.lblTitleTransactionsActive.AutoSize = true;
            this.lblTitleTransactionsActive.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTransactionsActive.Location = new System.Drawing.Point(19, 17);
            this.lblTitleTransactionsActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleTransactionsActive.Name = "lblTitleTransactionsActive";
            this.lblTitleTransactionsActive.Size = new System.Drawing.Size(177, 28);
            this.lblTitleTransactionsActive.TabIndex = 6;
            this.lblTitleTransactionsActive.Text = "Transactions Active";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 786);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnOkCustomDate);
            this.Controls.Add(this.btnCustomDate);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.btnLast30Days);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.chartTransactionsVSDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlMachinesNeedsService);
            this.Controls.Add(this.pnlMachinesNotActive);
            this.Controls.Add(this.pnlMachinesActive);
            this.Controls.Add(this.pnlTransactionsCompleted);
            this.Controls.Add(this.pnlTransactionsActive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTransactionsVSDate)).EndInit();
            this.pnlMachinesNeedsService.ResumeLayout(false);
            this.pnlMachinesNeedsService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlMachinesNotActive.ResumeLayout(false);
            this.pnlMachinesNotActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlMachinesActive.ResumeLayout(false);
            this.pnlMachinesActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlTransactionsCompleted.ResumeLayout(false);
            this.pnlTransactionsCompleted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlTransactionsActive.ResumeLayout(false);
            this.pnlTransactionsActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvUnderstock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnOkCustomDate;
        private System.Windows.Forms.Button btnCustomDate;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnLast30Days;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTransactionsVSDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMachinesNeedsService;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblMachinesNeedsService;
        private System.Windows.Forms.Label lblTitleMachinesNeedsService;
        private System.Windows.Forms.Panel pnlMachinesNotActive;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblMachinesNotActive;
        private System.Windows.Forms.Label lblTitleMachinesNotActive;
        private System.Windows.Forms.Panel pnlMachinesActive;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblMachinesActive;
        private System.Windows.Forms.Label lblTitleMachinesActive;
        private System.Windows.Forms.Panel pnlTransactionsCompleted;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTransactionsCompleted;
        private System.Windows.Forms.Label lblTitleTransactionsCompleted;
        private System.Windows.Forms.Panel pnlTransactionsActive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTransactionsActive;
        private System.Windows.Forms.Label lblTitleTransactionsActive;
    }
}