using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    class CreditCardSystem
    {
        private static CreditCardSystem uniqueInstance;

        private CreditCardSystem() { }

        public static CreditCardSystem getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new CreditCardSystem();
            }

            return uniqueInstance;
        }

        public bool processPayment(int creditCardNo, int ccv)
        {
            bool success = true;

            // implementation
            Console.WriteLine("Processing payment...");

            return success;
        }
    }
}
