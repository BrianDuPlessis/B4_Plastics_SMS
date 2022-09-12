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

                SQL = "SELECT Det.pipe_id, Sz.pipe_length, Sz.pipe_length, Col.colour_code, Det.pipe_quantity " +
                      "FROM [Pipe Details] as Det " +
                           "LEFT JOIN [Pipe Size] as Sz ON Sz.size_id = Det.size_id " +
                           "LEFT JOIN Colours as Col ON Col.colour_id = Det.colour_id";

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

            displayData();

            ////////////////////////////////////////////////////////////Tab Search///////////////////////////////////////////////////////////////////////////////////////

            try
            {
                Con.Open();

                SQL = "SELECT pipe_id " +
                      "FROM [Pipe Details]";

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

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            ////////////////////////////////////////////////////////////Tab Insert///////////////////////////////////////////////////////////////////////////////////////

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
                    cbIColour.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////Tab Insert///////////////////////////////////////////////////////////////////////////////////////

            try
            {
                Con.Open();

                SQL = "SELECT pipe_id " +
                      "FROM [Pipe Details]";

                Command = new SqlCommand(SQL, Con);

                SqlDataReader DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbUpdateStock.Items.Add(DataReader.GetValue(0));
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
                    cbUColour.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////Tab Delete///////////////////////////////////////////////////////////////////////////////////////

            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT pipe_id " +
                      "FROM [Pipe Details]";

                Command = new SqlCommand(SQL, Con);

                SqlDataReader DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbDeleteStock.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void tabStock_Click(object sender, EventArgs e)
        {
            switch (tabStock.SelectedIndex)
            {
                case 0:
                    {
                        this.Height = 840;
                        this.Width = 985;

                        cbSearchPipeID.Text = "";
                        txtSearchQuantity.Text = "";
                        cbFilterColour.Text = "";

                        return;
                    }
                case 1:
                    {
                        this.Height = 553;
                        this.Width = 662;

                        txtLength.Text = "";
                        txtDiameter.Text = "";
                        txtQuantity.Text = "";
                        cbIColour.Text = "";

                        txtLength.Focus();

                        return;
                    }
                case 2:
                    {
                        this.Height = 596;
                        this.Width = 651;

                        cbUpdateStock.Text = "";
                        txtULength.Text = "";
                        txtUDiameter.Text = "";
                        txtUPipeQuantity.Text = "";
                        cbUColour.Text = "";

                        cbUpdateStock.Focus();

                        return;
                    }
                case 3:
                    {
                        this.Height = 412;
                        this.Width = 500;

                        cbDeleteStock.Text = "";
                        cbConfirm.Checked = false;

                        cbDeleteStock.Focus();

                        return;
                    }
            }
        }

        /////////////////////////////////////////////////////////////////////Tab Search//////////////////////////////////////////////////////////////////////////////////

        private void cbSearchPipeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT Det.pipe_id, Sz.pipe_length, Sz.pipe_diameter, Col.colour_code, Det.pipe_quantity " +
                      "FROM [Pipe Details] as Det " +
                           "LEFT JOIN [Pipe Size] as Sz ON Sz.size_id = Det.size_id " +
                           "LEFT JOIN Colours as Col ON Col.colour_id = Det.colour_id " +
                     $"WHERE Det.pipe_id = '{cbSearchPipeID.Text}'";

                Command = new SqlCommand(SQL, Con);

                Data = new DataTable();
                Data.Load(Command.ExecuteReader());

                dgvStockDetails.DataSource = Data;

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT Det.pipe_id, Sz.pipe_length, Sz.pipe_diameter, Col.colour_code, Det.pipe_quantity " +
                      "FROM [Pipe Details] as Det " +
                           "LEFT JOIN [Pipe Size] as Sz ON Sz.size_id = Det.size_id " +
                           "LEFT JOIN Colours as Col ON Col.colour_id = Det.colour_id " +
                     $"WHERE Det.pipe_quantity >= {int.Parse(txtSearchQuantity.Text)}";

                Command = new SqlCommand(SQL, Con);

                Data = new DataTable();
                Data.Load(Command.ExecuteReader());

                dgvStockDetails.DataSource = Data;

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbFilterColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT Det.pipe_id, Sz.pipe_length, Sz.pipe_diameter, Col.colour_code, Det.pipe_quantity " +
                      "FROM [Pipe Details] as Det " +
                           "LEFT JOIN [Pipe Size] as Sz ON Sz.size_id = Det.size_id " +
                           "LEFT JOIN Colours as Col ON Col.colour_id = Det.colour_id " +
                     $"WHERE Col.colour_code = '{cbFilterColour.Text}'";

                Command = new SqlCommand(SQL, Con);

                Data = new DataTable();
                Data.Load(Command.ExecuteReader());

                dgvStockDetails.DataSource = Data;

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        /////////////////////////////////////////////////////////////////////Tab Insert//////////////////////////////////////////////////////////////////////////////////

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double Length = 0.00;
            double Diameter = 0.00;
            int Quantity = 0;
            string Colour = "";

            if (double.TryParse(txtQuantity.Text, out Length) == false)
            {
                MessageBox.Show("Invalid input. Please enter a numerical (real) value.", "Error processing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
            }

            if (double.TryParse(txtQuantity.Text, out Diameter) == false)
            {
                MessageBox.Show("Invalid input. Please enter a numerical (real) value.", "Error processing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
            }

            if (int.TryParse(txtQuantity.Text, out Quantity) == false)
            {
                MessageBox.Show("Invalid input. Please enter a numerical (integer) value.", "Error processing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
            }

            try
            {
                Con.Open();

                SQL = $"INSERT INTO [Pipe Details]([pipe_quantity]) VALUES ({Quantity} " +
                      $"INSERT INTO [Pipe Size]([pipe_length]) VALUES ({Length}) " +
                      $"INSERT INTO [Pipe Size]([pipe_diameter]) VALUES ({Diameter})";

                Command = new SqlCommand(SQL, Con);

                Adapter = new SqlDataAdapter();
                Adapter.InsertCommand = Command;
                Adapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("Data successfully inserted into Database!");

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            displayData();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        /////////////////////////////////////////////////////////////////////Tab Update//////////////////////////////////////////////////////////////////////////////////

        private void cbUpdateStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SQL = "SELECT Det.pipe_id, Sz.pipe_length, Sz.pipe_diameter, Col.colour_code, Det.pipe_quantity " +
                      "FROM [Pipe Details] as Det " +
                           "LEFT JOIN [Pipe Size] as Sz ON Sz.size_id = Det.size_id " +
                           "LEFT JOIN Colours as Col ON Col.colour_id = Det.colour_id " +
                     $"WHERE Col.colour_code = '{cbFilterColour.Text}'";

                Command = new SqlCommand(SQL, Con);

                SqlDataReader DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    if (String.Equals(DataReader["pipe_id"].ToString(), cbUpdateStock.SelectedItem.ToString()))
                    {
                        cbUpdateStock.Text = cbUpdateStock.SelectedItem.ToString();
                    }

                    txtULength.Text = DataReader["pipe_length"].ToString();
                    txtUDiameter.Text = DataReader["pipe_diameter"].ToString();
                    txtUPipeQuantity.Text = DataReader["pipe_quantity"].ToString();

                    if (String.Equals(DataReader["colour_code"].ToString(), cbUColour.SelectedItem.ToString()))
                    {
                        cbUColour.Text = cbUColour.SelectedItem.ToString();
                    }
                }

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        /////////////////////////////////////////////////////////////////////Tab Delete//////////////////////////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
