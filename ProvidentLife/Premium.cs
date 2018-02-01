using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife.Classes
{
    class Premium
    {
        private int id;
        private double amountPayable;
        private DateTime dueDate;

        private InsurancePolicy policy;

        public Premium(int id, double amountPayable, DateTime dueDate, InsurancePolicy policy)
        {
            this.id = id;
            this.amountPayable = amountPayable;
            this.dueDate = dueDate;
            this.policy = policy;
        }

        public int GetId()
        {
            return id;
        }

        public double GetAmountPayable()
        {
            return amountPayable;
        }

        public DateTime GetDueDate()
        {
            return dueDate;
        }

        public InsurancePolicy GetInsurancePolicy()
        {
            return policy;
        }
    }
}
