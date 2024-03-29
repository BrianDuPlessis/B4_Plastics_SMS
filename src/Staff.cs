﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using DatabaseLogin.Class;

namespace B4_Plastics_SMS
{
    public partial class Staff : Form
    {
        SqlConnection conn = DatabaseL.GetConnection();
        SqlDataAdapter adapter;
        DataSet dataset;
        SqlCommand command;
        SqlDataReader reader;


        private List<string> emails = new List<string>();
        private List<string> pass = new List<string>();

        private string DisplayAllsql = "SELECT * FROM Staff";

        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            //display data
            displayData(DisplayAllsql);

            //fill comboBox UserType
            cmbUserType.Items.Add("Employee");
            cmbUserType.Items.Add("Dispatch");
            cmbUserType.Items.Add("Admin");
            cmbIUserType.Items.Add("Employee");
            cmbIUserType.Items.Add("Dispatch");
            cmbIUserType.Items.Add("Admin");
            cmbUuserTypes.Items.Add("Employee");
            cmbUuserTypes.Items.Add("Dispatch");
            cmbUuserTypes.Items.Add("Admin");

            Fill_comboboxes();
        }

        private void Fill_comboboxes()
        {
            

            //fill delete comboBox
            string StaffIDSql = "SELECT staff_id FROM Staff";
            try
            {
                conn.Open();
                command = new SqlCommand(StaffIDSql, conn);
                reader = command.ExecuteReader();
                cmbDeleteStaff.Items.Clear();
                while (reader.Read())
                {
                    cmbDeleteStaff.Items.Add(reader.GetValue(0));
                }
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            txtIPassword.PasswordChar = '*';
            txtIREPassword.PasswordChar = '*';

            //cbUpdateSatff, fill comboBox
            string updateIdSql = "SELECT staff_id FROM Staff";
            try
            {
                conn.Open();
                command = new SqlCommand(updateIdSql, conn);
                reader = command.ExecuteReader();
                cbUpdateStaff.Items.Clear();
                while (reader.Read())
                {
                    cbUpdateStaff.Items.Add(reader.GetValue(0));
                }
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void displayData(string sql)
        {
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                adapter = new SqlDataAdapter();
                dataset = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(dataset, "Staff");

                dgvEmployeeDetails.DataSource = dataset;
                dgvEmployeeDetails.DataMember = "Staff";

                dgvEmployeeDetails.Columns[0].HeaderText = "Staff ID";
                dgvEmployeeDetails.Columns[1].HeaderText = "Email";
                dgvEmployeeDetails.Columns[2].HeaderText = "Name";
                dgvEmployeeDetails.Columns[3].HeaderText = "Surname";
                dgvEmployeeDetails.Columns[4].HeaderText = "Cell Number";
                dgvEmployeeDetails.Columns[5].HeaderText = "User Type";


                conn.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtFilterEmail_TextChanged(object sender, EventArgs e)
        {
            txtFilterName.Text = "";
            txtFilterLastName.Text = "";

            string sql = generateFilterSql();
            displayData(sql);
        }

        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            txtFilterEmail.Text = "";
            txtFilterLastName.Text = "";

            string sql = generateFilterSql();
            displayData(sql);
        }

        private void txtFilterLastName_TextChanged(object sender, EventArgs e)
        {
            txtFilterEmail.Text = "";
            txtFilterName.Text = "";

            string sql = generateFilterSql();
            displayData(sql);
        }

        private string generateFilterSql()
        {
            string extraFilter = "", sql = "";
            if (txtFilterEmail.Text != "")
            {
                sql = $"SELECT * FROM Staff WHERE staff_email LIKE '{txtFilterEmail.Text}%'";
            }
            else if (txtFilterName.Text != "")
            {
                sql = $"SELECT * FROM Staff WHERE staff_name LIKE '{txtFilterName.Text}%'";
            }
            else if (txtFilterLastName.Text != "")
            {
                sql = $"SELECT * FROM Staff WHERE staff_lastname LIKE '{txtFilterLastName.Text}%'";
            }
            else
            {
                sql = "SELECT * FROM Staff ";
            }

            if (cmbUserType.SelectedIndex > -1 && sql.Contains("WHERE"))
            {
                extraFilter = $" AND staff_usertype like '{cmbUserType.SelectedItem.ToString()}'";
            }
            else if (cmbUserType.SelectedIndex > -1)
            {
                extraFilter = $" WHERE staff_usertype like '{cmbUserType.SelectedItem.ToString()}'";
            }
           
            return sql + extraFilter;
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = generateFilterSql();
            displayData(sql);
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //display data
            string DisplayAllsql = "SELECT * FROM Staff";
            displayData(DisplayAllsql);

            //Clear filters
            txtFilterEmail.Text = "";
            txtFilterLastName.Text = "";
            txtFilterName.Text = "";
            cmbUserType.SelectedIndex = -1;
        }

        private bool validateStaffRecord()
        {
            bool valid = true;

            txtIEmail.BackColor = SystemColors.Window;
            txtIFirstName.BackColor = SystemColors.Window;
            txtILastName.BackColor = SystemColors.Window;
            txtIContactNumber.BackColor = SystemColors.Window;
            txtIPassword.BackColor = SystemColors.Window;
            txtIREPassword.BackColor = SystemColors.Window;
            cmbIUserType.BackColor = SystemColors.Window;
            if (txtIEmail.Text == "" || !txtIEmail.Text.Contains("@"))
            {
                txtIEmail.Focus();
                txtIEmail.BackColor = Color.Red;
                valid = false;
            }
            if (txtIFirstName.Text == "" || txtIFirstName.Text.Length < 3)
            {
                txtIFirstName.Focus();
                txtIFirstName.BackColor = Color.Red;
                valid = false;
            }
            if (txtILastName.Text == "" || txtILastName.Text.Length < 3)
            {
                txtILastName.Focus();
                txtILastName.BackColor = Color.Red;
                valid = false;
            }
            if (!int.TryParse(txtIContactNumber.Text, out int num) && txtIContactNumber.Text.Length < 10)
            {
                txtIContactNumber.Focus();
                txtIContactNumber.BackColor = Color.Red;
                valid = false;
            }
            if (cmbIUserType.SelectedIndex == -1)
            {
                cmbIUserType.Focus();
                cmbIUserType.BackColor = Color.Red;
                valid = false;
            }
            if (txtIPassword.Text.Length < 5)
            {
                txtIPassword.Focus();
                txtIPassword.BackColor = Color.Red;
                valid = false;
            }
            if (txtIREPassword.Text != txtIPassword.Text || txtIREPassword.Text == "")
            {
                txtIREPassword.Focus();
                txtIREPassword.BackColor = Color.Red;
                valid = false;
            }
            return valid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validateStaffRecord())
            {
                try
                {
                    //Save user password
                    using (StreamWriter sw = File.AppendText("Account.txt"))
                    {
                        sw.WriteLine(txtIEmail.Text + " " + txtIPassword.Text);
                    }

                    //Add record to database
                    conn.Open();
                    string sql = "INSERT INTO Staff(staff_email, staff_name, staff_lastname, staff_cell, staff_usertype) VALUES(@email, @name, @lastname, @cell, @type)";
                    command = new SqlCommand(sql, conn); 
                    command.Parameters.AddWithValue("@email", txtIEmail.Text);
                    command.Parameters.AddWithValue("@name", txtIFirstName.Text);
                    command.Parameters.AddWithValue("@lastname", txtILastName.Text);
                    command.Parameters.AddWithValue("@cell", txtIContactNumber.Text);
                    command.Parameters.AddWithValue("@type", cmbIUserType.SelectedItem.ToString());
                    command.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("New staff member was successfully added");
                    //clear input
                    txtIEmail.Clear();
                    txtIFirstName.Clear();
                    txtILastName.Clear();
                    txtIContactNumber.Clear();
                    txtIPassword.Clear();
                    txtIREPassword.Clear();
                    cmbIUserType.SelectedItem = -1;
                    cmbIUserType.Text = "";

                    Fill_comboboxes();
                    displayData(DisplayAllsql);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid data...");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbDeleteStaff.SelectedIndex != -1)
            {
                if (cbConfirm.Checked)
                {

                    // Load emails and passwords from textfile
                    StreamReader stream = new StreamReader("Account.txt");
                    string line = "";

                    while ((line = stream.ReadLine()) != null)
                    {
                        string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        emails.Add(components[0]);
                        pass.Add(components[1]);
                    }

                    stream.Close();

                    // Get Email
                    using (var connection = DatabaseL.GetConnection())
                    {
                        connection.Open();
                        using (var command = new SqlCommand())
                        {
                            SqlDataReader reader;
                            command.Connection = connection;
                            //Get Type
                            command.CommandText = $"SELECT staff_id, staff_email FROM Staff WHERE staff_id = {cmbDeleteStaff.SelectedItem}";
                            reader = command.ExecuteReader();

                            reader.Read();
                            string email = reader.GetValue(1).ToString();


                            reader.Close();

                            // Delete the old email from the list
                            int index = emails.IndexOf(email);
                            emails.RemoveAt(index);
                            pass.RemoveAt(index);


                            // Create a file to write to
                            StreamWriter file = new System.IO.StreamWriter("Account.txt");

                            for (int k = 0; k < emails.Count(); k++)
                            {
                                file.WriteLine(emails[k] + " " + pass[k]);

                            }

                            file.Close();
                        }
                    }

                    string sql = $"DELETE FROM Staff WHERE staff_id = {cmbDeleteStaff.SelectedItem}";
                    try
                    {
                        conn.Open();
                        command = new SqlCommand(sql, conn);
                        command.ExecuteNonQuery();
                        conn.Close();

                        
                        

                        //Notify user
                        MessageBox.Show("Staff member was successfully removed");

                        cmbDeleteStaff.SelectedIndex = -1;
                        cmbDeleteStaff.Text = "";
                        cbConfirm.Checked = false;

                        Fill_comboboxes();
                        displayData(DisplayAllsql);

                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Wait! Please confirm delete operation");
                }
            }
            else
            {
                MessageBox.Show("Choose a staff member ID.");
            }
           
            
        }

        private void cbUpdateStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbUpdateStaff.SelectedIndex > -1)
            {
                try
                {
                    string sql = $"SELECT * FROM Staff WHERE staff_id = {cbUpdateStaff.SelectedItem}";
                    conn.Open();
                    command = new SqlCommand(sql, conn);
                    reader = command.ExecuteReader();
                    reader.Read();
                    txtUEmail.Text = reader.GetValue(1).ToString();
                    txtUName.Text = reader.GetValue(2).ToString();
                    txtUSurname.Text = reader.GetValue(3).ToString();
                    txtUContactNumber.Text = reader.GetValue(4).ToString();
                    cmbUuserTypes.Text = reader.GetValue(5).ToString();
                    conn.Close();
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE Staff SET staff_email = '{txtUEmail.Text}', staff_name = '{txtUName.Text}', staff_lastname = '{txtUSurname.Text}', staff_usertype = '{cmbUuserTypes.SelectedItem}' WHERE staff_id = '{cbUpdateStaff.SelectedItem}'";
            try
            {
                if(cbUpdateStaff.SelectedIndex != -1)
                {
                    conn.Open();
                    command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("The record was successfully updated");
                    cbUpdateStaff.SelectedIndex = -1;
                    cbUpdateStaff.Text = "";
                    txtUEmail.Clear();
                    txtUName.Clear();
                    txtUSurname.Clear();
                    txtUContactNumber.Clear();
                    cmbUuserTypes.SelectedIndex = -1;
                    cmbUuserTypes.Text = "";

                    Fill_comboboxes();
                    displayData(DisplayAllsql);
                }
                else
                {
                    MessageBox.Show("Please select a record to update!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        
    }
}
