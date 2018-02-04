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
        private string Name;
        private int policiesSold;
        private double commissionPercent;
        private string agentRank;
        private bool isAdmins;

        public static string SENIOR_RANK = "SENIOR";
        public static string JUNIOR_RANK = "JUNIOR";
        public static string NORMAL_RANK = "NORMAL";

        //Associations
        private List<InsurancePolicy> insurancePolicyList;

        public Employee(int agentID, string name, string agentRank, bool isAdmin, List<InsurancePolicy> iP)
        {
            this.agentID = agentID;
            this.Name = name;
            this.policiesSold = 0;
            this.commissionPercent = 0;
            this.agentRank = agentRank;
            this.isAdmins = isAdmin;
            this.insurancePolicyList = iP
        }

        public double CalculatePay()
        {
            return 0.0 ; //implementation
        }

        public string GetRank()
        {
            return agentRank;
        }

        public void SetRank(string rank)
        {
            agentRank = rank;
        }

        public bool isAdmin()
        {
            return isAdmins;
        }

        public void setIsAdmin(bool isAdmin)
        {
            this.isAdmins = isAdmin;
        }
    }
}
