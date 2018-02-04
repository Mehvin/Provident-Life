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

        //Associations
        private List<Premium> premiumList;
        private List<InsurancePolicy> insurancePolicyList;

        public Client(int clientID, string name, int accountID, string address, List<Premium> pList, List<InsurancePolicy> ipList)
        {
            this.clientID = clientID;
            this.name = name;
            this.accountID = accountID;
            this.address = address;
            this.premiumList = pList;
            this.insurancePolicyList = ipList;
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

        public void getAddress(string address)
        {
            this.address = address;
        }
    }
}
