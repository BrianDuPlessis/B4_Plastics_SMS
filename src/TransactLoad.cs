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
        SqlDataReader DataReader;
        SqlCommand Command;
        DataTable Data = new DataTable();

        public void displayData()
        {
            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT * " +
                      "FROM Transactions ORDER BY transaction_id DESC";

                Command = new SqlCommand(SQL, Con);

                Data = new DataTable();
                Data.Load(Command.ExecuteReader());

                dgvTransactionDetails.DataSource = Data;

                dgvTransactionDetails.Columns[0].HeaderText = "Transaction ID";
                dgvTransactionDetails.Columns[1].HeaderText = "Pipe ID";
                dgvTransactionDetails.Columns[2].HeaderText = "Staff ID";
                dgvTransactionDetails.Columns[3].HeaderText = "Dispatch ID";
                dgvTransactionDetails.Columns[4].HeaderText = "Quantity";
                dgvTransactionDetails.Columns[5].HeaderText = "Transaction Date";
                dgvTransactionDetails.Columns[6].HeaderText = "Completed";

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void displayPipes()
        {
            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT Det.pipe_id, Sz.pipe_length, Sz.pipe_diameter, Col.colour_code, Det.pipe_quantity " +
                      "FROM [Pipe Details] as Det " +
                           "LEFT JOIN [Pipe Size] as Sz ON Sz.size_id = Det.size_id " +
                           "LEFT JOIN Colours as Col ON Col.colour_id = Det.colour_id " +
                      "WHERE Det.pipe_quantity > 0";

                Command = new SqlCommand(SQL, Con);

                Data = new DataTable();
                Data.Load(Command.ExecuteReader());

                dgvPipeDetails.DataSource = Data;

                dgvPipeDetails.Columns[0].HeaderText = "Pipe Id";
                dgvPipeDetails.Columns[1].HeaderText = "Length";
                dgvPipeDetails.Columns[2].HeaderText = "Diameter";
                dgvPipeDetails.Columns[3].HeaderText = "Colour";
                dgvPipeDetails.Columns[4].HeaderText = "Quantity";

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        public void fillSearch()
        {
            cbxFTransID.Items.Clear();

            try
            {
                Con.Close(); 
                Con.Open();

                SQL = "SELECT transaction_id " +
                      "FROM Transactions";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbxFTransID.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fillInsertPipe()
        {
            cbxMPipeID.Items.Clear();

            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT pipe_id " +
                      "FROM [Pipe Details] " +
                      "WHERE pipe_quantity > 0";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbxMPipeID.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fillInsertEmploy()
        {
            cbxMEmployID.Items.Clear();

            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT staff_id, staff_name, staff_lastname " +
                      "FROM Staff " +
                      "WHERE staff_usertype = 'Employee'";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbxMEmployID.Items.Add(DataReader.GetValue(0) + " - " + DataReader.GetValue(1) + " " + DataReader.GetValue(2));
                }

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fillInsertDispatch()
        {
            cbxMDispatchID.Items.Clear();

            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT staff_id, staff_name, staff_lastname " +
                      "FROM Staff " +
                      "WHERE staff_usertype = 'Dispatch'";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbxMDispatchID.Items.Add(DataReader.GetValue(0) + " - " + DataReader.GetValue(1) + " " + DataReader.GetValue(2));
                }

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fillUpdateTrans()
        {
            cbxUpdateTransaction.Items.Clear();

            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT transaction_id " +
                      "FROM Transactions ORDER BY transaction_id DESC";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbxUpdateTransaction.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fillUpdatePipe()
        {
            cbxUPipeID.Items.Clear();

            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT DISTINCT pipe_id " +
                      "FROM Transactions";


                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbxUPipeID.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fillUpdateEmploy()
        {
            cbxUEmployeeStaff.Items.Clear();

            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT DISTINCT staff_id " +
                      "FROM Transactions";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbxUEmployeeStaff.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fillUpdateDispatch()
        {
            cbUpdateDispatchID.Items.Clear();

            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT dispatch_id " +
                      "FROM Dispatch";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbUpdateDispatchID.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fillUpdateDispStaff()
        {
            cbUDispatchStaff.Items.Clear();

            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT DISTINCT staff_id " +
                      "FROM Dispatch";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbUDispatchStaff.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fillDelete()
        {
            cbxDTransID.Items.Clear();

            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT transaction_id " +
                      "FROM Transactions ORDER BY transaction_id DESC";

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

        public void Clear()
        {
            fillSearch();

            fillInsertPipe();
            fillInsertEmploy();
            fillInsertDispatch();
            displayPipes();

            fillUpdateTrans();
            fillUpdatePipe();
            fillUpdateEmploy();
            fillUpdateDispatch();
            fillUpdateDispStaff();

            fillDelete();

            dtpMTransDate.Value = DateTime.Today;
            dtpMDelivDate.Value = DateTime.Today.AddDays(5);

            dtpUTransactionDate.Value = DateTime.Today;
            dtpUDeliveryDate.Value = DateTime.Today.AddDays(5);

            cbxFTransID.SelectedIndex = -1;
            rbnFYes.Checked = false;
            rbnFNo.Checked = false;

            tclTransactions.SelectedIndex = 0;

            cbxMPipeID.SelectedIndex = -1;
            cbxMEmployID.SelectedIndex = -1;
            txtMQuantity.Text = "";
            dtpMTransDate.Value = DateTime.Today;
            cbxMDispatchID.SelectedIndex = -1;
            txtMLocation.Text = "";

            cbxUpdateTransaction.SelectedIndex = -1;
            cbxUPipeID.SelectedIndex = -1;
            cbxUEmployeeStaff.SelectedIndex = -1;
            txtUQuantity.Text = "";
            dtpUTransactionDate.Value = DateTime.Today;
            cbCompleted.Checked = false;
            cbUpdateDispatchID.SelectedIndex = -1;
            cbUDispatchStaff.SelectedIndex = -1;
            dtpUDeliveryDate.Value = DateTime.Today;
            txtULocation.Text = "";

            cbxDTransID.SelectedIndex = -1;
            cbConfirmDel.Checked = false;
        }

        ///////////////////////////////////////////////////////////////PAGE LOAD//////////////////////////////////////////////////////////////////////////////////////

        private void TransactLoad_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            Con = new SqlConnection(ConStr);

            displayData();
            Clear();
        }

        private void tclTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tclTransactions.SelectedIndex)
            {
                case 0:
                    {
                        fillSearch();

                        cbxFTransID.SelectedIndex = -1;
                        rbnFYes.Checked = false;
                        rbnFNo.Checked = false;

                        break;
                    }
                case 1:
                    {
                        fillInsertPipe();
                        fillInsertEmploy();
                        fillInsertDispatch();
                        displayPipes();

                        dtpMTransDate.Value = DateTime.Today;
                        dtpMDelivDate.Value = DateTime.Today.AddDays(5);

                        cbxMPipeID.SelectedIndex = -1;
                        cbxMEmployID.SelectedIndex = -1;
                        txtMQuantity.Text = "";
                        dtpMTransDate.Value = DateTime.Today;
                        cbxMDispatchID.SelectedIndex = -1;
                        txtMLocation.Text = "";

                        break;
                    }
                case 2:
                    {
                        fillUpdateTrans();
                        fillUpdatePipe();
                        fillUpdateEmploy();
                        fillUpdateDispatch();
                        fillUpdateDispStaff();

                        dtpUTransactionDate.Value = DateTime.Today;
                        dtpUDeliveryDate.Value = DateTime.Today.AddDays(5);

                        cbxUpdateTransaction.SelectedIndex = -1;
                        cbxUPipeID.SelectedIndex = -1;
                        cbxUEmployeeStaff.SelectedIndex = -1;
                        txtUQuantity.Text = "";
                        dtpUTransactionDate.Value = DateTime.Today;
                        cbCompleted.Checked = false;
                        cbUpdateDispatchID.SelectedIndex = -1;
                        cbUDispatchStaff.SelectedIndex = -1;
                        dtpUDeliveryDate.Value = DateTime.Today;
                        txtULocation.Text = "";

                        break;
                    }
                case 3:
                    {
                        fillDelete();

                        cbxDTransID.SelectedIndex = -1;
                        cbConfirmDel.Checked = false;

                        break;
                    }
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //////////////////////////////////////////////////////////////TAB SEARCH//////////////////////////////////////////////////////////////////////////////////////

        private void cbxFTransID_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbnFYes.Checked = false;
            rbnFNo.Checked = false;

            if (cbxFTransID.SelectedIndex > -1)
            {
                try
                {
                    Con.Open();

                    SQL = "SELECT * " +
                          "FROM Transactions " +
                         $"WHERE transaction_id = {int.Parse(cbxFTransID.Text)}";

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
        }

        private void rbnFYes_CheckedChanged(object sender, EventArgs e)
        {
            bool Checked = false;

            cbxFTransID.SelectedIndex = -1;
            Checked = rbnFYes.Checked;

            if (Checked)
            {
                try
                {
                    Con.Close();
                    Con.Open();

                    SQL = "SELECT * " +
                          "FROM Transactions " +
                         $"WHERE isCompleted = '{Checked}'";

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
        }

        private void rbnFNo_CheckedChanged(object sender, EventArgs e)
        {
            bool Checked = false;

            cbxFTransID.SelectedIndex = -1;
            Checked = rbnFNo.Checked;

            if (Checked)
            {
                try
                {
                    Con.Close();
                    Con.Open();

                    SQL = "SELECT * " +
                          "FROM Transactions " +
                          "WHERE isCompleted = 'FALSE'";

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
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //////////////////////////////////////////////////////////////TAB INSERT//////////////////////////////////////////////////////////////////////////////////////

        private void dtpMTransDate_ValueChanged(object sender, EventArgs e)
        {
            dtpMDelivDate.Value = dtpMTransDate.Value.AddDays(5);
        }

        private void btnMakeTrans_Click(object sender, EventArgs e)
        {
            int Pipe_ID = 0;
            int EmployStaff_ID = 0;
            int Quantity = 0;
            int DispatchQuantity = 0;
            int QuantityDB = 0;
            int NewQuantity = 0;
            int Dispatch_ID = 0;
            int DispaStaff_ID = 0;
            int Index = 0;

            DateTime TransDate;
            DateTime DelivDate;

            string Location = "";

            if (cbxMPipeID.SelectedIndex != -1 && cbxMEmployID.SelectedIndex != -1 && txtMQuantity.Text != "" &&
                cbxMDispatchID.SelectedIndex != -1 && txtMLocation.Text != "")
            {
                Pipe_ID = int.Parse(cbxMPipeID.Text);
                Index = cbxMEmployID.Text.IndexOf(' ');
                EmployStaff_ID = int.Parse(cbxMEmployID.Text.Substring(0, Index));

                if (int.TryParse(txtMQuantity.Text, out Quantity) == false)
                {
                    MessageBox.Show("Invalid type entered. Please enter a numerical (Integer) value.", "Error parsing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMQuantity.Focus();
                }

                TransDate = dtpMTransDate.Value;
                Index = cbxMDispatchID.Text.IndexOf(' ');
                DispaStaff_ID = int.Parse(cbxMDispatchID.Text.Substring(0, Index));
                DelivDate = TransDate.AddDays(5);
                Location = txtMLocation.Text;

                try
                {
                    Con.Close();
                    Con.Open();

                    SQL = "SELECT pipe_quantity " +
                          "FROM [Pipe Details] " +
                         $"WHERE pipe_id = {Pipe_ID}";

                    Command = new SqlCommand(SQL, Con);

                    DataReader = Command.ExecuteReader();

                    DataReader.Read();

                    QuantityDB = int.Parse(DataReader["pipe_quantity"].ToString());

                    Con.Close();

                    if (Quantity <= QuantityDB)
                    {
                        Con.Open();

                        SQL = "INSERT " +
                              "INTO Dispatch VALUES (@staff_id, @deliv_date, @quantity, @location)";

                        Command = new SqlCommand(SQL, Con);

                        Adapter = new SqlDataAdapter();
                        Adapter.InsertCommand = Command;
                        Adapter.InsertCommand.Parameters.AddWithValue("@staff_id", DispaStaff_ID);
                        Adapter.InsertCommand.Parameters.AddWithValue("@deliv_date", DelivDate);
                        Adapter.InsertCommand.Parameters.AddWithValue("@quantity", DispatchQuantity);
                        Adapter.InsertCommand.Parameters.AddWithValue("@location", Location);
                        Adapter.InsertCommand.ExecuteNonQuery();

                        Con.Close();

                        Con.Open();

                        SQL = "SELECT dispatch_id " +
                              "FROM Dispatch " +
                             $"WHERE staff_id = {DispaStaff_ID} AND dispatch_delivery_date = '{DelivDate}' AND dispatch_location = '{Location}'";

                        Command = new SqlCommand(SQL, Con);

                        DataReader = Command.ExecuteReader();

                        DataReader.Read();

                        Dispatch_ID = int.Parse(DataReader["dispatch_id"].ToString());

                        Con.Close();
                        Con.Open();

                        SQL = "INSERT " +
                              "INTO Transactions VALUES (@pipe_id, @staff_id, @dispatch_id, @quantity, @trans_date, @completed)";

                        Command = new SqlCommand(SQL, Con);

                        Adapter = new SqlDataAdapter();
                        Adapter.InsertCommand = Command;
                        Adapter.InsertCommand.Parameters.AddWithValue("@pipe_id", Pipe_ID);
                        Adapter.InsertCommand.Parameters.AddWithValue("@staff_id", EmployStaff_ID);
                        Adapter.InsertCommand.Parameters.AddWithValue("@dispatch_id", Dispatch_ID);
                        Adapter.InsertCommand.Parameters.AddWithValue("@quantity", Quantity);
                        Adapter.InsertCommand.Parameters.AddWithValue("@trans_date", TransDate);
                        Adapter.InsertCommand.Parameters.AddWithValue("@completed", "FALSE");
                        Adapter.InsertCommand.ExecuteNonQuery();

                        Con.Close();

                        NewQuantity = QuantityDB - Quantity;

                        Con.Open();

                        SQL = $"UPDATE [Pipe Details] SET [pipe_quantity] = {NewQuantity} WHERE pipe_id = {Pipe_ID}";

                        Command = new SqlCommand(SQL, Con);

                        Adapter = new SqlDataAdapter();
                        Adapter.UpdateCommand = Command;
                        Adapter.UpdateCommand.ExecuteNonQuery();

                        Con.Close();

                        MessageBox.Show("You have successfully made a transaction!", "Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Clear();
                        displayData();
                        
                    }
                    else
                    {
                        MessageBox.Show("The quantity you want to use for this transaction more than the quantity available. Please enter a valid quantity number.", "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMQuantity.Focus();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Please make sure that all fields are filled in or selected.", "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //////////////////////////////////////////////////////////////TAB UPDATE//////////////////////////////////////////////////////////////////////////////////////

        private void cbxUpdateTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dispatchID = 0;

            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT * " +
                      "FROM Transactions " +
                     $"WHERE transaction_id = {int.Parse(cbxUpdateTransaction.Text)}";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                DataReader.Read();

                for (int k = cbxUPipeID.Items.Count - 1; k > -1; --k)
                {
                    cbxUPipeID.SelectedIndex = k;

                    if (String.Equals(DataReader["pipe_id"].ToString(), cbxUPipeID.SelectedItem.ToString()))
                        break;
                }

                for (int k = cbxUEmployeeStaff.Items.Count - 1; k > -1; --k)
                {
                    cbxUEmployeeStaff.SelectedIndex = k;

                    if (String.Equals(DataReader["staff_id"].ToString(), cbxUEmployeeStaff.SelectedItem.ToString()))
                        break;
                }

                txtUQuantity.Text = DataReader["trans_quantity"].ToString();
                dtpUTransactionDate.Value = DateTime.Parse(DataReader["trans_date"].ToString());

                if (DataReader["isCompleted"].ToString() == "False")
                    cbCompleted.Checked = false;
                else
                    cbCompleted.Checked = true;

                dispatchID = int.Parse(DataReader["dispatch_id"].ToString());

                Con.Close();
                Con.Open();

                SQL = "SELECT * " +
                      "FROM Dispatch " +
                     $"WHERE dispatch_id = {dispatchID}";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                DataReader.Read();

                for (int k = cbUpdateDispatchID.Items.Count - 1; k > -1; --k)
                {
                    cbUpdateDispatchID.SelectedIndex = k;

                    if (String.Equals(DataReader["dispatch_id"].ToString(), cbUpdateDispatchID.SelectedItem.ToString()))
                        break;
                }

                for (int k = cbUDispatchStaff.Items.Count - 1; k > -1; --k)
                {
                    cbUDispatchStaff.SelectedIndex = k;

                    if (String.Equals(DataReader["staff_id"].ToString(), cbUDispatchStaff.SelectedItem.ToString()))
                        break;
                }

                dtpUDeliveryDate.Value = DateTime.Parse(DataReader["dispatch_delivery_date"].ToString());
                txtULocation.Text = DataReader["dispatch_location"].ToString();

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int TransID = 0;
            int PipeID = 0;
            int EmployStaffID = 0;
            int QuantityStock = 0;
            int DBQuantity = 0;
            int Quantity = 0;
            int NewQuantity = 0;
            int DispID = 0;
            int DispStaffID = 0;

            DateTime DeliverDate;

            string Completed = "";
            string Location = "";

            TransID = int.Parse(cbxUpdateTransaction.Text);
            PipeID = int.Parse(cbxUPipeID.Text);
            EmployStaffID = int.Parse(cbxUEmployeeStaff.Text);

            if (int.TryParse(txtUQuantity.Text, out Quantity) == false)
            {
                MessageBox.Show("Invalid type entered. Please enter a numerical (Integer) value.", "Error parsing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUQuantity.Focus();
            }

            if (cbCompleted.Checked)
                Completed = "True";
            else
                Completed = "False";

            DispID = int.Parse(cbUpdateDispatchID.Text);
            DispStaffID = int.Parse(cbUDispatchStaff.Text);
            DeliverDate = dtpUDeliveryDate.Value;
            Location = txtULocation.Text;

            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT pipe_quantity " +
                      "FROM [Pipe Details] " +
                     $"WHERE pipe_id = {PipeID}";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                DataReader.Read();

                QuantityStock = int.Parse(DataReader["pipe_quantity"].ToString());

                Con.Close();
                Con.Open();

                SQL = "SELECT trans_quantity " +
                      "FROM Transactions " +
                     $"WHERE transaction_id = {TransID}";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                DataReader.Read();

                DBQuantity = int.Parse(DataReader["trans_quantity"].ToString());

                Con.Close();

                if (Quantity <= DBQuantity)
                {
                    NewQuantity = DBQuantity - Quantity;
                    QuantityStock = QuantityStock + NewQuantity;
                }
                else
                {
                    NewQuantity = Quantity - DBQuantity;
                    QuantityStock = QuantityStock - NewQuantity;
                }

                if (NewQuantity <= QuantityStock)
                {
                    Con.Open();

                    SQL = "UPDATE Transactions " +
                            $"SET [pipe_id] = {PipeID}, [staff_id] = {EmployStaffID}, [dispatch_id] = {DispID}, [trans_quantity] = {Quantity}, [isCompleted] = '{Completed}' " +
                         $"WHERE transaction_id = {TransID}; " +
                          "UPDATE Dispatch " +
                            $"SET [staff_id] = {DispStaffID}, [dispatch_delivery_date] = '{DeliverDate}', [dispatch_location] = '{Location}' " +
                         $"WHERE dispatch_id = {DispID}";

                    Command = new SqlCommand(SQL, Con);

                    Adapter = new SqlDataAdapter();
                    Adapter.UpdateCommand = Command;
                    Adapter.UpdateCommand.ExecuteNonQuery();

                    Con.Close();
                    Con.Open();

                    SQL = "UPDATE [Pipe Details] " +
                            $"SET [pipe_quantity] = {QuantityStock} " +
                         $"WHERE pipe_id = {PipeID}";

                    Command = new SqlCommand(SQL, Con);

                    Adapter = new SqlDataAdapter();
                    Adapter.UpdateCommand = Command;
                    Adapter.UpdateCommand.ExecuteNonQuery();

                    Con.Close();

                    MessageBox.Show("Data successfully updated!", "Database Action", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    displayData();
                    Clear();

                }
                else
                {
                    MessageBox.Show("Invalid number of items. It exceeds the amount available in stock. Please enter another value.", "Error parsing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUQuantity.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            displayData();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //////////////////////////////////////////////////////////////TAB DELETE//////////////////////////////////////////////////////////////////////////////////////

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int trans_ID = 0;
            int pipe_id = 0;
            int dispatch_id = 0;
            int StockQuantity = 0;
            int TransQuantity = 0;
            int NewQuantity = 0;

            if (int.TryParse(cbxDTransID.Text, out trans_ID) == false)
                MessageBox.Show("Invalid input. Please select a Transaction ID!", "Error processing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (cbConfirmDel.Checked)
                {
                    try
                    {
                        Con.Close();
                        Con.Open();

                        SQL = "SELECT pipe_id, trans_quantity, dispatch_id " +
                              "FROM Transactions " +
                             $"WHERE transaction_id = {trans_ID}";

                        Command = new SqlCommand(SQL, Con);

                        DataReader = Command.ExecuteReader();

                        DataReader.Read();

                        pipe_id = int.Parse(DataReader["pipe_id"].ToString());
                        TransQuantity = int.Parse(DataReader["trans_quantity"].ToString());
                        dispatch_id = Convert.ToInt32(DataReader.GetValue(2));

                        Con.Close();

                        Con.Open();

                        SQL = "SELECT pipe_quantity " +
                              "FROM [Pipe Details] " +
                             $"WHERE pipe_id = {pipe_id}";

                        Command = new SqlCommand(SQL, Con);

                        DataReader = Command.ExecuteReader();

                        DataReader.Read();

                        StockQuantity = int.Parse(DataReader["pipe_quantity"].ToString());

                        Con.Close();

                        Con.Open();

                        SQL = "DELETE " +
                              "FROM Transactions " +
                             $"WHERE transaction_id = {trans_ID}"; 

                        Command = new SqlCommand(SQL, Con);

                        Adapter = new SqlDataAdapter();
                        Adapter.DeleteCommand = Command;
                        Adapter.DeleteCommand.ExecuteNonQuery();

                        Con.Close();

                        Con.Open();

                        SQL = "DELETE " +
                              "FROM Dispatch " +
                             $"WHERE dispatch_id = {dispatch_id};";

                        Command = new SqlCommand(SQL, Con);

                        Adapter = new SqlDataAdapter();
                        Adapter.DeleteCommand = Command;
                        Adapter.DeleteCommand.ExecuteNonQuery();

                        Con.Close();

                       NewQuantity = StockQuantity + TransQuantity;

                        Con.Open();

                        SQL = "UPDATE [Pipe Details] " +
                                $"SET [pipe_quantity] = {NewQuantity} " +
                              $"WHERE pipe_id = {pipe_id}";

                        Command = new SqlCommand(SQL, Con);

                        Adapter = new SqlDataAdapter();
                        Adapter.UpdateCommand = Command;
                        Adapter.UpdateCommand.ExecuteNonQuery();

                        Con.Close();

                        MessageBox.Show("You have successfully deleted the record (Transaction ID - " + trans_ID + ").", "Database Actions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        displayData();
                        Clear();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Please select 'Confirm Delete' box before deleteing records!", "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            displayData();
            Clear();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
