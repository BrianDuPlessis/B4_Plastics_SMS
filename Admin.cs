using DashboardApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B4_Plastics_SMS
{
    public partial class frmAdmin : Form
    {
        //Fields
        private Dashboard model;

        // Constructor
        public frmAdmin()
        {
            InitializeComponent();

            //Default - Last 7 days
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();

            model = new Dashboard();
            LoadData();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }
        
        // Medthod for moving navigation panel and colour effect on button clicked
        public void ButtonColourEffect(Button btnClicked)
        {
            // Colour Effects for clicking on button 
            btnUserInfoPage.BackColor = Color.FromArgb(37, 45, 55);
            btnEmployeesPage.BackColor = Color.FromArgb(37, 45, 55);
            btnStockPage.BackColor = Color.FromArgb(37, 45, 55);
            btnTransactionsPage.BackColor = Color.FromArgb(37, 45, 55);
            btnMachinePage.BackColor = Color.FromArgb(37, 45, 55);
            btnReportsPage.BackColor = Color.FromArgb(37, 45, 55);
            btnDashboard.BackColor = Color.FromArgb(37, 45, 55);

            pnlNav.Height = btnClicked.Height;
            pnlNav.Top = btnClicked.Top;
            pnlNav.Left = btnClicked.Left;
            btnClicked.BackColor = Color.FromArgb(46, 51, 73);
            //-------------------------------------------------------------
        }

        private void btnUserInfoPage_Click_1(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------
        }

        private void btnEmployeesPage_Click_1(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------
        }

        private void btnStockPage_Click_1(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------
        }

        private void btnTransactionsPage_Click_1(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------
        }

        private void btnMachinePage_Click_1(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------
        }

        private void btnReportsPage_Click_1(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------
        }

        private void linkLabelEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "mailto:contact@b4plastics.com");
        }

        
        //Private methods
        private void LoadData()
        {
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
                lblTransactionsActive.Text = model.NumActiveTransactions.ToString();
                lblTransactionsCompleted.Text = model.NumCompletedTransactions.ToString();

                lblMachinesActive.Text = model.ActiceMachines.ToString();
                lblMachinesNeedsService.Text = model.ServicesMachines.ToString();
                lblMachinesNotActive.Text = model.NotActiveMachines.ToString();

                
                chartTransactionsVSDate.Series[0].XValueMember = "Date";
                chartTransactionsVSDate.Series[0].YValueMembers = "TotalAmount";

                chartTransactionsVSDate.DataSource = model.TransactionQuantityList;
                chartTransactionsVSDate.DataBind();

                dgvUnderstock.DataSource = model.UnderstockList;
                dgvUnderstock.Columns[0].HeaderText = "Item";
                dgvUnderstock.Columns[1].HeaderText = "Units";
                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("View not loaded, same query");
        }
        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOkCustomDate.Visible = false;
        }

        //Event methods
        private void btnToday_Click_1(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLast7Days_Click_1(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLast30Days_Click_1(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnThisMonth_Click_1(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOkCustomDate.Visible = true;
        }

        private void btnOkCustomDate_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
