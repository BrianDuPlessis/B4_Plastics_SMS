using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4_Plastics_SMS
{
    class Machine
    {
        private DateTime serviceDate;
        bool status;
        double capacity;

        public void setServiceDate(DateTime serviceDate)
        {
            this.serviceDate = serviceDate;
        }

        public DateTime getServiceDate()
        {
            return serviceDate;
        }

        public double calcEfficiency()
        {
            double efficiency = 0;
            return efficiency;
        }

        public int calTotalWorkTime()
        {
            int workTime = 0;
            return workTime;
        }

        public double calcKGProduced()
        {
            double produced = 0;
            return produced;
        }
    }
}
