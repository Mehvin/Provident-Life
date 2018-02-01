using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife.Classes
{
    interface PayoutStrategy
    {
        Payout PayOut(string severity);
    }
}
