using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    class Client
    {
        private int clientID;
        private string name;
        private int accountID;
        private string address;

        public int getClientID()
        {
            return clientID;
        }

        public string getName()
        {
            return name;
        }

        public int getAccountID()
        {
            return accountID;
        }

        public string getAddress()
        {
            return address;
        }

        public void setAddress(string a)
        {
            address = a;
        }
    }
}
