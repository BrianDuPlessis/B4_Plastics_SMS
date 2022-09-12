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

                SQL = "SELECT Details.pipe_id, Size.pipe_length, Size.pipe_length " +
                      "FROM Theatre";

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

            try
            {
                Con.Open();

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error connecting to databsae", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            displayData();
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
