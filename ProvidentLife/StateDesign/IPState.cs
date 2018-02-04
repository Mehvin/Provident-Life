using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    interface IPState
    {
        void payPeriodic();
        void agentCancelPolicy();
        void agentLapsedPolicy();
        void clientCancelPolicy();
        void payout();
        void payPenalty(double amount);
    }
}
