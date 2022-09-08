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
    public partial class Reports: Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        // =====================================================
        // Global Variables  
        // =====================================================

        String cnnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oswald.slabbert\Documents\GitHub\B4_Plastics_SMS\B4Plastics.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection cnn;


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
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                var ds = new DataSet();

                adap.Fill(ds);
                dgvReportView.DataSource = ds.Tables[0];

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
                SqlCommand cmd = new SqlCommand("SELECT * FROM \"Colours\"", cnn);
                SqlDataReader reader = cmd.ExecuteReader();

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

        // validate data field and generate sql statement
        private String buildSql()
        {
            // variables 
            Boolean valid = true;
            int minPrice = 0;
            int maxPrice = 0; ;
            int minQty = 0; ;
            int maxQty = 0; ;
            int minLength = 0; ;
            int maxLength = 0; ;
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
                sort = "d.pipe_price";
            }

            if (rbnASC.Checked)
            {
                order = "ASC";
            }
            else
            {
                order = "DESC";
            }

            // -----------------------
            // validate datafields 
            // -----------------------

            // Price
            if (txtPriceLow.Text != "")
            {
                if (!int.TryParse(txtPriceLow.Text, out minPrice))
                {
                    err += "Enter a valid integer for Price | low\n";
                    valid = false;
                }
            }
            if (txtPriceHigh.Text != "")
            {
                if (!int.TryParse(txtPriceHigh.Text, out maxPrice))
                {
                    err += "Enter a valid integer for Price | High\n";
                    valid = false;
                }
            }
            if (minPrice != 0 && maxPrice != 0)
            {
                if (maxPrice < minPrice)
                {
                    err += "Price | low can't be higher that Price | High\n";
                    valid = false;
                }
            }

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
                sql += "SELECT d.pipe_id, d.pipe_quantity, d.pipe_price, c.colour_code, s.pipe_length, s.pipe_diameter ";
                sql += "FROM \"Pipes Detials\" AS d ";
                sql += "LEFT JOIN \"Colours\" AS c ON d.colour_id=c.colour_id ";
                sql += "LEFT JOIN \"Pipe Size\" AS s ON d.size_id=s.size_id ";

                // -------------------
                // FILTER
                // -------------------
                if (minPrice != 0) { sqlFilter += "d.pipe_price >= " + minPrice + " AND "; }
                if (maxPrice != 0) { sqlFilter += "d.pipe_price <= " + maxPrice + " AND "; }
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

        // Generate CSV
        private String[] buildCSV()
        {
            // variables 
            String[] csv = new string[dgvReportView.Rows.Count +1];
            String columns = "";
            int columnCount = dgvReportView.Columns.Count;
            if (dgvReportView.Rows.Count != 0)
            {
                for (int i = 0; i < columnCount; i++)
                {
                    columns += dgvReportView.Columns[i].HeaderText.ToString() + ";";
                }
                // add to csv
                csv[0] = columns;
                for (int i = 0; i < dgvReportView.Rows.Count -1; i++)
                {
                    for (int k = 0; k < columnCount; k++)
                    {
                        csv[i + 1] += dgvReportView.Rows[i].Cells[k].Value.ToString() + ";";
                    }
                }
            }
            return csv;
        }

        // Print page
        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Print the contents.
            e.Graphics.DrawImage(bitmap, 0, 0);
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
        }
        // Form load 
        private void Reports_Load(object sender, EventArgs e)
        {
            // connect to DB
            cnn = new SqlConnection(cnnString);
            // test connection 
            try
            {
                cnn.Open();
                cnn.Close();
            } catch (SqlException err)
            {
                // display error message 
                rtxReportErr.Clear();
                rtxReportErr.Text = err.Message;
            }

            // populate colour combobox
            pColour();
        }

        // Export DGV to CSV
        private void btnExport_Click(object sender, EventArgs e)
        {
            // variabels 
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Export.csv";
            bool fileError = false;

            String[] csv = buildCSV();

            // write CSV
            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        File.WriteAllLines(sfd.FileName, csv, Encoding.UTF8);
                        MessageBox.Show("Export.csv Secsesfully saved", "Info");
                    }
                }
            } catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "File Save Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        Bitmap bitmap;
        // Print dgv Output
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Resize DataGridView to full height.
            int height = dgvReportView.Height;
            dgvReportView.Height = dgvReportView.RowCount * dgvReportView.RowTemplate.Height;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(this.dgvReportView.Width, this.dgvReportView.Height);
            dgvReportView.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dgvReportView.Width, this.dgvReportView.Height));

            //Resize DataGridView back to original height.
            dgvReportView.Height = height;

            //Show the Print Preview Dialog.
            ppPreview.Document = printDoc;
            ppPreview.PrintPreviewControl.Zoom = 1;
            ppPreview.ShowDialog();
        }
    }
}
