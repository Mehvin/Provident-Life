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
        protected DateTime maturityDate;
        protected double totalAmount;
        protected double fee;

        protected Client client;
        protected Employee employee;

        // Strategy pattern
        protected PayoutStrategy payoutStrategy;

        // State machine
        private IPState ongoingIPState;
        private IPState lapsedIPState;
        private IPState inactiveIPState;
        private IPState state;

        public abstract Premium GetPremium();

        public int GetPolicyID()
        {
            return policyID;
        }

        public void SetPolicyID(int pd)
        {
            policyID = pd;
        }

        public List<string> GetTermsCond()
        {
            return termsCond;
        }

        public void SetTermsCond(List<string> termsCond)
        {
            this.termsCond = termsCond;
        }
    
        public DateTime GetStartDate()
        {
            return startDate;
        }

        public void SetStartDate(DateTime startDate)
        {
            this.startDate = startDate;
        }

        public DateTime GetMaturityDate()
        {
            return maturityDate;
        }

        public void SetMaturityDate(DateTime maturityDate)
        {
            this.maturityDate = maturityDate;
        }

        public double GetTotalAmount()
        {
            return totalAmount;
        }

        public void SetTotalAmount(double totalAmount)
        {
            this.totalAmount = totalAmount;
        }

        public double GetFee()
        {
            return fee;
        }

        public void SetFee(double fee)
        {
            this.fee = fee;
        }

        // Strategy pattern
        public Payout PerformPayOut(string severity)
        {
            Payout payout = this.payoutStrategy.PayOut(severity);

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
