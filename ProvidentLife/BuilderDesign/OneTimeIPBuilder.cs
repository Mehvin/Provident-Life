using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    class OneTimeIPBuilder : IPBuilder
    {
        public override InsurancePolicy build()
        {
            return new OneTimeInsurancePolicy(
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
