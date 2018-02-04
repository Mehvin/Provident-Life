using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    abstract class IPBuilder
    {
        protected Client client;
        protected Employee employee;
        protected DateTime startDate;
        protected DateTime maturedDate;
        protected List<string> termsAndConds;
        protected List<Rider> riders;

        public IPBuilder withClient(Client client)
        {
            this.client = client;

            return this;
        }

        public IPBuilder withEmployee(Employee employee)
        {
            this.employee = employee;

            return this;
        }

        public IPBuilder startsOn(DateTime startDate)
        {
            this.startDate = startDate;

            return this;
        }

        public IPBuilder maturesOn(DateTime maturedDate)
        {
            this.maturedDate = maturedDate;

            return this;
        }

        public IPBuilder addsTermsAndCond(string termsAndCond)
        {
            this.termsAndConds.Add(termsAndCond);

            return this;
        }

        public IPBuilder addRider(Rider rider)
        {
            this.riders.Add(rider);

            return this;
        }

        abstract public InsurancePolicy build();
    }
}
