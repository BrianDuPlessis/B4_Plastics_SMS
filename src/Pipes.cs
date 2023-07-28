using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4_Plastics_SMS
{
    class Pipes
    {
        double lenght;
        double diameter;
        string colour_code;
        private int quantityInStock;

        public void setQuantityInStock(int quantityInStock)
        {
            this.quantityInStock = quantityInStock;
        }

        public int getQuantityInStock()
        {
            return quantityInStock;
        }
    }
}
