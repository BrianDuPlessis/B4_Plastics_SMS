using DashboardApp.Models;
using DatabaseLogin.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B4_Plastics_SMS
{
    public partial class frmAdmin : Form
    {
        // Forms Fiels
        private Size formSize;
        private int borderSize = 2;

        frmLogin myLogin = new frmLogin();
        AdminDashboard myDashboard = new AdminDashboard();
        frmUserProfile myUserProfile;
        Staff myStaff = new Staff();
        Stock myStock = new Stock();
        TransactLoad myTransaction = new TransactLoad();
        Machines myMachine = new Machines();
        Reports myReport = new Reports();
        DispatchQuantity myDispatch = new DispatchQuantity();

        // Border Fields
        bool mouseDown;
        private Point offset;

        // Constructor
        public frmAdmin()
        {
            InitializeComponent();
            // Form Settings
            this.Padding = new Padding(borderSize);

            // User profile
            lblUserName.Text = DatabaseL.Username;
            pnlContainerUserProfile.Hide();

            // Load Date
            lblDate.Text = DateTime.Today.ToShortDateString();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {


            // Button Visuals
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
                btnDispatch.BackColor = Color.FromArgb(37, 45, 55);

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

        private void pnlContainerUserProfile_ControlRemoved(object sender, ControlEventArgs e)
        {
            pnlContainerUserProfile.Hide();
            pnlContainer.Enabled = true;
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            lblHeading.Text = "Dashboard";
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------

            // Medthod for changing form
            myDashboard.Close();

            myDashboard = new AdminDashboard();
            ButtonFormChage(myDashboard);

        }

        private void btnEmployeesPage_Click(object sender, EventArgs e)
        {
            lblHeading.Text = "Staff";
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------

            // Medthod for changing form
            ButtonFormChage(myStaff);

        }

        private void btnStockPage_Click(object sender, EventArgs e)
        {
            lblHeading.Text = "Stock";
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------

            // Medthod for changing form
            ButtonFormChage(myStock);

        }

        private void btnTransactionsPage_Click(object sender, EventArgs e)
        {
            lblHeading.Text = "Transactions";
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------

            // Medthod for changing form
            ButtonFormChage(myTransaction);

        }

        private void btnMachinePage_Click(object sender, EventArgs e)
        {
            lblHeading.Text = "Machines";
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------

            // Medthod for changing form
            ButtonFormChage(myMachine);

        }

        private void btnReportsPage_Click(object sender, EventArgs e)
        {
            lblHeading.Text = "Reports";
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------

            // Medthod for changing form
            ButtonFormChage(myReport);

        }

        private void btnDispatch_Click(object sender, EventArgs e)
        {
            lblHeading.Text = "Dispatch";
            // Colour Effects for clicking on button 
            ButtonColourEffect(sender as Button);
            //------------------------------------

            // Medthod for changing form
            ButtonFormChage(myDispatch);
        }

        private void linkLabelEmail_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "mailto:contact@b4plastics.com");
        }

        private void pnlUserInfo_Click_1(object sender, EventArgs e)
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

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            this.pnlUserInfo_Click_1(sender, e);
        }

        private void lblUserName_Click_1(object sender, EventArgs e)
        {
            this.pnlUserInfo_Click_1(sender, e);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Drag Form

        private void pnlBorder_MouseDown_1(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void pnlBorder_MouseUp_1(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pnlBorder_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }
        #endregion
        
        #region Resize Form
        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right


            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

           /* //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }*/

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        #endregion
        
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            myLogin.Show();
        }

        
    }



}



