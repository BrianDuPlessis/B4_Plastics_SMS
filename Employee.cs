﻿using DatabaseLogin.Class;
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
    public partial class Employee: Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            // User profile
            frmLogin myLogin = new frmLogin();
            lblUserName.Text = DatabaseL.Username;
        }
    }
}
