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
    }
}
