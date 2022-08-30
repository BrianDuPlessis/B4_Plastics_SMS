using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4_Plastics_SMS
{
    class Person
    {
        private string name;
        private string phoneNumber;
        private string username;
        private string password;

        public Person() { }

        public Person(string name, string phoneNumber, string username, string password)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.username = username;
            this.password = password;
        }

        //Accessors
        public void setName(string name)
        {
            this.name = name;
        }
        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        public void setUserName(string username)
        {
            this.username = username;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
       
        //Mutators
        public string getName()
        {
            return name;
        }
        public string getPhoneNumber()
        {
            return phoneNumber;
        }
        public string getUserName()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }

        //Auxilliary-methods
        public Boolean checkLoginDetails(string username, string password)
        {
            if(this.username == username && this.password == password)
            {
                return true;
            }
            return false;
        }

    }
}
