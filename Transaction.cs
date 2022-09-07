using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4_Plastics_SMS
{
    class Transaction 
    {
        private int quantity;
        private DateTime paymentDate;
        bool isCompleted;

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public void setPaymentDate(DateTime paymentDate)
        {
            this.paymentDate = paymentDate;
        }

        public int getQuantity()
        {
            return quantity;
        }
        public DateTime getPaymentDate()
        {
            return paymentDate;
        }

        public string generateSlip()
        {
            string slip = "";
            return slip;
        }
    }
}
