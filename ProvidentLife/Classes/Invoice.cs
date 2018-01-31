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

        public double getinvoiceID()
        {
            return invoiceID;
        }

        public void setinvoiceID(int id)
        {
            invoiceID = id;
        }

        public string getpaymentType()
        {
            return paymentType;
        }

        public void setDate(string pt)
        {
            paymentType = pt;
        }
    }
}
