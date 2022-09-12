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
    public partial class Stock: Form
    {
        public Stock()
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
                Con.Open();

                SQL = "SELECT Det.pipe_id, Sz.pipe_length, Sz.pipe_length, Col.colour_code " +
                      "FROM Pipe_Details as Det " +
                           "LEFT JOIN Pipe Size as Sz ON Sz.size_id = Det.size_id " +
                           "LEFT JOIN Colours as Col ON Col.colour_id = Det.colour_id ";

                Command = new SqlCommand(SQL, Con);

                Data = new DataTable();
                Data.Load(Command.ExecuteReader());

                dgvStockDetails.DataSource = Data;

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            this.Height = 840;
            this.Width = 985;

            tabStock.SelectedTab = tabSearch;

            Con = new SqlConnection(ConStr);

            try
            {
                Con.Open();

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error connecting to databsae", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //displayData();

            try
            {
                Con.Open();

                SQL = "SELECT pipe_id " +
                      "FROM Pipe Details";

                Command = new SqlCommand(SQL, Con);

                SqlDataReader DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbSearchPipeID.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT colour_code " +
                      "FROM Colours";

                Command = new SqlCommand(SQL, Con);

                SqlDataReader DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbFilterColour.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con.Close();
        }

        private void tabStock_Click(object sender, EventArgs e)
        {
            switch (tabStock.SelectedIndex)
            {
                case 0:
                    {
                        this.Height = 840;
                        this.Width = 985;
                        return;
                    }
                case 1:
                    {
                        this.Height = 553;
                        this.Width = 662;
                        return;
                    }
                case 2:
                    {
                        this.Height = 596;
                        this.Width = 651;
                        return;
                    }
                case 3:
                    {
                        this.Height = 412;
                        this.Width = 500;
                        return;
                    }
            }
        }
    }
}
