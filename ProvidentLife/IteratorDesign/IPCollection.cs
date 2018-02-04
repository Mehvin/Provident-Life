using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    class IPCollection
    {
        private List<InsurancePolicy> insurancePolicies;

        public IPCollection()
        {
            this.insurancePolicies = new List<InsurancePolicy>();
        }

        public void addPolicy(InsurancePolicy policy)
        {
            insurancePolicies.Add(policy);
        }

        public void removePolicy(InsurancePolicy policy)
        {
            insurancePolicies.Remove(policy);
        }

        public void sortNewest()
        {
            // implementation
            Console.WriteLine("Sorted according newest!");
        }

        public void sortOldest()
        {
            // implementation
            Console.WriteLine("Sorted according oldest!");
        }

        public Iterator searchMinTotalAmount(double value)
        {
            List<InsurancePolicy> policies = new List<InsurancePolicy>();

            // implementation
            Console.WriteLine("Searching min value!");

            Iterator iterator = new IPIterator(policies);
            return iterator;
        }

        public Iterator searchMaxTotalAmount(double value)
        {
            List<InsurancePolicy> policies = new List<InsurancePolicy>();

            // implementation
            Console.WriteLine("Searching max value!");

            Iterator iterator = new IPIterator(policies);
            return iterator;
        }

        public Iterator getIterator()
        {
            return new IPIterator(insurancePolicies);
        }
    }
}
