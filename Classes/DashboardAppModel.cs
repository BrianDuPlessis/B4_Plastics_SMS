using DashboardApp.Db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardApp.Models
{
    public struct TransactionQuantityByDate
    {
        public string Date { get; set; }
        public int TotalAmount { get; set; }
    }

    public class Dashboard : DbConnection
    {
        //Fields & Properties
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumActiveTransactions { get; private set; }
        public int NumCompletedTransactions { get; private set; }
        public List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        public List<TransactionQuantityByDate> TransactionQuantityList { get; private set; }
        public int ActiceMachines { get; set; }
        public int ServicesMachines { get; set; }
        public int NotActiveMachines { get; set; }

        //Constructor
        public Dashboard()
        {

        }

        //Private methods
        private void GetNumberItems()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //Get Total Number Active Transactions
                    command.CommandText = @"SELECT COUNT(trans_quantity) FROM Transactions WHERE isCompleted = 0
                                            AND trans_date between @fromDate and @toDate";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    NumActiveTransactions = (int)command.ExecuteScalar();

                    //Get Total Number Completed Transactions
                    command.CommandText = @"SELECT COUNT(trans_quantity) FROM Transactions WHERE isCompleted = 1
                                            AND trans_date between @fromDate and @toDate";
                    NumCompletedTransactions = (int)command.ExecuteScalar();

                    //Get Total Number of Actice Machines
                    command.CommandText = @"SELECT COUNT(machine_id) FROM Machines WHERE mach_status = 1";
                    ActiceMachines = (int)command.ExecuteScalar();

                    //Get Total Number of Not Active Machines
                    command.CommandText = @"SELECT COUNT(machine_id) FROM Machines WHERE mach_status = 0";
                    NotActiveMachines = (int)command.ExecuteScalar();

                    //Get Total Number of Machines that needs services
                    command.CommandText = @"SELECT COUNT(machine_id) FROM [Machines]" +
                                            "WHERE mach_service_date <= @toDate";
                    ServicesMachines = (int)command.ExecuteScalar();
                }
            }
        }
        private void GetProductAnalisys()
        {
            UnderstockList = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    //Get Understock
                    command.CommandText = @"SELECT pipe_id, pipe_quantity  
                                            FROM [Pipes Detials]
                                            WHERE pipe_quantity <= 50"; // and IsDiscontinued = 0
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UnderstockList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }
            }
        }
        private void GetTransactionAnalisys()
        {
            TransactionQuantityList = new List<TransactionQuantityByDate>();
            int TotalQuantity = 0;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT trans_date, SUM(trans_quantity)
                                            FROM Transactions
                                            WHERE trans_date between @fromDate and @toDate
                                            GROUP BY trans_date";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, int>>();
                    while (reader.Read())
                    {
                        resultTable.Add(
                            new KeyValuePair<DateTime, int>((DateTime)reader[0], (int)reader[1])
                            );
                        TotalQuantity += (int)reader[1];
                    }
                    reader.Close();

                    //Group by Hours
                    if (numberDays <= 1)
                    {
                        TransactionQuantityList = (from orderList in resultTable
                                                   group orderList by orderList.Key.ToString("hh tt")
                                           into order
                                                   select new TransactionQuantityByDate
                                                   {
                                                       Date = order.Key,
                                                       TotalAmount = order.Sum(amount => amount.Value)
                                                   }).ToList();
                    }
                    //Group by Days
                    else if (numberDays <= 30)
                    {
                        TransactionQuantityList = (from orderList in resultTable
                                                   group orderList by orderList.Key.ToString("dd MMM")
                                           into order
                                                   select new TransactionQuantityByDate
                                                   {
                                                       Date = order.Key,
                                                       TotalAmount = order.Sum(amount => amount.Value)
                                                   }).ToList();
                    }

                    //Group by Weeks
                    else if (numberDays <= 92)
                    {
                        TransactionQuantityList = (from orderList in resultTable
                                                   group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                       orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                                   select new TransactionQuantityByDate
                                                   {
                                                       Date = "Week " + order.Key.ToString(),
                                                       TotalAmount = order.Sum(amount => amount.Value)
                                                   }).ToList();
                    }

                    //Group by Months
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        TransactionQuantityList = (from orderList in resultTable
                                                   group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                                   select new TransactionQuantityByDate
                                                   {
                                                       Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                       TotalAmount = order.Sum(amount => amount.Value)
                                                   }).ToList();
                    }

                    //Group by Years
                    else
                    {
                        TransactionQuantityList = (from orderList in resultTable
                                                   group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                                   select new TransactionQuantityByDate
                                                   {
                                                       Date = order.Key,
                                                       TotalAmount = order.Sum(amount => amount.Value)
                                                   }).ToList();
                    }
                }
            }
        }

        //Public methods
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                GetProductAnalisys();
                GetTransactionAnalisys();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}




