using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    abstract class InsurancePolicy
    {
        private static int ID = 0;

        // Properties
        protected int policyID;
        protected List<string> termsCond;
        protected DateTime startDate;
        protected DateTime maturedDate;
        protected double totalAmount;
        protected double fee = 0;
        protected double totalPenalty = 0;

        // Associations
        private Client client;
        private Employee employee;
        private List<Rider> riders;

        // State machine
        private IPState ongoingIPState;
        private IPState lapsedIPState;
        private IPState inactiveIPState;
        private IPState state;

        public InsurancePolicy(
            List<string> termsAndCond,
            DateTime startDate,
            DateTime maturedDate,
            Client client,
            Employee employee,
            List<Rider> riders)
        {
            this.policyID = ID++;
            this.termsCond = termsAndCond;
            this.startDate = startDate;
            this.maturedDate = maturedDate;
            this.client = client;
            this.employee = employee;
            this.riders = riders;
        }

        public int getPolicyID()
        {
            return policyID;
        }

        public List<string> getTermsCond()
        {
            return termsCond;
        }

        public double getTotalPenalty()
        {
            return totalPenalty;
        }

        public void setTotalPenalty(double penalty)
        {
            this.totalPenalty = penalty;
        }

        public void payFee()
        {
            Console.WriteLine("Paid fee of $" + fee);
        }
        public List<Rider> getRiderList()
        {
            return riders;
        }

        public abstract List<Premium> getPremiums();

        // Strategy pattern
        public double performPayOut(Rider rider, string severity)
        {
            double payout = rider.performPayOut(severity);

            return payout;
        }

        // State machine
        public IPState getOngoingIPState()
        {
            return ongoingIPState;
        }

        public IPState getLapsedIPState()
        {
            return lapsedIPState;
        }

        public IPState getInactiveIPState()
        {
            return inactiveIPState;
        }

        public void setIPState(IPState state)
        {
            this.state = state;
        }

        public List<Rider> getRiders()
        {
            return riders;
        }
    }
}
