using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4_Plastics_SMS
{
    abstract class Worker
    {
        string name;
        string phoneNumber;
        private string username;
        private string password;

        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }


        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }

        public Boolean checkLoginDetails()
        {
            return true;
        }
        public string toString()
        {
            string returnString = String.Format("%-8s %-15s", name, phoneNumber);
            return returnString;
        }
    }
}
