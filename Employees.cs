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
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            txtIPassword.PasswordChar = '*';
            txtIPassword.MaxLength = 14;

            txtIREPassword.PasswordChar = '*';
            txtIREPassword.MaxLength = 14;
        }
    }
}
