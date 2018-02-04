using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    class OneTimeInsurancePolicy : InsurancePolicy
    {
        public OneTimeInsurancePolicy(
            List<string> termsAndCond,
            DateTime startDate,
            DateTime maturedDate,
            Client client,
            Employee employee,
            List<Rider> riders) : base(termsAndCond, startDate, maturedDate, client, employee, riders)
        {
        }

        public override List<Premium> getPremiums()
        {
            // return a single premium
            throw new NotImplementedException();
        }
    }
}
