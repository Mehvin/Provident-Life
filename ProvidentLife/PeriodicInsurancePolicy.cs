using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    class PeriodicInsurancePolicy : InsurancePolicy
    {
        private int periodicDays;

        public PeriodicInsurancePolicy(
            List<string> termsAndCond,
            DateTime startDate,
            DateTime maturedDate,
            Client client,
            Employee employee,
            List<Rider> riders,

            int periodicDays) : base(termsAndCond, startDate, maturedDate, client, employee, riders)
        {
            this.periodicDays = periodicDays;
        }

        public int getPeriodicDays()
        {
            return this.periodicDays;
        }

        public override Premium getPremium()
        {
            // fee / days?
            throw new NotImplementedException();
        }
    }
}
