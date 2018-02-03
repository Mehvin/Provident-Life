using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife.Classes
{
    class PeriodicInsurancePolicy : InsurancePolicy
    {
        private int periodicDays;

        public PeriodicInsurancePolicy(
            int policyID,
            List<string> termsAndCond,
            DateTime startDate,
            DateTime maturedDate,
            Client client,
            Employee employee,
            List<Rider> riders,
            int periodicDays) : base(policyID, termsAndCond, startDate, maturedDate, client, employee, riders)
        {
            this.periodicDays = periodicDays;
        }

        public override Premium GetPremium()
        {
            // fee / days?
            throw new NotImplementedException();
        }
    }
}
