using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife.Classes
{
    class OneTimeIPBuilder : IPBuilder
    {
        public override InsurancePolicy Build()
        {
            return new OneTimeInsurancePolicy(
                0,
                termsAndConds,
                startDate,
                maturedDate,
                client,
                employee,
                riders
            );
        }
    }
}
