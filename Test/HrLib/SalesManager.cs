using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMS
{
    public class SalesManager : Employee
    {
        private double bonus;

        public SalesManager(int id, string firstName, string lastName,  double salary, string address,double bonus) : base(id, firstName, lastName,  salary, address)
        {


            this.bonus = bonus;

        }

        public double Bonus
        {
                get { return this.bonus; }
                    set { this.bonus = value; }
        }

      

        public override string? ToString()
        {
            return base.ToString()+" Bonus: "+bonus;
        }

        public override double ComputerPay()
        {
            return base.ComputerPay() + bonus;
        }
    }
}
