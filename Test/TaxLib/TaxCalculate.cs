using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxLib
{
    public class TaxCalculate
    {

        public double  PayProfessionalTax(double pay) {
            Console.WriteLine(" After calculating Professional tax");
            return pay * 0.10;
        }

        public double PayServiceTax(double pay)
        {
            Console.WriteLine(" After calculating Service tax");
            return pay * 0.15;

        }

        public double PayIndirectTax(double pay) {

            Console.WriteLine(" After calulating service tax");
            return pay * 20;
        }

        public double SalaryAfterTaxation(double pay) { 
            double salaryAfterTaxation=pay-PayIndirectTax(pay)-PayProfessionalTax(pay)-PayServiceTax(pay);
            return salaryAfterTaxation;
        }

        


    }
}
