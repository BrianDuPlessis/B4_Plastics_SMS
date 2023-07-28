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
using DatabaseLogin.Class;

namespace B4_Plastics_SMS
{
    public partial class Stock: Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        string SQL = "";

        SqlConnection Con = DatabaseL.GetConnection();

        SqlDataAdapter Adapter = new SqlDataAdapter();
        SqlCommand Command;
        DataTable Data = new DataTable();

        public void displayData()
        {
            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT Det.pipe_id, Sz.pipe_length, Sz.pipe_diameter, Col.colour_code, Det.pipe_quantity " +
                      "FROM [Pipe Details] as Det " +
                           "LEFT JOIN [Pipe Size] as Sz ON Sz.size_id = Det.size_id " +
                           "LEFT JOIN Colours as Col ON Col.colour_id = Det.colour_id";

                Command = new SqlCommand(SQL, Con);

                Data = new DataTable();
                Data.Load(Command.ExecuteReader());

                dgvStockDetails.DataSource = Data;

                dgvStockDetails.Columns[0].HeaderText = "Pipe ID";
                dgvStockDetails.Columns[1].HeaderText = "Length";
                dgvStockDetails.Columns[2].HeaderText = "Diameter";
                dgvStockDetails.Columns[3].HeaderText = "Colour";
                dgvStockDetails.Columns[4].HeaderText = "Quantity";

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

            this.Height = 685;
            this.Width = 745;

            tabStock.SelectedTab = tabSearch;


            displayData();
            Fill_comboboxes();

            }

        private void Fill_comboboxes()
        {
            ////////////////////////////////////////////////////////////Tab Search///////////////////////////////////////////////////////////////////////////////////////

            try
            {
                Con.Open();

                SQL = "SELECT pipe_id " +
                      "FROM [Pipe Details]";

                Command = new SqlCommand(SQL, Con);

                SqlDataReader DataReader = Command.ExecuteReader();

                cbSearchPipeID.Items.Clear();

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

                cbFilterColour.Items.Clear();

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

                cbIColour.Items.Clear();

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

                cbUpdateStock.Items.Clear();

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

                cbUColour.Items.Clear();

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

                cbDeleteStock.Items.Clear();

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
                        this.Height = 685;
                        this.Width = 745;

                        this.CenterToScreen();

                        cbSearchPipeID.Text = "";
                        txtSearchQuantity.Text = "";
                        cbFilterColour.Text = "";

                        return;
                    }
                case 1:
                    {
                        this.Height = 450;
                        this.Width = 500;

                        this.CenterToScreen();

                        txtLength.Text = "";
                        txtDiameter.Text = "";
                        txtQuantity.Text = "";
                        cbIColour.Text = "";

                        txtLength.Focus();

                        return;
                    }
                case 2:
                    {
                        this.Height = 485;
                        this.Width = 495;

                        this.CenterToScreen();

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
                        this.Height = 330;
                        this.Width = 380;

                        this.CenterToScreen();

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
            txtSearchQuantity.Text = "";

            if (cbSearchPipeID.SelectedIndex != -1)
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
        }

        private void txtSearchQuantity_TextChanged(object sender, EventArgs e)
        {
            cbSearchPipeID.SelectedIndex = -1;
            cbFilterColour.SelectedIndex = -1;

            if (txtSearchQuantity.Text != "")
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

                if (txtSearchQuantity.Text != "")
                {
                    SQL += $" AND Det.pipe_quantity >= '{int.Parse(txtSearchQuantity.Text)}'";
                }

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
            int ColourID = 0;
            int SizeID = 0;

            if (double.TryParse(txtLength.Text, out Length) == false)
            {
                MessageBox.Show("Invalid input. Please enter a numerical (real) value.", "Error processing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLength.Focus();
            }

            if (double.TryParse(txtDiameter.Text, out Diameter) == false)
            {
                MessageBox.Show("Invalid input. Please enter a numerical (real) value.", "Error processing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiameter.Focus();
            }

            if (int.TryParse(txtQuantity.Text, out Quantity) == false)
            {
                MessageBox.Show("Invalid input. Please enter a numerical (integer) value.", "Error processing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
            }

            Colour = cbIColour.SelectedItem.ToString();

            if ((txtLength.Text != "") && (txtDiameter.Text != "") && (txtQuantity.Text != "") && (cbIColour.SelectedIndex > -1))
            {
                try
                {
                    Con.Open();

                    SQL = "SELECT colour_id " +
                          "FROM Colours " +
                         $"WHERE colour_code = '{Colour}'";

                    Command = new SqlCommand(SQL, Con);

                    SqlDataReader DataReader = Command.ExecuteReader();

                    DataReader.Read();

                    Colour = DataReader["colour_id"].ToString();
                    ColourID = int.Parse(Colour);

                    Con.Close();
                    Con.Open();

                    SQL = "INSERT " +
                          "INTO [Pipe Size] VALUES (@length, @diameter)";

                    Command = new SqlCommand(SQL, Con);

                    Adapter = new SqlDataAdapter();
                    Adapter.InsertCommand = Command;
                    Adapter.InsertCommand.Parameters.AddWithValue("@length", Length);
                    Adapter.InsertCommand.Parameters.AddWithValue("@diameter", Diameter);
                    Adapter.InsertCommand.ExecuteNonQuery();

                    Con.Close();
                    Con.Open();

                    SQL = "SELECT size_id " +
                          "FROM [Pipe Size] " +
                         $"WHERE pipe_length = {Length} AND pipe_diameter = {Diameter}";

                    Command = new SqlCommand(SQL, Con);

                    DataReader = Command.ExecuteReader();

                    DataReader.Read();

                    SizeID = int.Parse(DataReader["size_id"].ToString());

                    Con.Close();
                    Con.Open();

                    SQL = "INSERT " +
                          "INTO [Pipe Details] VALUES (@colour_ID, @size_id, @quantity)";

                    Command = new SqlCommand(SQL, Con);

                    Adapter = new SqlDataAdapter();
                    Adapter.InsertCommand = Command;
                    Adapter.InsertCommand.Parameters.AddWithValue("@colour_ID", ColourID);
                    Adapter.InsertCommand.Parameters.AddWithValue("@size_id", SizeID);
                    Adapter.InsertCommand.Parameters.AddWithValue("@quantity", Quantity);
                    Adapter.InsertCommand.ExecuteNonQuery();

                    MessageBox.Show("Data successfully inserted into Database!", "Database Action", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Con.Close();

                    displayData();
                    Fill_comboboxes();

                    tabStock.SelectedIndex = 0;

                    txtLength.Text = "";
                    txtDiameter.Text = "";
                    txtQuantity.Text = "";
                    cbIColour.SelectedIndex = -1;

                    this.Height = 685;
                    this.Width = 745;

                    this.CenterToScreen();

                    cbSearchPipeID.Text = "";
                    txtSearchQuantity.Text = "";
                    cbFilterColour.Text = "";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        /////////////////////////////////////////////////////////////////////Tab Update//////////////////////////////////////////////////////////////////////////////////

        private void cbUpdateStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT Det.pipe_id, Sz.pipe_length, Sz.pipe_diameter, Col.colour_code, Det.pipe_quantity " +
                      "FROM [Pipe Details] as Det " +
                           "LEFT JOIN [Pipe Size] as Sz ON Sz.size_id = Det.size_id " +
                           "LEFT JOIN Colours as Col ON Col.colour_id = Det.colour_id " +
                     $"WHERE Det.pipe_id = '{cbUpdateStock.Text}'";

                Command = new SqlCommand(SQL, Con);

                SqlDataReader DataReader = Command.ExecuteReader();

                DataReader.Read();

                txtULength.Text = DataReader["pipe_length"].ToString();
                txtUDiameter.Text = DataReader["pipe_diameter"].ToString();
                txtUPipeQuantity.Text = DataReader["pipe_quantity"].ToString();
                
                for (int k = cbUColour.Items.Count - 1; k > -1; --k)
                {
                    cbUColour.SelectedIndex = k;

                    if (String.Equals(DataReader["colour_code"].ToString(), cbUColour.SelectedItem.ToString()))
                        break;
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
            int Pipe_ID = 0;
            double Length = 0.00;
            double Diameter = 0.00;
            int Quantity = 0;
            string Colour = "";
            int ColourID = 0;
            int SizeID = 0;

            Pipe_ID = int.Parse(cbUpdateStock.Text);
            
            if (double.TryParse(txtULength.Text, out Length) == false)
            {
                MessageBox.Show("Invalid type entered. Please enter a numerical value.", "Error parsing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtULength.Focus();
            }

            if (double.TryParse(txtUDiameter.Text, out Diameter) == false)
            {
                MessageBox.Show("Invalid type entered. Please enter a numerical value.", "Error parsing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUDiameter.Focus();
            }

            Quantity = int.Parse(txtUPipeQuantity.Text);
            Colour = cbUColour.Text;

            try
            {
                Con.Close(); 
                Con.Open();

                SQL = "SELECT colour_id " +
                      "FROM Colours " +
                     $"WHERE colour_code = '{Colour}'";

                Command = new SqlCommand(SQL, Con);

                SqlDataReader DataReader = Command.ExecuteReader();

                DataReader.Read();

                ColourID = int.Parse(DataReader["colour_id"].ToString());

                Con.Close();
                Con.Open();

                SQL = "SELECT size_id " +
                      "FROM [Pipe Details] " +
                     $"WHERE pipe_id = {Pipe_ID}";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                DataReader.Read();

                SizeID = int.Parse(DataReader["size_id"].ToString());

                Con.Close();
                Con.Open();

                SQL = $"UPDATE [Pipe Details] SET [pipe_quantity] = {Quantity} WHERE pipe_id = {Pipe_ID}; " +
                      $"UPDATE [Pipe Details] SET [colour_id] = {ColourID} WHERE pipe_id = {Pipe_ID}; " +
                      $"UPDATE [Pipe Size] SET [pipe_length] = {Length} WHERE size_id = {SizeID}; " +
                      $"UPDATE [Pipe Size] SET [pipe_diameter] = {Diameter} WHERE size_id = {SizeID}";

                Command = new SqlCommand(SQL, Con);

                Adapter = new SqlDataAdapter();
                Adapter.UpdateCommand = Command;
                Adapter.UpdateCommand.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Data successfully updated!", "Database Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            displayData();
            Fill_comboboxes();

            tabStock.SelectedIndex = 0;

            cbUpdateStock.SelectedIndex = -1;
            txtULength.Text = "";
            txtUDiameter.Text = "";
            txtUPipeQuantity.Text = "";
            cbUColour.SelectedIndex = -1;

            this.Height = 685;
            this.Width = 745;

            this.CenterToScreen();

            cbSearchPipeID.Text = "";
            txtSearchQuantity.Text = "";
            cbFilterColour.Text = "";
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        /////////////////////////////////////////////////////////////////////Tab Delete//////////////////////////////////////////////////////////////////////////////////

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int pipe_id = 0; 

            if (int.TryParse(cbDeleteStock.SelectedItem.ToString(), out pipe_id) == false)
                MessageBox.Show("Invalid input. Please select a Stock ID!", "Error processing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (cbConfirm.Checked)
                {
                    try
                    {
                        Con.Open();

                        SQL = "DELETE " +
                              "FROM [Pipe Details] " +
                             $"WHERE pipe_id = {pipe_id}";

                        Command = new SqlCommand(SQL, Con);

                        Adapter = new SqlDataAdapter();
                        Adapter.DeleteCommand = Command;
                        Adapter.DeleteCommand.ExecuteNonQuery();

                        MessageBox.Show("You have successfully deleted the record (Pipe ID - " + cbDeleteStock.SelectedItem.ToString() + ")." , "Database Actions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Con.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    displayData();
                    Fill_comboboxes();

                    tabStock.SelectedIndex = 0;

                    cbDeleteStock.SelectedIndex = -1;
                    cbConfirm.Checked = false;

                    this.Height = 685;
                    this.Width = 745;

                    this.CenterToScreen();

                    cbSearchPipeID.Text = "";
                    txtSearchQuantity.Text = "";
                }
                else
                    MessageBox.Show("Please select 'Confirm Delete' box before deleteing records!", "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            cbSearchPipeID.SelectedIndex = -1;
            cbFilterColour.SelectedIndex = -1;

            txtSearchQuantity.Clear();

            displayData();
            Fill_comboboxes();

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
