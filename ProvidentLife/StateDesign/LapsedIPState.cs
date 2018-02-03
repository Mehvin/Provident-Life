using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife.Classes
{
    class LapsedIPState : IPState
    {
        private InsurancePolicy myPolicy;

        public LapsedIPState(InsurancePolicy policy)
        {
            myPolicy = policy;
        }

        public void PayPeriodic()
        {
            Console.WriteLine("Policy cannot be paid periodically now!");
        }

        public void AgentCancelPolicy()
        {
            myPolicy.SetIPState(myPolicy.GetInactiveIPState());
            Console.WriteLine("Policy has been cancelled by agent.");
        }

        public void AgentLapsedPolicy()
        {
            Console.WriteLine("Policy is already lapsed!");
        }

        public void ClientCancelPolicy()
        {
            myPolicy.PayFee();
            myPolicy.SetIPState(myPolicy.GetInactiveIPState());
            Console.WriteLine("Policy has been cancelled by client.");
        }

        public void Payout()
        {
            Console.WriteLine("Policy cannot perform payout, please pay penalty first!");
        }

        public void PayPenalty(double amount)
        {
            myPolicy.SetTotalPenalty(myPolicy.GetTotalPenalty() - amount);
            if (myPolicy.GetTotalPenalty() == 0)
            {
                myPolicy.SetIPState(myPolicy.GetOngoingIPState());
                Console.WriteLine("Penalty paid out, policy returned to ongoing.");
            }

            else
            {
                Console.WriteLine("Penalty still not paid out!");
            }
        }
    }
}
