using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    class Employee
    {
        private int agentID;
        private string name;
        private int policiesSold = 0;
        private double commissionPercent = 0;
        private string agentRank;
        private bool isAdmin;

        public static string SENIOR_RANK = "SENIOR";
        public static string JUNIOR_RANK = "JUNIOR";
        public static string NORMAL_RANK = "NORMAL";

        // Strategy pattern
        private PayStrategy payStrategy;

        // Associations
        private IPCollection ipCollection;

        public Employee(int agentID, string name, string agentRank, bool isAdmin, PayStrategy payStrategy)
        {
            this.agentID = agentID;
            this.name = name;
            this.agentRank = agentRank;
            this.isAdmin = isAdmin;
            this.payStrategy = payStrategy;
            this.ipCollection = new IPCollection();
        }

        public double performCalculatePay()
        {
            // implementation
            Console.WriteLine("Calculating pay!");

            return payStrategy.calculatePay();
        }
        
        public int getAgentID()
        {
            return agentID;
        }

        public string getName()
        {
            return name;
        }

        public int getPoliciesSold()
        {
            return policiesSold;
        }

        public void setPoliciesSold(int policiesSold)
        {
            this.policiesSold = policiesSold;
        }

        public double getCommissionPercent()
        {
            return commissionPercent;
        }

        public void setCommissionPercent(double commissionPercent)
        {
            this.commissionPercent = commissionPercent;
        }

        public string getAgentRank()
        {
            return agentRank;
        }

        public void setAgentRank(string agentRank)
        {
            this.agentRank = agentRank;
        }

        public bool getIsAdmin()
        {
            return isAdmin;
        }

        public void setIsAdmin(bool isAdmin)
        {
            this.isAdmin = isAdmin;
        }

        public PayStrategy getPayStrategy()
        {
            return payStrategy;
        }

        public void setPayStrategy(PayStrategy payStrategy)
        {
            this.payStrategy = payStrategy;
        }

        public void addPolicy(InsurancePolicy policy)
        {
            ipCollection.addPolicy(policy);
        }

        public void removePolicy(InsurancePolicy policy)
        {
            ipCollection.removePolicy(policy);
        }
    }
}
