﻿using System;
using System.Collections;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using TaxCal;
using TaxLib;

namespace EmployeeMS
{
    public class Employee
    {
        private int id;
        private string firstName;
        private string lastName;
        private double salary;
        private string address;
        public event TaxManager manageTax;

        public Employee(int id, string firstName, string lastName, double salary, string address)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
            this.address = address;
            
           
        }

        public int Id
        {
            get { return id; }  
                set { id = value; }
        }

        public string FirstName
        {
                get { return firstName; }
                    set { firstName = value; }

        }

        public string LastName
        {
                get { return lastName; }
                set { lastName = value; }
        }

           

        public double Salary
        {
               get { return salary; }
                    set { salary = value; }

        }

        public string Address
        {
                get { return address; }
                    set { address = value; }
        }

      
                                          

        public override string? ToString()
        {
            return "Id: "+id+" FirstName: "+firstName+" LastName: "+lastName+" Salary: "+salary+" Address: "+Address;
        }

        public virtual double ComputerPay()
        {
            return salary;

        }

        public void IncreamentSalary(double incSal)
        {
            this.salary=this.salary + incSal;
            if (this.salary > 60000)
            {
                this.salary = manageTax(this.salary);
            }
        }


        
    }
}