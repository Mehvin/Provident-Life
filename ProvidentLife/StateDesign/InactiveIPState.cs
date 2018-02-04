using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    class InactiveIPState : IPState
    {
        private InsurancePolicy myPolicy;
        
        public InactiveIPState(InsurancePolicy policy)
        {
            myPolicy = policy;
        }

        public void payPeriodic()
        {
            Console.WriteLine("Policy cannot be paid periodically now!");
        }

        public void agentCancelPolicy()
        {
            Console.WriteLine("Policy already cancelled!");
        }

        public void agentLapsedPolicy()
        {
            Console.WriteLine("Policy can't be lapsed as it is already cancelled!");
        }

        public void clientCancelPolicy()
        {
            Console.WriteLine("Policy already cancelled!");
        }

        public void payout()
        {
            Console.WriteLine("Policy already cancelled, cant perform payout!");
        }

        public void payPenalty(double amount)
        {
            Console.WriteLine("Policy already cancelled, too late to pay penalty!");
        }
    }
}
