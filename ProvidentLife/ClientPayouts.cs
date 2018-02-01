using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife.Classes
{
    class ClientPayouts : Iterator
    {
        private List<Payout> payouts = new List<Payout>();

        public ClientPayouts()
        {
            this.payouts = new List<Payout>();
        }

        public List<Payout> GetSortedRecent()
        {
            throw new NotImplementedException();
        }

        public List<Payout> GetSortedHighest()
        {
            throw new NotImplementedException();
        }

        public List<Payout> GetSortedLowest()
        {
            throw new NotImplementedException();
        }

        public bool HasNext()
        {
            throw new NotImplementedException();
        }

        public object Next()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
