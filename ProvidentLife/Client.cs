using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProvidentLife.Classes;

namespace ProvidentLife
{
    class Client
    {
        private int clientID;
        private string name;
        private int accountID;
        private string address;

        private ClientPayouts clientPayouts;

        public Client(int clientID, string name, int accountID, string address)
        {
            this.clientID = clientID;
            this.name = name;
            this.accountID = accountID;
            this.address = address;

            this.clientPayouts = new ClientPayouts();
        }

        public int GetClientID()
        {
            return clientID;
        }

        public string GetName()
        {
            return name;
        }

        public int GetAccountID()
        {
            return accountID;
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }
    }
}
