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
    public partial class TransactLoad: Form
    {
        public TransactLoad()
        {
            InitializeComponent();
        }

        string ConStr = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|B4Plastics.mdf;Integrated Security = True";
        string SQL = "";

        SqlConnection Con;

        SqlDataAdapter Adapter = new SqlDataAdapter();
        SqlCommand Command;
        DataTable Data = new DataTable();

        public void displayData()
        {
            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT * " +
                      "FROM Transactions";

                Command = new SqlCommand(SQL, Con);

                Data = new DataTable();
                Data.Load(Command.ExecuteReader());

                dgvTransactionDetails.DataSource = Data;

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TransactLoad_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(ConStr);

            displayData();

            try
            {
                Con.Open();

                SQL = "SELECT transaction_id " +
                      "FROM Transactions";

                Command = new SqlCommand(SQL, Con);

                SqlDataReader DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbxFTransID.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
                Con.Open();

                SQL = "SELECT pipe_id " +
                      "FROM [Pipe Details]";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbxMPipeID.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
                Con.Open();

                SQL = "SELECT staff_id " +
                      "FROM Staff";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbxMEmployID.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
                Con.Open();

                SQL = "SELECT dispatch_id " +
                      "FROM Dispatch";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbxMDispatchID.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
                Con.Open();

                SQL = "SELECT transaction_id " +
                      "FROM Transactions";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbxUpdateTransaction.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
                Con.Open();

                SQL = "SELECT transaction_id " +
                      "FROM Transactions";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbxDTransID.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
