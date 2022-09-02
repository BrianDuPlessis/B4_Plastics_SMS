using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B4_Plastics_SMS
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            pnlNav.Height = btnUserInfoPage.Height;
            pnlNav.Top = btnUserInfoPage.Top;
            pnlNav.Left = btnUserInfoPage.Left;
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
            btnContactUs.BackColor = Color.FromArgb(37, 45, 55);

            pnlNav.Height = btnClicked.Height;
            pnlNav.Top = btnClicked.Top;
            pnlNav.Left = btnClicked.Left;
            btnClicked.BackColor = Color.FromArgb(46, 51, 73);
            //-------------------------------------------------------------
        }

        private void btnUserInfoPage_Click(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------
        }

        private void btnEmployeesPage_Click(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------
        }

        private void btnStockPage_Click(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------
        }

        private void btnTransactionsPage_Click(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------
        }

        private void btnMachinePage_Click(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------
        }

        private void btnReportsPage_Click(object sender, EventArgs e)
        {
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------
        }
    }
}
