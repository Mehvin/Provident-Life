using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife.Classes
{
    class Employee
    {
        private int agentID;
        private string name;
        private int policiesSold;
        private double commissionPercent;
        private string agentRank;
        private bool isAdmin;

        public static string SENIOR_RANK = "SENIOR";
        public static string JUNIOR_RANK = "JUNIOR";
        public static string NORMAL_RANK = "NORMAL";

        public Employee(int agentID, string name, string agentRank, bool isAdmin)
        {
            this.agentID = agentID;
            this.name = name;
            this.policiesSold = 0;
            this.commissionPercent = 0;
            this.agentRank = agentRank;
            this.isAdmin = isAdmin;
        }

        public double CalculatePay()
        {
            return 0.0 ; //implementation
        }

        public int GetPoliciesSold()
        {
            return policiesSold;
        }

        public double GetCommissionPercent()
        {
            return commissionPercent;
        }

        public string GetRank()
        {
            return agentRank;
        }

        public void SetRank(string rank)
        {
            agentRank = rank;
        }

        public bool GetIsAdmin()
        {
            return isAdmin;
        }

        public void SetIsAdmin(bool isAdmin)
        {
            this.isAdmin = isAdmin;
        }
    }
}
