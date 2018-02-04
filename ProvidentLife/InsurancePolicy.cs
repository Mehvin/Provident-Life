using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProvidentLife.Classes;

namespace ProvidentLife.Classes
{
    abstract class InsurancePolicy
    {
        // Properties
        protected int policyID;
        protected List<string> termsCond;
        protected DateTime startDate;
        protected DateTime maturedDate;
        protected double totalAmount;
        protected double fee = 0;
        protected double totalPenalty = 0;

        //Associations
        private Client client;
        private Employee employee;
        private List<Rider> riders;

        // Strategy pattern
        protected PayoutStrategy payoutStrategy;

        // State machine
        private IPState ongoingIPState;
        private IPState lapsedIPState;
        private IPState inactiveIPState;
        private IPState state;

        public InsurancePolicy(
            int policyID,
            List<string> termsAndCond,
            DateTime startDate,
            DateTime maturedDate,
            Client client,
            Employee employee,
            List<Rider> riders)
        {
            this.policyID = policyID;
            this.termsCond = termsAndCond;
            this.startDate = startDate;
            this.maturedDate = maturedDate;
            this.client = client;
            this.employee = employee;
            this.riders = riders;
        }

        public int GetPolicyID()
        {
            return policyID;
        }

        public List<string> GetTermsCond()
        {
            return termsCond;
        }

        public double GetTotalPenalty()
        {
            return totalPenalty;
        }

        public void SetTotalPenalty(double penalty)
        {
            this.totalPenalty = penalty;
        }

        public void PayFee()
        {
            Console.WriteLine("Paid fee of $" + fee);
        }

        public abstract Premium GetPremium();

        // Strategy pattern
        public Rider PerformPayOut(string severity)
        {
            Rider payout = this.payoutStrategy.performPayOut(severity);

            if (payout != null)
            {
                //update state machine?
                
            }

            return payout;
        }

        // State machine
        public IPState GetOngoingIPState()
        {
            return ongoingIPState;
        }

        public IPState GetLapsedIPState()
        {
            return lapsedIPState;
        }

        public IPState GetInactiveIPState()
        {
            return inactiveIPState;
        }

        public void SetIPState(IPState state)
        {
            this.state = state;
        }
    }
}
