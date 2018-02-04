using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    class Client
    {
        private static int ID = 0;

        private int clientID;
        private string name;
        private int accountID;
        private string address;

        // Associations
        private IPCollection ipCollection;

        public Client(string name, int accountID, string address)
        {
            this.clientID = ID++;
            this.name = name;
            this.accountID = accountID;
            this.address = address;

            this.ipCollection = new IPCollection();
        }

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

        public void setAddress(string address)
        {
            this.address = address;
        }

        public IPCollection getIPCollection()
        {
            return ipCollection;
        }
    }
}
