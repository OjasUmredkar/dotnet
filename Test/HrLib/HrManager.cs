using EmployeeMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrLib
{
    public class HrManager : Employee
    {
        private double bonus;
        private int hoursWorked;

        public HrManager(int id, string firstName, string lastName, double salary, string address,double bonus, int hoursWorked) : base(id, firstName, lastName, salary, address)
        {
            this.bonus = bonus;    
            this.hoursWorked = hoursWorked;
        }


        public double Bonus
        {
            get { return this.bonus; } 
            set { this.bonus = value; }
        }

        public int HoursWorked
        {
            get { return this.hoursWorked; }
            set { this.hoursWorked = value; }
        }


        public override double ComputerPay()
        {
            return base.ComputerPay()+bonus*hoursWorked;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
