// See https://aka.ms/new-console-template for more information
using EmployeeMS;
using HrLib;

using TaxCal;
using TaxLib;
using Test;

Console.WriteLine("Hello, World!");



//employees.Add(new HrManager(4, "a1", "b1", 50000, "Pune", 5000, 100));



TaxCalculate taxCalculate = new TaxCalculate();
TaxManager opr1 = new TaxManager(taxCalculate.PayProfessionalTax);
TaxManager opr2 = new TaxManager(taxCalculate.PayServiceTax);
TaxManager opr3 = new TaxManager(taxCalculate.PayIndirectTax);

string filePath = "E:\\DotNet\\dotnet.txt";
List<Employee> employees = SerializerClass.DeSerializer(filePath);

/*employees.Add(new HrManager(1, "a1", "b1", 50000, "Pune", 5000, 100));
employees.Add(new SalesManager(2, "a2", "b2", 45000, "Mumbai", 4000));
employees.Add(new HrManager(3, "a3", "b3", 60000, "Delhi", 7000, 170));*/



bool flag = true;

while (flag)
{
    Console.WriteLine("\n\nEnter the Choice to calculate\n 1: Add Employee\n 2: Display Employees\n 3: Salary of Employee\n 4: Total expenditure of company\n 5: To increamnt salary\n 6: To Remove the employee\n 7: To Exit\n ");
    int choice = Int32.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine(" To add Salesmanager press 1 and to add Hr Manager press 2 ");
            int ch = Int32.Parse(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("Enter  id, firstName, lastName, salary, address, bonus");
                int id = Int32.Parse(Console.ReadLine());
                string firstName=Console.ReadLine();
                string lastName = Console.ReadLine();
                double sal=Double.Parse(Console.ReadLine());
                string address=Console.ReadLine();
                double bonus=Double.Parse(Console.ReadLine());  

                employees.Add(new SalesManager(id,firstName,lastName,sal,address,bonus));
            }
            else if(ch == 2)
            {
                Console.WriteLine("Enter id, firstName, lastName, post, salary, address, bonus, hoursWorked");
                int id = Int32.Parse(Console.ReadLine());
                string firstName = Console.ReadLine();
                string lastName = Console.ReadLine();
                double sal = Double.Parse(Console.ReadLine());
                string address = Console.ReadLine();
                double bonus = Double.Parse(Console.ReadLine());
                int hoursWorked=Int32.Parse(Console.ReadLine());
                employees.Add(new SalesManager(id, firstName, lastName, sal, address, bonus));
            }
            else
            {
                Console.WriteLine("Enter the valid choice");
            }
            
            break;


        case 2:
            Console.WriteLine("All Employees are: ");
            foreach (Employee emp in employees)
            {


                Console.WriteLine(emp + "\n");


            }

            break;

        case 3:
            Console.WriteLine("Enter your Id to calculate salary: ");
            int empId = Int32.Parse(Console.ReadLine());
            foreach (Employee emp in employees)
            {
                if (empId == emp.Id)
                {
                    if (emp.GetType() == typeof(HrManager))
                    {
                        Console.WriteLine(opr1(emp.ComputerPay()));
                        break;
                    }
                    else if (emp.GetType() == typeof(SalesManager))
                    {
                        Console.WriteLine(opr2(emp.ComputerPay()));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(opr3(emp.ComputerPay()));
                        break;
                    }


                }
            }
            break;

        
        case 4:
            Console.WriteLine("Total Expenditure of company is : ");
            double salary = 0;
            foreach (Employee emp in employees)
            {
                salary += emp.ComputerPay();

            }
            Console.WriteLine("Rs. " + salary);
            break;

        case 5:
            Console.WriteLine("Enter the Id to increament salary");
            empId = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the increament : ");
            double incSal = Double.Parse(Console.ReadLine());

            foreach(Employee emp in employees)
            {
                if (emp.Id == empId)
                {
                    emp.manageTax += taxCalculate.PayIndirectTax;
                    emp.IncreamentSalary(incSal);
                    break;
                }

            }
           
            
            break;

        case 6:
            Console.WriteLine("Enter the id to delete the employee:");
            int eid= Int32.Parse(Console.ReadLine());    
          /*  foreach(Employee emp in employees)
            {
                if (emp.Id == eid)
                {
                    employees.Remove(emp);

                }
            }*/
            break;

       

        case 7:
            Console.WriteLine("Exiting....");
            SerializerClass.Serialize(employees, filePath);
            flag = false;
            break;

    }
}












