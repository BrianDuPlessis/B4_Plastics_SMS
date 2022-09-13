
namespace B4_Plastics_SMS
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.lblHeading = new System.Windows.Forms.Label();
            this.pnlContainerUserProfile = new System.Windows.Forms.Panel();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabelEmail = new System.Windows.Forms.LinkLabel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnReportsPage = new System.Windows.Forms.Button();
            this.btnMachinePage = new System.Windows.Forms.Button();
            this.btnTransactionsPage = new System.Windows.Forms.Button();
            this.btnStockPage = new System.Windows.Forms.Button();
            this.btnEmployeesPage = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Nirmala UI Semilight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(300, 9);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(168, 41);
            this.lblHeading.TabIndex = 13;
            this.lblHeading.Text = "Dashboard";
            this.lblHeading.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBorder_MouseDown_1);
            this.lblHeading.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBorder_MouseMove_1);
            this.lblHeading.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBorder_MouseUp_1);
            // 
            // pnlContainerUserProfile
            // 
            this.pnlContainerUserProfile.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContainerUserProfile.Location = new System.Drawing.Point(307, 146);
            this.pnlContainerUserProfile.Name = "pnlContainerUserProfile";
            this.pnlContainerUserProfile.Size = new System.Drawing.Size(974, 467);
            this.pnlContainerUserProfile.TabIndex = 15;
            this.pnlContainerUserProfile.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnlContainerUserProfile_ControlRemoved);
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.pnlBorder.Controls.Add(this.btnMinimize);
            this.pnlBorder.Controls.Add(this.btnExit);
            this.pnlBorder.Controls.Add(this.pictureBox1);
            this.pnlBorder.Controls.Add(this.lblHeading);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(1538, 53);
            this.pnlBorder.TabIndex = 16;
            this.pnlBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBorder_MouseDown_1);
            this.pnlBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBorder_MouseMove_1);
            this.pnlBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBorder_MouseUp_1);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(141)))), ((int)(((byte)(162)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Roboto", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1416, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(61, 53);
            this.btnMinimize.TabIndex = 29;
            this.btnMinimize.Text = "━";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(64)))), ((int)(((byte)(75)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1477, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 53);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.pictureBox1.Image = global::B4_Plastics_SMS.Properties.Resources.Logo_Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBorder_MouseDown_1);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBorder_MouseMove_1);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBorder_MouseUp_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.linkLabelEmail);
            this.panel3.Controls.Add(this.pnlNav);
            this.panel3.Controls.Add(this.btnReportsPage);
            this.panel3.Controls.Add(this.btnMachinePage);
            this.panel3.Controls.Add(this.btnTransactionsPage);
            this.panel3.Controls.Add(this.btnStockPage);
            this.panel3.Controls.Add(this.btnEmployeesPage);
            this.panel3.Controls.Add(this.btnDashboard);
            this.panel3.Controls.Add(this.pnlUserInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 847);
            this.panel3.TabIndex = 17;
            // 
            // linkLabelEmail
            // 
            this.linkLabelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabelEmail.AutoSize = true;
            this.linkLabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelEmail.LinkColor = System.Drawing.Color.Cyan;
            this.linkLabelEmail.Location = new System.Drawing.Point(23, 806);
            this.linkLabelEmail.Name = "linkLabelEmail";
            this.linkLabelEmail.Size = new System.Drawing.Size(193, 20);
            this.linkLabelEmail.TabIndex = 15;
            this.linkLabelEmail.TabStop = true;
            this.linkLabelEmail.Tag = "mailto:contact@b4plastics.com";
            this.linkLabelEmail.Text = "contact@b4plastics.com";
            this.linkLabelEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEmail_LinkClicked_1);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 91);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(5);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(5, 151);
            this.pnlNav.TabIndex = 0;
            // 
            // btnReportsPage
            // 
            this.btnReportsPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportsPage.FlatAppearance.BorderSize = 0;
            this.btnReportsPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportsPage.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportsPage.ForeColor = System.Drawing.Color.White;
            this.btnReportsPage.Image = global::B4_Plastics_SMS.Properties.Resources.Reports_B;
            this.btnReportsPage.Location = new System.Drawing.Point(0, 414);
            this.btnReportsPage.Margin = new System.Windows.Forms.Padding(5);
            this.btnReportsPage.Name = "btnReportsPage";
            this.btnReportsPage.Size = new System.Drawing.Size(250, 64);
            this.btnReportsPage.TabIndex = 13;
            this.btnReportsPage.Text = "  Reports page     ";
            this.btnReportsPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportsPage.UseVisualStyleBackColor = true;
            this.btnReportsPage.Click += new System.EventHandler(this.btnReportsPage_Click);
            // 
            // btnMachinePage
            // 
            this.btnMachinePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMachinePage.FlatAppearance.BorderSize = 0;
            this.btnMachinePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMachinePage.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachinePage.ForeColor = System.Drawing.Color.White;
            this.btnMachinePage.Image = global::B4_Plastics_SMS.Properties.Resources.Machines_B;
            this.btnMachinePage.Location = new System.Drawing.Point(0, 349);
            this.btnMachinePage.Margin = new System.Windows.Forms.Padding(5);
            this.btnMachinePage.Name = "btnMachinePage";
            this.btnMachinePage.Size = new System.Drawing.Size(250, 65);
            this.btnMachinePage.TabIndex = 12;
            this.btnMachinePage.Text = "  Machine page     ";
            this.btnMachinePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMachinePage.UseVisualStyleBackColor = true;
            this.btnMachinePage.Click += new System.EventHandler(this.btnMachinePage_Click);
            // 
            // btnTransactionsPage
            // 
            this.btnTransactionsPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionsPage.FlatAppearance.BorderSize = 0;
            this.btnTransactionsPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionsPage.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionsPage.ForeColor = System.Drawing.Color.White;
            this.btnTransactionsPage.Image = global::B4_Plastics_SMS.Properties.Resources.Transactions_B;
            this.btnTransactionsPage.Location = new System.Drawing.Point(0, 284);
            this.btnTransactionsPage.Margin = new System.Windows.Forms.Padding(5);
            this.btnTransactionsPage.Name = "btnTransactionsPage";
            this.btnTransactionsPage.Size = new System.Drawing.Size(250, 65);
            this.btnTransactionsPage.TabIndex = 11;
            this.btnTransactionsPage.Text = "  Transactions page";
            this.btnTransactionsPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransactionsPage.UseVisualStyleBackColor = true;
            this.btnTransactionsPage.Click += new System.EventHandler(this.btnTransactionsPage_Click);
            // 
            // btnStockPage
            // 
            this.btnStockPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStockPage.FlatAppearance.BorderSize = 0;
            this.btnStockPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockPage.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockPage.ForeColor = System.Drawing.Color.White;
            this.btnStockPage.Image = global::B4_Plastics_SMS.Properties.Resources.Stock_B;
            this.btnStockPage.Location = new System.Drawing.Point(0, 220);
            this.btnStockPage.Margin = new System.Windows.Forms.Padding(5);
            this.btnStockPage.Name = "btnStockPage";
            this.btnStockPage.Size = new System.Drawing.Size(250, 64);
            this.btnStockPage.TabIndex = 9;
            this.btnStockPage.Text = "   Stock page        ";
            this.btnStockPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockPage.UseVisualStyleBackColor = true;
            this.btnStockPage.Click += new System.EventHandler(this.btnStockPage_Click);
            // 
            // btnEmployeesPage
            // 
            this.btnEmployeesPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeesPage.FlatAppearance.BorderSize = 0;
            this.btnEmployeesPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeesPage.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeesPage.ForeColor = System.Drawing.Color.White;
            this.btnEmployeesPage.Image = global::B4_Plastics_SMS.Properties.Resources.Employees_B;
            this.btnEmployeesPage.Location = new System.Drawing.Point(0, 156);
            this.btnEmployeesPage.Margin = new System.Windows.Forms.Padding(5);
            this.btnEmployeesPage.Name = "btnEmployeesPage";
            this.btnEmployeesPage.Size = new System.Drawing.Size(250, 64);
            this.btnEmployeesPage.TabIndex = 8;
            this.btnEmployeesPage.Text = "     Staff page           ";
            this.btnEmployeesPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeesPage.UseVisualStyleBackColor = true;
            this.btnEmployeesPage.Click += new System.EventHandler(this.btnEmployeesPage_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::B4_Plastics_SMS.Properties.Resources.home_Resize;
            this.btnDashboard.Location = new System.Drawing.Point(0, 91);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(250, 65);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "  Dashboard     ";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Controls.Add(this.lblUserName);
            this.pnlUserInfo.Controls.Add(this.pictureBox7);
            this.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlUserInfo.Margin = new System.Windows.Forms.Padding(5);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(250, 91);
            this.pnlUserInfo.TabIndex = 0;
            this.pnlUserInfo.Click += new System.EventHandler(this.pnlUserInfo_Click_1);
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.lblUserName.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(80, 16);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(125, 47);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Welcome, ...";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click_1);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::B4_Plastics_SMS.Properties.Resources.User_Blue;
            this.pictureBox7.Location = new System.Drawing.Point(27, 22);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(39, 41);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click_1);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContainer.Location = new System.Drawing.Point(251, 55);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(3);
            this.pnlContainer.Size = new System.Drawing.Size(1271, 824);
            this.pnlContainer.TabIndex = 15;
            this.pnlContainer.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnlContainerUserProfile_ControlRemoved);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1538, 900);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlBorder);
            this.Controls.Add(this.pnlContainerUserProfile);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "frmAdmin";
            this.Text = "B4 Plastics - Admin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel pnlContainerUserProfile;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabelEmail;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnReportsPage;
        private System.Windows.Forms.Button btnMachinePage;
        private System.Windows.Forms.Button btnTransactionsPage;
        private System.Windows.Forms.Button btnStockPage;
        private System.Windows.Forms.Button btnEmployeesPage;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlContainer;
    }
}