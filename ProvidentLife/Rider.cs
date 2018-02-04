using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    class Rider
    {
        private int riderID;
        private string policyType;
        private string description;
        private double payOutAmount;
        private List<string> termsAndConds;
        private double totalAmountPayable;

        // Strategy
        private PayoutStrategy payoutStrategy;

        public Rider(int riderID, string policyType, string description, double payOutAmount, double totalAmountPayable, PayoutStrategy payoutStrategy)
        {
            this.riderID            = riderID;
            this.policyType         = policyType;
            this.description        = description;
            this.payOutAmount       = payOutAmount;
            this.totalAmountPayable = totalAmountPayable;
            this.payoutStrategy     = payoutStrategy;
        }

        public int getRiderID()
        {
            return riderID;
        }

        public string getDescription()
        {
            return description;
        }

        public double getPayOutAmount()
        {
            return payOutAmount;
        }

        public List<string> getTermsCond()
        {
            return termsAndConds;
        }

        public double getTotalAmountPayable()
        {
            return totalAmountPayable;
        }

        // Strategy pattern.
        public double performPayOut(string severity)
        {
            //implementation
            return payoutStrategy.performPayOut(severity);
        }
    }
}
