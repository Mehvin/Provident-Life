using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife
{
    class Premium
    {
        private static int ID = 0;

        private int premiumID;
        private double amountPayable;
        private DateTime dueDate;
        private string paymentType;
        private DateTime dateTimeOfPayment;
        private string details;
        
        // Associations
        private Rider rider;
        private Client client;

        public Premium(double amountPayable, DateTime dueDate, Rider rider, Client client, string paymentType, DateTime dateTimeOfPayment, string details)
        {
            this.premiumID = ID++;
            this.amountPayable = amountPayable;
            this.dueDate = dueDate;
            this.paymentType = paymentType;
            this.dateTimeOfPayment = dateTimeOfPayment;
            this.details = details;
            this.rider = rider;
            this.client = client;
        }

        public int getPremiumID()
        {
            return premiumID;
        }

        public double getAmountPayable()
        {
            return amountPayable;
        }

        public DateTime getDueDate()
        {
            return dueDate;
        }

        public string getPaymentType()
        {
            return paymentType;
        }

        public DateTime getDateTimeOfPayment()
        {
            return dateTimeOfPayment;
        }

        public string getDetails()
        {
            return details;
        }
    }
}
