using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife.Classes
{
    class Premium
    {
        private int premiumID;
        private double amountPayable;
        private DateTime dueDate;
        private string paymentType;
        private DateTime dateTimeOfPayment;
        private string details;
        
        //Associations
        private Rider rider;
        private Client client;

        public Premium(int id, double amountPayable, DateTime dueDate, Rider rider, Client client, string paymentType,DateTime datetimeofpayment, string details)
        {
            this.premiumID = id;
            this.amountPayable = amountPayable;
            this.dueDate = dueDate;
            this.rider = rider;
            this.client = client;
            this.paymentType = paymentType;
            this.dateTimeOfPayment = datetimeofpayment;
            this.details = details;
        }

        public int getpremiumID() { return premiumID; }
        public double getAmountPayable() { return amountPayable; }
        public DateTime getDueDate() { return dueDate; }
        public string getPaymentType() { return paymentType; }
        public DateTime getDateTimeOfPayment() { return dateTimeOfPayment; }
        public string getDetails() { return details; }

    }
}
