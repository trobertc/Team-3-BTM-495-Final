using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class Accountant : Employee
    {

        

        public Accountant(int eID, string n, DateTime st, double s)
           : base(eID, n, st, s)
        {

        }

        public double ProcessPmt(Invoice invoice,double paymentAmount)
        {
            if (invoice.Balance < paymentAmount || invoice.Balance < 0.01)
                throw new InvalidOperationException("An error occurred with the processing of your payment. Please call out account department at extension x702.");

            invoice.Balance -= paymentAmount;
            return invoice.Balance;
        }



    }
}
