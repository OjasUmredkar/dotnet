using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxLib
{
    public class TaxCalculate
    {

        public double PayProfessionalTax(double pay) {
            Console.WriteLine(" After calculating Professional tax");
            return pay - pay * 0.10;


        }

        public double PayServiceTax(double pay)
        {
            Console.WriteLine(" After calculating Service tax");
            return pay-pay * 0.15;

        }

        public double PayIndirectTax(double pay) {

            Console.WriteLine(" After calulating service tax");
            return pay-pay *  0.20;
        }

       



    }
}
