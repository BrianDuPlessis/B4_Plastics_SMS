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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            if (Properties.Settings.Default.Email != string.Empty)
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
            

            txtPassword.PasswordChar = '*';
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text,
                   password = txtPassword.Text;

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

            frmLogin myLogin = new frmLogin();
            myLogin.Hide();

            if (Properties.Settings.Default.Email == string.Empty)
            {
                txtEmail.Clear();
                txtPassword.Clear();
                txtEmail.Focus();
            }

            frmAdmin myAdminForm = new frmAdmin();
            myAdminForm.Show();


            

        }
    }
}
