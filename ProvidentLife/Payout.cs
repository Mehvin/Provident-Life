using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife.Classes
{
    class Payout
    {
        private double amount;
        private DateTime date;

        public double getAmount()
        {
            return amount;
        }

        public void setAmount(double a)
        {
            amount = a;
        }

        public DateTime getDate()
        {
            return date;
        }

        public void setDate(DateTime d)
        {
            date = d;
        }
    }
}
