using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    class LapsedIPState : IPState
    {
        private InsurancePolicy myPolicy;

        public LapsedIPState(InsurancePolicy policy)
        {
            myPolicy = policy;
        }

        public void payPeriodic()
        {
            Console.WriteLine("Policy cannot be paid periodically now!");
        }

        public void agentCancelPolicy()
        {
            myPolicy.setIPState(myPolicy.getInactiveIPState());
            Console.WriteLine("Policy has been cancelled by agent.");
        }

        public void agentLapsedPolicy()
        {
            Console.WriteLine("Policy is already lapsed!");
        }

        public void clientCancelPolicy()
        {
            myPolicy.payFee();
            myPolicy.setIPState(myPolicy.getInactiveIPState());
            Console.WriteLine("Policy has been cancelled by client.");
        }

        public void payout()
        {
            Console.WriteLine("Policy cannot perform payout, please pay penalty first!");
        }

        public void payPenalty(double amount)
        {
            myPolicy.setTotalPenalty(myPolicy.getTotalPenalty() - amount);
            if (myPolicy.getTotalPenalty() == 0)
            {
                myPolicy.setIPState(myPolicy.getOngoingIPState());
                Console.WriteLine("Penalty paid out, policy returned to ongoing.");
            }

            else
            {
                Console.WriteLine("Penalty still not paid out!");
            }
        }
    }
}
