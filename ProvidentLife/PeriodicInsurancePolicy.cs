using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife.Classes
{
    class PeriodicInsurancePolicy : InsurancePolicy
    {
        private int days;
        private int periodicDays;

        public override Premium GetPremium()
        {
            // fee / days?
            throw new NotImplementedException();
        }
    }
}
