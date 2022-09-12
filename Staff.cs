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
    public partial class Staff : Form
    {
        public static string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CMPG223-Project\B4_Plastics_SMS\B4Plastics.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(conStr);
        SqlDataAdapter adapter;
        DataSet dataset;
        SqlCommand command;
        SqlDataReader reader;

        public Staff()
        {
            InitializeComponent();
        }

        private void displayData(string sql)
        {
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                adapter.SelectCommand = command;
                adapter.Fill(dataset, "Staff");

                dgvEmployeeDetails.DataSource = dataset;
                dgvEmployeeDetails.DataMember = "Staff";
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error - Sorry, something went wrong");
            }
        }

        private void Staff_Activated(object sender, EventArgs e)
        {
            //display data
            string DisplayAllsql = "SELECT * FROM Staff";
            displayData(DisplayAllsql);

            //fill comboBox UserType
            string fillBoxSql = "SELECT staff_usertype FROM Staff";
            try
            {
                conn.Open();
                command = new SqlCommand(fillBoxSql, conn);
                
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

            string sql = $"SELECT * FROM Staff WHERE staff_email LIKE '{txtFilterEmail.Text}%'";
            displayData(sql);
        }

        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            txtFilterEmail.Text = "";
            txtFilterLastName.Text = "";

            string sql = $"SELECT * FROM Staff WHERE staff_name LIKE '{txtFilterName.Text}%'";
            displayData(sql);
        }

        private void txtFilterLastName_TextChanged(object sender, EventArgs e)
        {
            txtFilterEmail.Text = "";
            txtFilterName.Text = "";

            string sql = $"SELECT * FROM Staff WHERE staff_lastname LIKE '{txtFilterLastName.Text}%'";
            displayData(sql);
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string extraFilter = "", sql = "";
            if (txtFilterEmail.Text != "")
            {
                extraFilter = "AND WHERE staff_email LIKE '"+ txtFilterEmail.Text + "%'";
            }
            else if (txtFilterName.Text != "")
            {
                extraFilter = "AND WHERE staff_name LIKE '" + txtFilterName.Text + "%'";
            }
            else if (txtFilterLastName.Text != "")
            {
                extraFilter = "AND WHERE staff_lastname LIKE '" + txtFilterLastName.Text + "%'";
            }

            sql = $"SELECT * FROM Staff WHERE staff_usertype = '{cmbUserType.SelectedItem.ToString()}'" + extraFilter;
            displayData(sql);
        }
    }
}
