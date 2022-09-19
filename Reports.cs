using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using DatabaseLogin.Class;
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
using System.IO;

namespace B4_Plastics_SMS
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        // =====================================================
        // Global Variables  
        // =====================================================

        private SqlConnection cnn;
        private Bitmap bmpData, bmpSort, bmpFilter, bmpSlip;
        private bool isFilterUsed = true;
        SqlCommand cmd;
        SqlDataReader reader;

        // Form load 
        private void Reports_Load(object sender, EventArgs e)
        {
            tclReports.SelectedIndex = 0;

            // connect to DB
            cnn = DatabaseL.GetConnection();
            // test connection 
            try
            {
                cnn.Open();
                cnn.Close();
            }
            catch (SqlException err)
            {
                // display error message 
                rtxReportErr.Clear();
                rtxReportErr.Text = err.Message;
            }

            // populate colour combobox
            pColour();

            // populate transctions combobox
            pTransactions();

            // Disable print and export buttons
            btnExport.Enabled = false;
            btnPrint.Enabled = false;
        }



        // =====================================================
        // Functions 
        // =====================================================
        // Display data on pipe details in report block
        private void displayData(String sql)
        {
            try
            {
                // clear err
                rtxReportErr.Clear();
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                var ds = new DataSet();

                adap.Fill(ds);
                dgvReportView.DataSource = ds.Tables[0];


                dgvReportView.Columns[0].HeaderText = "ID";
                dgvReportView.Columns[1].HeaderText = "Quantity";
                dgvReportView.Columns[2].HeaderText = "Colour";
                dgvReportView.Columns[3].HeaderText = "Length";
                dgvReportView.Columns[4].HeaderText = "Diameter";

                if ((dgvReportView.RowCount * dgvReportView.RowTemplate.Height) <= 362)
                {
                    dgvReportView.Height = dgvReportView.RowCount * dgvReportView.RowTemplate.Height + 35;
                }
                

                cnn.Close();
            }
            catch (SqlException err)
            {
                // display error message 
                rtxReportErr.Clear();
                rtxReportErr.Text = err.Message;
            }
        }

        // Populate colours combo box
        private void pColour()
        {
            try
            {
                // clear err
                rtxReportErr.Clear();
                cnn.Open();
                cmd = new SqlCommand("SELECT * FROM [Colours]", cnn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbxColour.Items.Add(reader[1]);
                }

                cnn.Close();
            }
            catch (SqlException err)
            {
                // display error message 
                rtxReportErr.Clear();
                rtxReportErr.Text = err.Message;
            }
        }

        private void pTransactions()
        {
            cnn.Open();

            string SQL = "SELECT transaction_id " +
                         "FROM Transactions " +
                         "ORDER BY transaction_id DESC";

            cmd = new SqlCommand(SQL, cnn);

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbxGenTransID.Items.Add(reader.GetValue(0));
            }

            cnn.Close();
        }

        // validate data field and generate sql statement
        private String buildSql()
        {
            // variables 
            Boolean valid = true;
            int minQty = 0;
            int maxQty = 0;
            int minLength = 0;
            int maxLength = 0;
            String sort = "";
            String order = "";
            String color = "";
            String err = "";

            if (cbxColour.SelectedIndex != -1)
            {
                color = cbxColour.SelectedItem.ToString();
            }

            if (rbnPipeColour.Checked)
            {
                sort = "c.colour_code";
            }
            else if (rbnPipeLength.Checked)
            {
                sort = "s.pipe_length";
            }
            else if (rbnPipeQuantity.Checked)
            {
                sort = "d.pipe_quantity";
            }
            else if (rbnPipeDiameter.Checked)
            {
                sort = "s.pipe_diameter";
            }
            else
            {
                sort = "d.pipe_id";
            }

            if (rbnDESC.Checked)
            {
                order = "DESC";
            }
            else
            {
                order = "ASC";
            }

            // -----------------------
            // validate datafields 
            // -----------------------



            // Quantity
            if (txtQuantityLow.Text != "")
            {
                if (!int.TryParse(txtQuantityLow.Text, out minQty))
                {
                    err += "Enter a valid integer for Quantity | low\n";
                    valid = false;
                }
            }
            if (txtQuantityHigh.Text != "")
            {
                if (!int.TryParse(txtQuantityHigh.Text, out maxQty))
                {
                    err += "Enter a valid integer for Quantity | High\n";
                    valid = false;
                }
            }
            if (maxQty != 0 && minQty != 0)
            {
                if (maxQty < minQty)
                {
                    err += "Quantity | low can't be higher that Quantity | High\n";
                    valid = false;
                }
            }

            // Length
            if (txtLengthLow.Text != "")
            {
                if (!int.TryParse(txtLengthLow.Text, out minLength))
                {
                    err += "Enter a valid integer for Length | low\n";
                    valid = false;
                }
            }
            if (txtLengthHigh.Text != "")
            {
                if (!int.TryParse(txtLengthHigh.Text, out maxLength))
                {
                    err += "Enter a valid integer for Length | High\n";
                    valid = false;
                }
            }
            if (maxLength != 0 && minLength != 0)
            {
                if (maxLength < minLength)
                {
                    err += "Length | low can't be higher that Length | High\n";
                    valid = false;
                }
            }

            String sql = "";
            String sqlFilter = "";
            String sqlOrder = "";

            if (valid)
            {
                sql += "SELECT d.pipe_id, d.pipe_quantity, c.colour_code, s.pipe_length, s.pipe_diameter ";
                sql += "FROM [Pipe Details] AS d ";
                sql += "LEFT JOIN [Colours] AS c ON d.colour_id=c.colour_id ";
                sql += "LEFT JOIN [Pipe Size] AS s ON d.size_id=s.size_id ";

                // -------------------
                // FILTER
                // -------------------

                if (minQty != 0) { sqlFilter += "d.pipe_quantity >= " + minQty + " AND "; }
                if (maxQty != 0) { sqlFilter += "d.pipe_quantity <= " + maxQty + " AND "; }
                if (minLength != 0) { sqlFilter += "s.pipe_length >= " + minLength + " AND "; }
                if (maxLength != 0) { sqlFilter += "s.pipe_length <= " + maxLength + " AND "; }
                if (color != "") { sqlFilter += "c.colour_code LIKE '" + color + "' AND "; }
                // add to sql 
                if (sqlFilter != "")
                {
                    sqlFilter = "WHERE " + sqlFilter + " ";
                    // remove exstra AND
                    sql += sqlFilter.Substring(0, sqlFilter.Length - 5);
                    isFilterUsed = true;
                }
                else
                {
                    isFilterUsed = false;
                }

                // -------------------
                // ORDER
                // -------------------
                if (sort != "") { sqlOrder += "ORDER BY " + sort + " " + order + " "; }
                // add to sql 
                if (sqlOrder != "")
                {
                    sql += sqlOrder;
                }

                // -------------------
                // finish up
                // -------------------
                sql += ";";
            }
            else
            {
                // display error message 
                rtxReportErr.Clear();
                rtxReportErr.Text = err;
            }

            return sql;
        }

        // Calculate total stock
        private int calcTotalStock()
        {
            // Count total stock
            int totalStock = 0;
            for (int i = 0; i < dgvReportView.Rows.Count; ++i)
            {
                totalStock += Convert.ToInt32(dgvReportView.Rows[i].Cells[1].Value);
            }

            return totalStock;
        }

        // =====================================================
        // Buttons 
        // =====================================================
        // Requset data from DB
        private void btnRequest_Click(object sender, EventArgs e)
        {
            String sql = buildSql();
            // display data 
            if (sql != "")
            {
                displayData(sql);
            }

            btnExport.Enabled = true;
            btnPrint.Enabled = true;
        }

        // Export DGV to CSV
        private void btnExport_Click(object sender, EventArgs e)
        {

            // Variables
            Excel._Application app = new Excel.Application();
            Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = null;

            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Stock Details";

            // Check if data is filtered
            if (isFilterUsed)
            {
                worksheet.Cells[1, 1].Value = "Stock Report (Filtered)";
            }
            else
            {
                worksheet.Cells[1, 1].Value = "Stock Report";
            }
                
            worksheet.Cells[1,3].Value = DateTime.Today.ToLongDateString();

            // Populate the data from datagridview into the worksheet
            for (int i = 1; i < dgvReportView.Columns.Count + 1; i++)
            {
                worksheet.Cells[3, i] = dgvReportView.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvReportView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvReportView.Columns.Count; j++)
                {

                    worksheet.Cells[i + 4, j + 1] = dgvReportView.Rows[i].Cells[j].Value.ToString();

                }
            }

            worksheet.Cells[dgvReportView.Rows.Count + 4, 1] = "Stock total: ";
            worksheet.Cells[dgvReportView.Rows.Count + 4, 2] = calcTotalStock().ToString();
            worksheet.Cells[dgvReportView.Rows.Count + 6, 1] = "**END OF REPORT**";
        }
        
        // Print dgv Output
        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            //Resize DataGridView to full height.
            int height = dgvReportView.Height;
            dgvReportView.Height = dgvReportView.RowCount * dgvReportView.RowTemplate.Height + 35;



            //Create a Bitmap and draw the DataGridView on it.
            bmpData = new Bitmap(dgvReportView.Width, dgvReportView.Height);
            dgvReportView.DrawToBitmap(bmpData, new Rectangle(0, 0, dgvReportView.Width, dgvReportView.Height));



            //Show the Print Preview Dialog.
            ppPreview.Width = 900;
            ppPreview.Height = 740;
            ppPreview.PrintPreviewControl.Zoom = 1;
            ppPreview.Document = printDoc;
            ppPreview.ShowDialog();

            
            //Resize DataGridView back to original height.
            dgvReportView.Height = height;

        }

        // Print page
        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmpLogo = Properties.Resources.Logo2;
            Image imgLogo = bmpLogo;

            Bitmap bmpLine = Properties.Resources.Dot_Blue;
            Image imgLine = bmpLine;

            if (isFilterUsed)
            {
                bmpFilter = new Bitmap(gbxFilterBy.Width, gbxFilterBy.Height);
                gbxFilterBy.DrawToBitmap(bmpFilter, new Rectangle(0, 0, gbxFilterBy.Width, gbxFilterBy.Height));

                e.Graphics.DrawString("Exception Stock Report", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(250, 25));
                e.Graphics.DrawImage(bmpFilter, 100, 150);
                e.Graphics.DrawImage(bmpData, 100, 375);
                e.Graphics.DrawString("Stock total (Filtered): " + calcTotalStock(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(100, (430 + dgvReportView.Height)));
                e.Graphics.DrawString("**END OF REPORT**", new Font("Arial", 14, FontStyle.Italic), Brushes.Black, new Point(500, (450 + dgvReportView.Height)));
            }
            else
            {
                e.Graphics.DrawString("Detailed Stock Report", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(250, 25));
                e.Graphics.DrawImage(bmpData, 100, 150);
                e.Graphics.DrawString("Stock total: " + calcTotalStock(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(100, (180 + dgvReportView.Height)));
                e.Graphics.DrawString("**END OF REPORT**", new Font("Arial", 14, FontStyle.Italic), Brushes.Black, new Point(500, (200 + dgvReportView.Height)));
            }

            //Print the contents.        <>    ^^ 
            e.Graphics.DrawString(DateTime.Today.ToLongDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, 30));

            e.Graphics.DrawImage(imgLogo, 0, 0, 216, 93);
            e.Graphics.DrawImage(bmpLine, -20, 95, 900, 2);
        }

        private void btnPrintSlip_Click(object sender, EventArgs e)
        {

            //Create a Bitmap and draw the lblReport on it.
            bmpSlip = new Bitmap(lbReport.Width, lbReport.Height);
            lbReport.DrawToBitmap(bmpSlip, new Rectangle(0, 0, lbReport.Width, lbReport.Height));



            //Show the Print Preview Dialog.
            ppPreviewSlip.Width = 900;
            ppPreviewSlip.Height = 740;
            ppPreviewSlip.PrintPreviewControl.Zoom = 1;
            ppPreviewSlip.Document = printSlip;
            ppPreviewSlip.ShowDialog();

        }

        private void printSlip_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmpSlip, 100, 100);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLengthLow.Clear();
            txtLengthHigh.Clear();
            txtQuantityHigh.Clear();
            txtQuantityLow.Clear();
            cbxColour.SelectedIndex = -1;

            rbnASC.Checked = false;
            rbnDESC.Checked = false;

            rbnPipeID.Checked = false;
            rbnPipeColour.Checked = false;
            rbnPipeLength.Checked = false;
            rbnPipeQuantity.Checked = false;
            rbnPipeDiameter.Checked = false;

            dgvReportView.Columns.Clear();

            btnExport.Enabled = false;
            btnPrint.Enabled = false;
        }

        private void cbxGenTransID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string answer;
            string align = "{0,-14}\t{1,-12}\t{2,-10}\t {3,-9}\t {4,-9}";
            string alignData = "{0,-14}\t{1,-12}\t{2,-10}\t {3,-9}\t {4,-9}";


            cnn.Open();

            string SQL = "SELECT t.transaction_id, t.trans_quantity, t.trans_date, t.isCompleted, e.staff_name, e.staff_lastname, e.staff_cell, c.colour_code, s.pipe_length, s.pipe_diameter, sd.staff_name, sd.staff_lastname, sd.staff_cell, d.dispatch_delivery_date, d.dispatch_quantity, d.dispatch_location ";
                   SQL += "FROM [Transactions] AS t ";
                   SQL += "LEFT JOIN [Staff] AS e ON t.staff_id = e.staff_id ";
                   SQL += "LEFT JOIN [Pipe Details] AS pd ON t.pipe_id = pd.pipe_id ";
                   SQL += "LEFT JOIN [Colours] AS c ON pd.colour_id = c.colour_id ";
                   SQL += "LEFT JOIN [Pipe Size] AS s ON pd.size_id = s.size_id ";
                   SQL += "LEFT JOIN [Dispatch] AS d ON t.dispatch_id = d.dispatch_id ";
                   SQL += "LEFT JOIN [Staff] AS sd ON  d.staff_id = sd.staff_id ";
                   SQL += $"WHERE t.transaction_id = {cbxGenTransID.SelectedItem} ";
                   
            try
            {
                cmd = new SqlCommand(SQL, cnn);

                reader = cmd.ExecuteReader();
                reader.Read();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message.ToString() + "\n" + error.ToString());
            }

            DateTime trans_date = DateTime.Parse(reader["trans_date"].ToString());
            DateTime delivery_date = DateTime.Parse(reader["dispatch_delivery_date"].ToString());

            if ((Boolean)reader.GetValue(3) == true)
            {
                answer = "Yes";
            }
            else
            {
                answer = "No";
            }

            // Creating and setting the
            // properties of ListBox

            lbReport.Items.Clear();
            lbReport.Items.Add(" Transaction Slip");
            lbReport.Font = new Font("Nirmala UI Semilight", 12);
            lbReport.Items.Add("\t\t \t \t \t \t \t" + DateTime.Today.ToShortDateString());
            lbReport.Items.Add("______________________________________________________________________________________________");
            lbReport.Items.Add("Date of transaction: " + trans_date.ToShortDateString());
            lbReport.Items.Add("");
            lbReport.Items.Add(string.Format(align, "Transaction ID", "Lenght", "Diameter", "Colour", "Quantity"));
            lbReport.Items.Add(string.Format(alignData, reader["transaction_id"].ToString() + "   \t   ", reader["pipe_length"].ToString(), reader["pipe_diameter"].ToString() + " ", reader["colour_code"].ToString(), reader["trans_quantity"].ToString()));
            lbReport.Items.Add("");
            lbReport.Items.Add("Employee responsible:");
            lbReport.Items.Add("");
            lbReport.Items.Add(string.Format(align, "Name", "Lastname", "Cell", "", ""));
            lbReport.Items.Add(string.Format(alignData, reader["staff_name"].ToString() , reader["staff_lastname"].ToString() + "\t", reader["staff_cell"].ToString() + " ", "", ""));
            lbReport.Items.Add("");
            lbReport.Items.Add("______________________________________________________________________________________________");

            lbReport.Items.Add("Dispatch:");
            lbReport.Items.Add("");
            lbReport.Items.Add("Due for delivery on: " + delivery_date.ToShortDateString());
            lbReport.Items.Add("");
            lbReport.Items.Add(string.Format(align, "Location", "Quantity ready", "", "", ""));
            lbReport.Items.Add(string.Format(alignData, reader["dispatch_location"].ToString(), reader["dispatch_quantity"].ToString(), "", "", ""));
            lbReport.Items.Add("");
            lbReport.Items.Add("Dispatch responsible:");
            lbReport.Items.Add("");
            lbReport.Items.Add(string.Format(align, "Name", "Lastname", "Cell", "", ""));
            lbReport.Items.Add(string.Format(alignData, reader.GetValue(10).ToString(), reader.GetValue(11).ToString() + "\t", reader.GetValue(12).ToString() + " ", "", ""));
            lbReport.Items.Add("______________________________________________________________________________________________");
            lbReport.Items.Add("Is the transaction complete: " + answer);
            lbReport.Items.Add("");
            lbReport.Items.Add("\t\t\t **END OF SLIP** \t\t");

            cnn.Close();
        }
    }
}
