using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife.Classes
{
    abstract class IPBuilder
    {
        protected Client client;
        protected Employee employee;
        protected DateTime startDate;
        protected DateTime maturedDate;
        protected List<string> termsAndConds;
        protected List<Rider> riders;

        public IPBuilder WithClient(Client client)
        {
            this.client = client;

            return this;
        }

        public IPBuilder WithEmployee(Employee employee)
        {
            this.employee = employee;

            return this;
        }

        public IPBuilder StartsOn(DateTime startDate)
        {
            this.startDate = startDate;

            return this;
        }

        public IPBuilder MaturesOn(DateTime maturedDate)
        {
            this.maturedDate = maturedDate;

            return this;
        }

        public IPBuilder AddsTermsAndCond(string termsAndCond)
        {
            this.termsAndConds.Add(termsAndCond);

            return this;
        }

        public IPBuilder AddRider(Rider rider)
        {
            this.riders.Add(rider);

            return this;
        }

        abstract public InsurancePolicy Build();
    }
}
