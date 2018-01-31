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

        public override Premium GetPremium()
        {
            throw new NotImplementedException();
        }
    }
}
