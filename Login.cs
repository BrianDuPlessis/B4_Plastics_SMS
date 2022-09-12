using DatabaseLogin.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B4_Plastics_SMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private List<string> emails = new List<string>();
        private List<string> pass = new List<string>();

        

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            txtPassword.PasswordChar = '*';

            // Remember me, checkbox Properties
            if (Properties.Settings.Default.Password != string.Empty)
            {
                txtEmail.Text = Properties.Settings.Default.Email;
                txtPassword.Text = Properties.Settings.Default.Password;
                chRemember.Checked = Properties.Settings.Default.Checkbox;

            }
            else
            {
                txtEmail.Clear();
                txtPassword.Clear();
                txtEmail.Focus();
            }
            //------------------------------------------------------------

            
            // Load emails and passwords from textfile
            StreamReader stream = new StreamReader("Account.txt");
            string line = "";

            while ((line = stream.ReadLine()) != null)
            {
                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                emails.Add(components[0]);
                pass.Add(components[1]);
            }
            //--------------------------------------------------------------
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text,
                   password = txtPassword.Text;

            
            DatabaseL.UserEmail = email;
            DatabaseL.Type = DatabaseL.GetTypeStaff(email);
            DatabaseL.Username = DatabaseL.GetName(email);

            string userType = DatabaseL.Type;


            frmAdmin myAdminForm = new frmAdmin();
            Dispatch myDispatchForm = new Dispatch();
            Employee myEmployeeForm = new Employee();

            // Load Properties

            if (chRemember.Checked)
            {
                Properties.Settings.Default.Email = email;
                Properties.Settings.Default.Password = password;
                Properties.Settings.Default.Checkbox = true;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.Email = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Checkbox = false;
                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.Email == string.Empty)
            {
                txtEmail.Clear();
                txtPassword.Clear();
                txtEmail.Focus();
            }

            //--------------------------------------------------


            // Default Login
            if (email == "Admin" && password == "Admin")
            {
                this.Hide();
                myAdminForm.Show();
            }
            else if (email == "Employee" && password == "Employee")
            {
                this.Hide();
                myEmployeeForm.Show();
            }
            else if (email == "Dispatch" && password == "Dispatch")
            {
                this.Hide();
                myDispatchForm.Show();
            }
            //----------------------------------------------
            // Check Login from text file
            else if (userType == "Admin" && emails.Contains(email) && pass.Contains(password))
            {
                this.Hide();
                myAdminForm.Show();
            }
            else if (userType == "Employee" && emails.Contains(email) && pass.Contains(password))
            {
                this.Hide();
                myEmployeeForm.Show();
            }
            else if (userType == "Dispatch" && emails.Contains(email) && pass.Contains(password))
            {
                this.Hide();
                myDispatchForm.Show(); 
            }
            else
            {
                MessageBox.Show("The Email or Password is incorrect, please try again!", "Incorrect Details.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Clear();
                txtPassword.Clear();
                txtEmail.Focus();
            }

            //---------------------------------------------------
            
        }


        private void lblForgetPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
