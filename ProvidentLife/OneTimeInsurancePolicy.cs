using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife.Classes
{
    class OneTimeInsurancePolicy : InsurancePolicy
    {
        public OneTimeInsurancePolicy(
            int policyID,
            List<string> termsAndCond,
            DateTime startDate,
            DateTime maturedDate,
            Client client,
            Employee employee,
            List<Rider> riders) : base(policyID, termsAndCond, startDate, maturedDate, client, employee, riders)
        {
        }

        public override Premium GetPremium()
        {
            // return a single premium
            throw new NotImplementedException();
        }
    }
}
