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

        public double GetAmount()
        {
            return amount;
        }

        public void SetAmount(double amount)
        {
            this.amount = amount;
        }

        public DateTime GetDate()
        {
            return date;
        }

        public void SetDate(DateTime date)
        {
            this.date = date;
        }
    }
}
