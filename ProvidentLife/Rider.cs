using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProvidentLife.Classes;

namespace ProvidentLife
{
    class Rider
    {
        private int riderID;
        private string name;

        private Client client;

        public Rider(int riderID, string name, Client client)
        {
            this.riderID = riderID;
            this.name = name;
            this.client = client;
        }

        public int GetRiderID()
        {
            return riderID;
        }

        public string GetName()
        {
            return name;
        }

        public Client GetClient()
        {
            return client;
        }
    }
}
