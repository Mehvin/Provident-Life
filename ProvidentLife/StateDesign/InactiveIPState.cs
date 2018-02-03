using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife.Classes
{
    class InactiveIPState : IPState
    {
        private InsurancePolicy myPolicy;
        
        public InactiveIPState(InsurancePolicy policy)
        {
            myPolicy = policy;
        }

        public void PayPeriodic()
        {
            Console.WriteLine("Policy cannot be paid periodically now!");
        }

        public void AgentCancelPolicy()
        {
            Console.WriteLine("Policy already cancelled!");
        }

        public void AgentLapsedPolicy()
        {
            Console.WriteLine("Policy can't be lapsed as it is already cancelled!");
        }

        public void ClientCancelPolicy()
        {
            Console.WriteLine("Policy already cancelled!");
        }

        public void Payout()
        {
            Console.WriteLine("Policy already cancelled, cant perform payout!");
        }

        public void PayPenalty(double amount)
        {
            Console.WriteLine("Policy already cancelled, too late to pay penalty!");
        }
    }
}
