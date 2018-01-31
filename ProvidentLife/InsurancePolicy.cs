using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    class InsurancePolicy
    {
        private int policyID;
        private List <string> termsCond;
        private string policyType;
        private string status;
        private DateTime startDate;
        private DateTime maturityDate;
        private double totalAmount;
        // private PayoutHandler payoutHandler;
        private double fee;

        //public Payout performPayOut(string severity)

        public int getPolicyID()
        {
            return policyID;
        }

        public void setPolicyID(int pd)
        {
            policyID = pd;
        }

        public List<string> getTermsCond()
        {
            return termsCond;
        }

        public void setTermsCond(List<string> tc)
        {
            termsCond = tc;
        }

        public string getStatus()
        {
            return status;
        }

        public void setStatus(string s)
        {
            status = s;
        }
    
        public DateTime getStartDate()
        {
            return startDate;
        }

        public void setStartDate(DateTime sd)
        {
            startDate = sd;
        }

        public DateTime getMaturityDate()
        {
            return maturityDate;
        }

        public void setMaturityDate(DateTime md)
        {
            maturityDate = md;
        }

        public double getTotalAmount()
        {
            return totalAmount;
        }

        public void setTotalAmount(double ta)
        {
            totalAmount = ta;
        }

        public double getFee()
        {
            return fee;
        }

        public void setFee(double f)
        {
            fee = f;
        }
    }
}
