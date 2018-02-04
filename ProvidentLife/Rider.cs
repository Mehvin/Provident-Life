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
        private string policyType;
        private string description;
        private double payOutAmount;
        private List<string> termsAndConds;
        private double totalAmountPayable;

        //Associations
        private InsurancePolicy insurancePolicy;
        private List<Premium> premiumList;

        public Rider(int riderID, string policyType, string description, double payOutAmount, double totalamountpayable, InsurancePolicy ip, List<Premium> pL)
        {
            this.riderID = riderID;
            this.policyType = policyType;
            this.description = description;
            this.payOutAmount = payOutAmount;
            this.totalAmountPayable = totalamountpayable;
            this.insurancePolicy = ip;
            this.premiumList = pL;
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

    }
}
