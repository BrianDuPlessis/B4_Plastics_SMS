using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B4_Plastics_SMS
{
    public partial class CalculateLoad : Form
    {
        public CalculateLoad()
        {
            InitializeComponent();
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            lbDisplay.Items.Clear();
            double truck_volume, pipe_volume;
            int length_total, total_pipes;


            if (double.TryParse(txtPipeLength.Text, out double pipe_length))
            {
                if (double.TryParse(txtPipeDiameter.Text, out double pipe_diameter))
                {
                    if (double.TryParse(txtTruckLength.Text, out double truck_length))
                    {
                        if (double.TryParse(txtTruckWidth.Text, out double truck_width))
                        {
                            if (double.TryParse(txtTruckHeight.Text, out double truck_height))
                            {
                                if (pipe_length <= truck_length)
                                {
                                    length_total = (int)(truck_length / pipe_length);
                                    truck_volume = length_total * pipe_length * truck_width * truck_height;
                                    pipe_volume = Math.PI * Math.Pow((pipe_diameter / 100 / 2), 2) * pipe_length;

                                    total_pipes = (int)(truck_volume / pipe_volume);

                                    lbDisplay.Items.Add("The total amount of pipes that can be loaded is: " + total_pipes);

                                }
                                else
                                {
                                    lbDisplay.Items.Add("The pipe length (" + pipe_length + " m) is too long for the truck (" + truck_length + " m).");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter a number for Truck Height.", "Invalid input.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtTruckHeight.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a number for Truck Width.", "Invalid input.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtTruckWidth.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter a number for Truck Length.", "Invalid input.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTruckLength.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a number for Pipe Diameter.", "Invalid input.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPipeDiameter.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a number for Pipe Length.", "Invalid input.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPipeLength.Focus();
            }
        
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPipeLength.Clear();
            txtPipeDiameter.Clear();
            txtTruckLength.Clear();
            txtTruckHeight.Clear();
            txtTruckWidth.Clear();
            lbDisplay.Items.Clear();

            txtPipeLength.Focus();
        }
    }
}
