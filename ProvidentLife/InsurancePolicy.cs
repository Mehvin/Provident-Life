using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProvidentLife.Classes;

namespace ProvidentLife
{
    abstract class InsurancePolicy
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

        public abstract Premium GetPremium();

        public int GetPolicyID()
        {
            return policyID;
        }

        public void SetPolicyID(int pd)
        {
            policyID = pd;
        }

        public List<string> GetTermsCond()
        {
            return termsCond;
        }

        public void SetTermsCond(List<string> termsCond)
        {
            this.termsCond = termsCond;
        }

        public string GetStatus()
        {
            return status;
        }

        public void SetStatus(string status)
        {
            this.status = status;
        }
    
        public DateTime GetStartDate()
        {
            return startDate;
        }

        public void SetStartDate(DateTime startDate)
        {
            this.startDate = startDate;
        }

        public DateTime GetMaturityDate()
        {
            return maturityDate;
        }

        public void SetMaturityDate(DateTime maturityDate)
        {
            this.maturityDate = maturityDate;
        }

        public double GetTotalAmount()
        {
            return totalAmount;
        }

        public void SetTotalAmount(double totalAmount)
        {
            this.totalAmount = totalAmount;
        }

        public double GetFee()
        {
            return fee;
        }

        public void SetFee(double fee)
        {
            this.fee = fee;
        }
    }
}
