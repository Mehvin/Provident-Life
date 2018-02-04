using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    class OngoingIPState : IPState
    {
        private InsurancePolicy myPolicy;

        public OngoingIPState(InsurancePolicy policy)
        {
            myPolicy = policy;
        }

        public void payPeriodic()
        {
            Console.WriteLine("Periodic paid.");
        }

        public void agentCancelPolicy()
        {
            Console.WriteLine("Policy can't be cancelled by agent!");
        }

        public void agentLapsedPolicy()
        {
            myPolicy.setIPState(myPolicy.getLapsedIPState());
            Console.WriteLine("Policy has been lapsed by agent!");
        }

        public void clientCancelPolicy()
        {
            myPolicy.payFee();
            myPolicy.setIPState(myPolicy.getInactiveIPState());
            Console.WriteLine("Policy has been cancelled by client.");
        }

        public void payout()
        {
            string serverity = "Insert serverity here";
            Rider rider = null;
            myPolicy.performPayOut(rider, serverity);
            myPolicy.setIPState(myPolicy.getInactiveIPState());
            Console.WriteLine("Policy has been payout");
        }

        public void payPenalty(double amount)
        {
            Console.WriteLine("No penalty to be paid!");
        }
    }
}
