using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    class IPIterator : Iterator
    {
        private List<InsurancePolicy> insurancePolicies;

        public IPIterator(List<InsurancePolicy> insurancePolicies)
        {
            this.insurancePolicies = insurancePolicies;       
        }

        public bool hasNext()
        {
            bool hasNext = false;

            // implementation
            Console.WriteLine("Checking has next!");

            return hasNext;
        }

        public object next()
        {
            object nextObj = null;

            // implementation
            Console.WriteLine("Getting next object!");

            return nextObj;
        }

        public void remove(object obj)
        {
            // implementation
            Console.WriteLine("Removing object!");
        }
    }
}
