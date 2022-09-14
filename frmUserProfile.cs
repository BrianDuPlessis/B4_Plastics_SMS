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
        // Fields
        private int staff_id;

        public frmUserProfile()
        {
            InitializeComponent();

            // User profile
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

                            staff_id = Convert.ToInt32(DataReader.GetValue(0).ToString());
                            txtEmail.Text = DataReader.GetValue(1).ToString();
                            txtFirstName.Text = DataReader.GetValue(2).ToString();
                            txtLastName.Text = DataReader.GetValue(3).ToString();
                            txtContactNumber.Text = DataReader.GetValue(4).ToString();

                            lblUsername.Text = DataReader.GetValue(2).ToString() + " " + DataReader.GetValue(3).ToString();
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
                if (int.TryParse(txtContactNumber.Text,out int cell) && txtContactNumber.Text.Length == 10)
                {
                    try
                    {
                        using (var connection = DatabaseL.GetConnection())
                        {
                            connection.Open();
                            string fillBoxSql = $@"UPDATE Staff 
                                                   SET  staff_email = '{txtEmail.Text}', staff_name = '{txtFirstName.Text}', staff_lastname = '{txtLastName.Text}', staff_cell = '{txtContactNumber.Text}' 
                                                   WHERE {staff_id} = staff_id AND NOT EXISTS (
                                                   SELECT staff_email FROM staff WHERE {staff_id} != staff_id)";

                            using (var command = new SqlCommand(fillBoxSql, connection))
                            {
                                command.ExecuteNonQuery();
                            }

                        }
                        string new_email = txtEmail.Text;
                        // Reload User profile
                        Fill_Controls();

                        if (new_email == txtEmail.Text)
                        {
                            MessageBox.Show("Your profile is updated.", "Successful update.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Your profile is not updated, the email is already being used.", "Unsuccessful update.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter only numbers for your contact number of lenght 10.", "Invalid input.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter your detials in all the textboxes.","Empty Textbox.",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
