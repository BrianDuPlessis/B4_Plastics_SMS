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
    public partial class Reports: Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        // =====================================================
        // Buttons 
        // =====================================================
        private void btnRequest_Click(object sender, EventArgs e)
        {
            String sql = buildSql();
        }

        // =====================================================
        // Functions 
        // =====================================================

        private void displayData()
        {
            // varables 

        }

        // validate data field 
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
                sort = "colour";
            } else if (rbnPipeLength.Checked)
            {
                sort = "length";
            }
            else if (rbnPipeQuantity.Checked)
            {
                sort = "quantity";
            }
            else if (rbnPipeDiameter.Checked)
            {
                sort = "diameter";
            }
            else
            {
                sort = "price";
            }

            if (rbnASC.Checked)
            {
                order = "ASC";
            } else
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
            String sqlSort = "";

            if (valid)
            {
                sql += "SELECT d.pipe_id, d.pipe_quantity, d.pipe_price, c.colour_code, s.pipe_length, s.pipe_diameter ";
                sql += "FROM 'Pipes Details' AS d ";
                sql += "LEFT JOIN 'Colours' AS c ON d.colour_id=c.colour_id ";
                sql += "LEFT JOIN 'Pipe Size' AS s ON d.size_id=s.size_id ";

                if (minPrice != 0)
                {
                    if (sqlSort == "")
                    {
                        sqlSort += "WHERE ";
                    }
                }        

            } else
            {
                // display error message 
                rtxReportPreview.Clear();
                rtxReportPreview.Text = err;
            }
            
            return sql;
        }
    }
}
