using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife.Classes
{
    class OneTimeInsurancePolicy : InsurancePolicy
    {
        public override Premium GetPremium()
        {
            // return a single premium
            throw new NotImplementedException();
        }
    }
}
