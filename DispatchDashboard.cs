using DashboardApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLogin.Class;
using System.Data.SqlClient;

namespace B4_Plastics_SMS
{
    public partial class DispatchDashboard : Form
    {
        //Fields
        private Dashboard model;
        SqlCommand command;

        public DispatchDashboard()
        {
            InitializeComponent();


            model = new Dashboard();
            LoadData();
        }

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //Private methods
        private void LoadData()
        {
            var refreshData = model.LoadData(DateTime.Today, DateTime.Today);
            if (refreshData == true)
            {
                dgvUnderstock.DataSource = model.UnderstockList;
                dgvUnderstock.Columns[0].HeaderText = "Item";
                dgvUnderstock.Columns[1].HeaderText = "Units";
                Console.WriteLine("Loaded view :)");

                GetEmployeeAnalisys();

            }
            else Console.WriteLine("View not loaded, same query");
        }

        private void GetEmployeeAnalisys()
        {

            using (var connection = DatabaseL.GetConnection())
            {
                connection.Open();
                //Get Transactions that dispatch's is working on

                string SQL = "SELECT t.transaction_id, t.trans_quantity, c.colour_code, s.pipe_length, s.pipe_diameter,  d.dispatch_id, d.dispatch_quantity, d.dispatch_location, d.dispatch_delivery_date, t.isCompleted ";
                SQL += "FROM [Transactions] AS t ";
                SQL += "LEFT JOIN [Pipe Details] AS pd ON t.pipe_id = pd.pipe_id ";
                SQL += "LEFT JOIN [Colours] AS c ON pd.colour_id = c.colour_id ";
                SQL += "LEFT JOIN [Pipe Size] AS s ON pd.size_id = s.size_id ";
                SQL += "LEFT JOIN [Dispatch] AS d ON t.dispatch_id = d.dispatch_id ";
                SQL += $"WHERE d.staff_id = {Get_Staff_id()} AND t.isCompleted = 0";


                command = new SqlCommand(SQL, connection);

                DataTable Data = new DataTable();
                Data.Load(command.ExecuteReader());

                dgvTransactions.DataSource = Data;

                dgvTransactions.Columns[0].HeaderText = "Transaction ID";
                dgvTransactions.Columns[1].HeaderText = "Quantity";
                dgvTransactions.Columns[2].HeaderText = "Colour";
                dgvTransactions.Columns[3].HeaderText = "Pipe length";
                dgvTransactions.Columns[4].HeaderText = "Pipe diameter";
                dgvTransactions.Columns[5].HeaderText = "Dispatch ID";
                dgvTransactions.Columns[6].HeaderText = "Dispatch quantity ready";
                dgvTransactions.Columns[7].HeaderText = "Location";
                dgvTransactions.Columns[8].HeaderText = "Due for delivery";
                dgvTransactions.Columns[9].HeaderText = "Completed";


            }
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
    }
}
