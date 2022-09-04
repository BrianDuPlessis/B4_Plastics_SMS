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

            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();

            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 14;
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = "",
                   Password = "";

            bool Remember_Me = false;
        }
    }
}
