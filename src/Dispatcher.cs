using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4_Plastics_SMS
{
    class Dispatcher : Worker
    {
        bool delivered = false;
        private int quantity;
        private string deliveryDestination;
        private DateTime deliveryDate;

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public void setDeliveryDestination(string deliveryDestination)
        {
            this.deliveryDestination = deliveryDestination;
        }

        public void setDeliveryDate(DateTime deliveryDate)
        {
            this.deliveryDate = deliveryDate;
        }

        public int getQuantity()
        {
            return quantity;
        }
        public string getDeliveryDistination()
        {
            return deliveryDestination;
        }

        public DateTime getDeliveryDate()
        {
            return deliveryDate;
        }

        public double calcLoad(int x, int y, int h)
        {
            double volume = 0;

            return volume;
        }

        public void completeTransaction()
        {

        }

        public string toString()
        {
            string result = String.Format("%s %s -8d %s", deliveryDate.ToShortDateString(), quantity, deliveryDestination);
            return result;
        }
    }
}
