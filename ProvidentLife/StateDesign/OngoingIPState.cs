using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife.Classes
{
    class OngoingIPState : IPState
    {
        private InsurancePolicy myPolicy;

        public OngoingIPState(InsurancePolicy policy)
        {
            myPolicy = policy;
        }

        public void PayPeriodic()
        {
            Console.WriteLine("Periodic paid.");
        }

        public void AgentCancelPolicy()
        {
            Console.WriteLine("Policy can't be cancelled by agent!");
        }

        public void AgentLapsedPolicy()
        {
            myPolicy.SetIPState(myPolicy.GetLapsedIPState());
            Console.WriteLine("Policy has been lapsed by agent!");
        }

        public void ClientCancelPolicy()
        {
            myPolicy.PayFee();
            myPolicy.SetIPState(myPolicy.GetInactiveIPState());
            Console.WriteLine("Policy has been cancelled by client.");
        }

        public void Payout()
        {
            string serverity = "Insert serverity here";
            myPolicy.PerformPayOut(serverity);
            myPolicy.SetIPState(myPolicy.GetInactiveIPState());
            Console.WriteLine("Policy has been payout");
        }

        public void PayPenalty(double amount)
        {
            Console.WriteLine("No penalty to be paid!");
        }
    }
}
