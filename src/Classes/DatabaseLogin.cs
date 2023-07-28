using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogin.Class
{
    public class DatabaseL
    {
        //Fields & Properties
        private static string userEmail = "Default";
        private static string type = "None";
        private static string username = "Username";
        private static List<string> email_list = new List<string>();
        private static List<string> pass_list = new List<string>();

        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\B4Plastics.mdf;Integrated Security=True";
       
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static string UserEmail
        {
            get { return userEmail; }
            set { userEmail = value; }
        }

        public static string Type
        {
            get { return type; }
            set { type = value; }
        }

        public static string Username
        {
            get { return username; }
            set { username = value; }
        }

        public static List<string> GetPass_list()
        { return pass_list; }

        public static void SetPass_list(List<string> set_list)
        { pass_list = set_list; }

        public static List<string> GetEmail_list()
        { return email_list; }

        public static void SetEmail_list(List<string> set_list)
        { email_list = set_list; }


        public static string GetTypeStaff(string email)
        {
            if (email == "Admin")
            {
                return "Admin";
            }
            else if (email == "Employee")
            {
                return "Employee";
            }
            else if (email == "Dispatch")
            {
                return "Dispatch";
            }
            else
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        SqlDataReader reader;
                        command.Connection = connection;
                        //Get Type
                        command.CommandText = $@"SELECT staff_usertype, staff_email
                                          FROM [Staff]
                                          WHERE staff_email Like '{email}'";
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            type = reader.GetString(0);
                        }
                        reader.Close();
                    }
                }
            }
                
            return type;
        }

        public static string GetName(string email)
        {
            if (email == "Admin")
            {
                return "Admin";
            }
            else if (email == "Employee")
            {
                return "Employee";
            }
            else if (email == "Dispatch")
            {
                return "Dispatch";
            }
            else
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        SqlDataReader reader;
                        command.Connection = connection;
                        //Get Name
                        command.CommandText = $@"SELECT staff_name, staff_email
                                            FROM [Staff]
                                            WHERE staff_email Like '{email}'";
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            username = reader.GetString(0);
                        }
                        reader.Close();
                    }
                }
            }

            return username;
        }
    }
}




