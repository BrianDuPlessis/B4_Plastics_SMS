using DatabaseLogin.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace B4_Plastics_SMS
{
    public partial class frmUserProfile : Form
    {


        public frmUserProfile()
        {
            InitializeComponent();

            // User profile
            lblUsername.Text = DatabaseL.Username;
            Fill_Controls();


        }

        private void Fill_Controls()
        {
            string email = DatabaseL.UserEmail;
            if (email == "Admin")
            {
                txtEmail.Text = "Admin@gmail.com";
                txtFirstName.Text = "Admin";
                txtLastName.Text = "Admin";
                txtContactNumber.Text = "0812547852";
                btnUpdate.Hide();
            }
            else
            {
                try
                {
                    using (var connection = DatabaseL.GetConnection())
                    {
                        connection.Open();
                        string fillBoxSql = $"SELECT * FROM Staff WHERE '{email}' = staff_email";
                        using (var command = new SqlCommand(fillBoxSql, connection))
                        {
                            SqlDataReader DataReader = command.ExecuteReader();

                            DataReader.Read();

                            txtEmail.Text = DataReader.GetValue(1).ToString();
                            txtFirstName.Text = DataReader.GetValue(2).ToString();
                            txtLastName.Text = DataReader.GetValue(3).ToString();
                            txtContactNumber.Text = DataReader.GetValue(4).ToString();
                        }

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtEmail.Text != "" && txtContactNumber.Text != "")
            {
                
            }
            else
            {
                MessageBox.Show("Please enter all the filds");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
