using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentLife.Classes
{
    class Invoice
    {
        private int invoiceID;
        private string paymentType;
        private DateTime dateTime;

        private Premium premium;
        private Client client;

        public Invoice(int invoiceID, string paymentType, DateTime dateTime, Premium premium, Client client)
        {
            this.invoiceID = invoiceID;
            this.paymentType = paymentType;
            this.dateTime = dateTime;
            this.premium = premium;
            this.client = client;
        }

        public double GetInvoiceID()
        {
            return invoiceID;
        }

        public string GetPaymentType()
        {
            return paymentType;
        }

        public DateTime GetDateTime()
        {
            return dateTime;
        }

    }
}
