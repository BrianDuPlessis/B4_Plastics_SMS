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
    public partial class Machines: Form
    {
        public Machines()
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
                      "FROM Machines";

                Command = new SqlCommand(SQL, Con);

                Data = new DataTable();
                Data.Load(Command.ExecuteReader());

                dgvMachineDetails.DataSource = Data;

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fillDisplay()
        {
            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT machine_id " +
                      "FROM Machines";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbFilterStatus.Items.Add(DataReader.GetValue(0));
                }

                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fillUpdate()
        {
            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT machine_id " +
                      "FROM Machines";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbUpdateMachine.Items.Add(DataReader.GetValue(0));
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
            try
            {
                Con.Close();
                Con.Open();

                SQL = "SELECT machine_id " +
                      "FROM Machines";

                Command = new SqlCommand(SQL, Con);

                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    cbDeleteMachine.Items.Add(DataReader.GetValue(0));
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
            fillDisplay();
            fillUpdate();
            fillDelete();

            cbFilterStatus.SelectedIndex = -1;
            rbMaintianed.Checked = false;
            rbNeedsService.Checked = false;

            tclMachines.SelectedIndex = 0;

            txtICapacity.Text = "";
            dtpIServiceDate.Value = DateTime.Today;
            rbIActive.Checked = false;
            rbIInActive.Checked = false;

            cbUpdateMachine.SelectedIndex = -1;
            txtUCapacity.Text = "";
            dtpUServiceDate.Value = DateTime.Today;
            rbUActive.Checked = false;
            rbUInActive.Checked = false;

            cbDeleteMachine.SelectedIndex = -1;
            cbConfirm.Checked = false;
        }

        private void Machines_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            Con = new SqlConnection(ConStr);

            displayData();
            fillDisplay();

            dtpIServiceDate.Value = DateTime.Today;

            fillUpdate();
            dtpUServiceDate.Value = DateTime.Today;

            fillDelete();
        }

        private void tclMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tclMachines.SelectedIndex)
            {
                case 0:
                    {
                        fillDisplay();

                        cbFilterStatus.SelectedIndex = -1;
                        rbMaintianed.Checked = false;
                        rbNeedsService.Checked = false;

                        break;
                    }
                case 1:
                    {
                        txtICapacity.Text = "";
                        dtpIServiceDate.Value = DateTime.Today;
                        rbIActive.Checked = false;
                        rbIInActive.Checked = false;

                        break;
                    }
                case 2:
                    {
                        fillUpdate();

                        cbUpdateMachine.SelectedIndex = -1;
                        txtUCapacity.Text = "";
                        dtpUServiceDate.Value = DateTime.Today;
                        rbUActive.Checked = false;
                        rbUInActive.Checked = false;

                        break;
                    }
                case 3:
                    {
                        fillDelete();

                        cbDeleteMachine.SelectedIndex = -1;
                        cbConfirm.Checked = false;

                        break;
                    }
            }
        }

        private void cbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbNeedsService.Checked = false;
            rbMaintianed.Checked = false;

            if (cbFilterStatus.SelectedIndex != -1)
            {
                try
                {
                    Con.Close();
                    Con.Open();

                    SQL = "SELECT * " +
                          "FROM Machines " +
                         $"WHERE machine_id = {int.Parse(cbFilterStatus.Text)}";

                    Command = new SqlCommand(SQL, Con);

                    Data = new DataTable();
                    Data.Load(Command.ExecuteReader());

                    dgvMachineDetails.DataSource = Data;

                    Con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rbNeedsService_CheckedChanged(object sender, EventArgs e)
        {
            cbFilterStatus.SelectedIndex = -1;

            if (rbNeedsService.Checked)
            {
                try
                {
                    Con.Close();
                    Con.Open();

                    SQL = "SELECT * " +
                          "FROM Machines " +
                         $"WHERE mach_service_date <= '{DateTime.Today}'";

                    Command = new SqlCommand(SQL, Con);

                    Data = new DataTable();
                    Data.Load(Command.ExecuteReader());

                    dgvMachineDetails.DataSource = Data;

                    Con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rbMaintianed_CheckedChanged(object sender, EventArgs e)
        {
            cbFilterStatus.SelectedIndex = -1;

            if (rbMaintianed.Checked)
            {
                try
                {
                    Con.Close();
                    Con.Open();

                    SQL = "SELECT * " +
                          "FROM Machines " +
                         $"WHERE mach_service_date > '{DateTime.Today}'";

                    Command = new SqlCommand(SQL, Con);

                    Data = new DataTable();
                    Data.Load(Command.ExecuteReader());

                    dgvMachineDetails.DataSource = Data;

                    Con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double Capacity = 0.00;
            DateTime ServiceDate = DateTime.Today;
            bool Status = false;  //Active = true; Inactive = false

            if (txtICapacity.Text != "" && dtpIServiceDate.Value == DateTime.Today && rbIActive.Checked == false || rbIInActive.Checked == false)
            {
                if (double.TryParse(txtICapacity.Text, out Capacity) == false)
                {
                    MessageBox.Show("Invalid type entered. Please enter a numerical value.", "Error parsing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtICapacity.Focus();
                }

                ServiceDate = dtpIServiceDate.Value;

                if (rbIActive.Checked)
                    Status = true;
                else if (rbIInActive.Checked)
                    Status = false;

                try
                {
                    Con.Close();
                    Con.Open();

                    SQL = "INSERT " +
                            "INTO Machines VALUES (@capacity, @service_Date, @status)";

                    Command = new SqlCommand(SQL, Con);

                    Adapter = new SqlDataAdapter();
                    Adapter.InsertCommand = Command;
                    Adapter.InsertCommand.Parameters.AddWithValue("@capacity", Capacity);
                    Adapter.InsertCommand.Parameters.AddWithValue("@service_Date", ServiceDate);
                    Adapter.InsertCommand.Parameters.AddWithValue("@status", Status.ToString());
                    Adapter.InsertCommand.ExecuteNonQuery();

                    Con.Close();

                    MessageBox.Show("You have successfully added a machine!", "Machines", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    displayData();
                    Clear();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Please make sure that all fields are filled in or selected.", "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbUpdateMachine_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Status = "";

            if (cbUpdateMachine.SelectedIndex != -1)
            {
                try
                {
                    Con.Close();
                    Con.Open();

                    SQL = "SELECT * " +
                          "FROM Machines as Det " +
                         $"WHERE machine_id = {int.Parse(cbUpdateMachine.Text)}";

                    Command = new SqlCommand(SQL, Con);

                    SqlDataReader DataReader = Command.ExecuteReader();

                    DataReader.Read();

                    txtUCapacity.Text = DataReader["mach_capacity"].ToString();
                    dtpUServiceDate.Value = DateTime.Parse(DataReader["mach_service_date"].ToString());
                    Status = DataReader["mach_status"].ToString();

                    if (Status == "False")
                        rbUInActive.Checked = true;
                    else
                        rbUActive.Checked = true;

                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int MachineID = 0;
            double Capacity = 0.00;
            DateTime ServiceDate = DateTime.Today;
            string Status = "";

            if (cbUpdateMachine.SelectedIndex != -1 && txtUCapacity.Text != "" && dtpUServiceDate.Value > DateTime.Today && rbUActive.Checked == false || rbUInActive.Checked == false)
            {
                MachineID = int.Parse(cbUpdateMachine.Text);

                if (double.TryParse(txtUCapacity.Text, out Capacity) == false)
                {
                    MessageBox.Show("Invalid type entered. Please enter a numerical value.", "Error parsing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUCapacity.Focus();
                }

                ServiceDate = dtpUServiceDate.Value;

                if (rbIActive.Checked)
                    Status = "True";
                else if (rbIInActive.Checked)
                    Status = "False";

                try
                {
                    Con.Close();
                    Con.Open();

                    SQL = "UPDATE Machines " +
                            $"SET [mach_capacity] = {Capacity}, [mach_service_date] = '{ServiceDate}', [mach_status] = '{Status}' " +
                         $"WHERE machine_id = {MachineID}";

                    Command = new SqlCommand(SQL, Con);

                    Adapter = new SqlDataAdapter();
                    Adapter.UpdateCommand = Command;
                    Adapter.UpdateCommand.ExecuteNonQuery();

                    Con.Close();

                    MessageBox.Show("Data successfully updated!", "Database Action", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    displayData();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error performing command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int MachineID = 0;

            if (int.TryParse(cbDeleteMachine.Text, out MachineID) == false)
                MessageBox.Show("Invalid input. Please select a Machine ID!", "Error processing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (cbConfirm.Checked)
                {
                    try
                    {
                        Con.Close();
                        Con.Open();

                        SQL = "DELETE " +
                              "FROM Machines " +
                             $"WHERE machine_id = {MachineID}";

                        Command = new SqlCommand(SQL, Con);

                        Adapter = new SqlDataAdapter();
                        Adapter.DeleteCommand = Command;
                        Adapter.DeleteCommand.ExecuteNonQuery();

                        Con.Close();

                        MessageBox.Show("You have successfully deleted the record 'Machine ID'", "Database Actions", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
