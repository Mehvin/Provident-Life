using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife.Classes
{
    interface IPState
    {
        void PayFee();
        void PayPeriodic();
        void AgentCancelPolicy();
        void AgentLapsedPolicy();
        void ClientCancelPolicy();
    }
}
