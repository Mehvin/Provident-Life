using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    class PeriodicIPBuilder : IPBuilder
    {
        private int periodicDays;

        public PeriodicIPBuilder SetPeriodicDays(int periodicDays)
        {
            this.periodicDays = periodicDays;

            return this;
        }

        public override InsurancePolicy build()
        {
            return new PeriodicInsurancePolicy(
                termsAndConds,
                startDate,
                maturedDate,
                client,
                employee,
                riders,
                periodicDays
            );
        }
    }
}
