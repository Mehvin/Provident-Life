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

        public double GetInvoiceID()
        {
            return invoiceID;
        }

        public void SetInvoiceID(int invoiceID)
        {
            this.invoiceID = invoiceID;
        }

        public string GetPaymentType()
        {
            return paymentType;
        }

        public void SetDate(string paymentType)
        {
            this.paymentType = paymentType;
        }
    }
}
