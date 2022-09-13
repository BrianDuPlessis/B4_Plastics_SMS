using DashboardApp.Models;
using DatabaseLogin.Class;
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
        // Forms
        frmLogin myLogin = new frmLogin();
        AdminDashboard myDashboard = new AdminDashboard();
        frmUserProfile myUserProfile;
        Staff myStaff = new Staff();
        Stock myStock = new Stock();
        TransactLoad myTransaction = new TransactLoad();
        Machines myMachine = new Machines();
        Reports myReport = new Reports();

        // Constructor
        public frmAdmin()
        {
            InitializeComponent();

            // User profile
            lblUserName.Text = DatabaseL.Username;
            pnlContainerUserProfile.Hide();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            // Medthod for changing form
            ButtonFormChage(myDashboard);
        }
        
        // Medthod for moving navigation panel and colour effect on button clicked
        public void ButtonColourEffect(Button btnClicked)
        {
            if (btnClicked != null)
            {
                // Colour Effects for clicking on button 
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
        }

        // Medthod for changing form
        public void ButtonFormChage(Form form)
        {
            pnlContainer.Controls.Clear();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            this.pnlContainer.Controls.Add(form);
            form.Show();
        }
        //----------------------------------------------

        private void btnEmployeesPage_Click_1(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------

            // Medthod for changing form
            ButtonFormChage(myStaff);
        }

        private void btnStockPage_Click_1(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------
            
            // Medthod for changing form
            ButtonFormChage(myStock);

        }

        private void btnTransactionsPage_Click_1(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------

            // Medthod for changing form
            ButtonFormChage(myTransaction);
        }

        private void btnMachinePage_Click_1(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------

            // Medthod for changing form
            ButtonFormChage(myMachine);
        }

        private void btnReportsPage_Click_1(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------

            // Medthod for changing form
            ButtonFormChage(myReport);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------

            // Medthod for changing form
            ButtonFormChage(myDashboard);
        }

        private void linkLabelEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "mailto:contact@b4plastics.com");
        }

        private void pnlUserInfo_Click(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------
            myUserProfile = new frmUserProfile();

            pnlContainer.Enabled = false;

            pnlContainerUserProfile.Show();

            pnlContainerUserProfile.Controls.Remove(myUserProfile);
            myUserProfile.TopLevel = false;
            myUserProfile.Dock = DockStyle.Fill;
            this.pnlContainerUserProfile.Controls.Add(myUserProfile);
            myUserProfile.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.pnlUserInfo_Click(sender,e);
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
            this.pnlUserInfo_Click(sender, e);
        }

        private void pnlContainerUserProfile_ControlRemoved(object sender, ControlEventArgs e)
        {
            pnlContainerUserProfile.Hide();
            pnlContainer.Enabled = true;
        }
    }
}
