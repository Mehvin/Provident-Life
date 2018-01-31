﻿using System;
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

        static public string SENIOR;
        static public string JUNIOR;
        static public string NORMAL;

        public double calculatePay()
        {
            return 0.0 ; //implementation
        }

        public string getRank()
        {
            return agentRank;
        }

        public void setRank(string rank)
        {
            agentRank = rank;
        }

        public bool getisAdmin()
        {
            return isAdmin;
        }

        public void setIsAdmin(bool iA)
        {
            isAdmin = iA;
        }
    }
}
