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
    public partial class DispatchQuantity : Form
    {
        public DispatchQuantity()
        {
            InitializeComponent();
        }

        private void DispatchQuantity_Load(object sender, EventArgs e)
        {
            Fill_Combpbox();
        }

        private int Get_Staff_id()
        {

            string email = DatabaseL.UserEmail;

            if (email == "Employee" || email == "Dispatch")
            {
            }
            else
            {
                try
                {
                    using (var connection = DatabaseL.GetConnection())
                    {
                        connection.Open();
                        string fillBoxSql = $"SELECT * FROM Staff WHERE staff_email = '{email}'";
                        using (var command = new SqlCommand(fillBoxSql, connection))
                        {
                            SqlDataReader DataReader = command.ExecuteReader();

                            DataReader.Read();

                            return (Convert.ToInt32(DataReader.GetValue(0).ToString()));
                        }

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return 4;
        }

        private void Fill_Combpbox()
        {

            string email = DatabaseL.UserEmail;

            
                try
                {
                    using (var connection = DatabaseL.GetConnection())
                    {
                        connection.Open();
                        string fillBoxSql = $"SELECT d.dispatch_id, d.dispatch_quantity FROM Dispatch AS d LEFT JOIN [Transactions] AS t ON d.dispatch_id = t.dispatch_id WHERE d.staff_id = {Get_Staff_id()} AND t.isCompleted = 0";
                        using (var command = new SqlCommand(fillBoxSql, connection))
                        {
                            SqlDataReader DataReader = command.ExecuteReader();

                             while (DataReader.Read())
                             {
                                cbUpdateDispatchID.Items.Add(DataReader.GetValue(0).ToString());
                             }

                            
                        }

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
            
        }

        private void cbUpdateDispatchID_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                using (var connection = DatabaseL.GetConnection())
                {
                    connection.Open();
                    string fillBoxSql = $"SELECT dispatch_quantity FROM Dispatch WHERE dispatch_id = {cbUpdateDispatchID.SelectedItem}";
                    using (var command = new SqlCommand(fillBoxSql, connection))
                    {
                        SqlDataReader DataReader = command.ExecuteReader();

                        DataReader.Read();

                        txtQuantity.Text = DataReader.GetValue(0).ToString();
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int quantity))
            {
                try
                {
                    using (var connection = DatabaseL.GetConnection())
                    {
                        connection.Open();
                        string fillBoxSql = $"UPDATE Dispatch SET dispatch_quantity = {quantity} WHERE dispatch_id = {cbUpdateDispatchID.SelectedItem}";
                        using (var command = new SqlCommand(fillBoxSql, connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Quantity updated.", "Successfully updated.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Please enter a number.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
