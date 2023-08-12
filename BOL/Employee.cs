using System.ComponentModel;

namespace BOL
{
    public  enum Department
    {
        HR,SALES,FINANCE,PURCHASE
    }
    public class Employee
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private double salary;
        private DateTime dob;
        private string password;    
        private Department dept;

        public Employee(int id,string firstName, string lastName, string email, double salary,  DateTime dob, string password,Department dept)
        {   
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.salary = salary;
            this.dob = dob;
            this.password = password;
            this.dept=dept;
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
            get { return this.lastName; }
            set { this.lastName = value; }
           
        }
        public string Email
        {
            get { return this.email; }
                set { this.email = value; } 
        }

        public double Salary
        {
            get { return salary; }
            set { this.salary = value; }
        }

        public DateTime Dob
        {
            get { return dob; }
            set { this.dob = value;  }
        }

        public string Password
        {
            get { return  password; }
            set { password = value; }   
        }

        public Department Dept
        {
            get { return dept; }
            set { this.dept = value; }
        }

        public override string? ToString()
        {
            string str = string.Format("[" + " First Name:" + firstName + " Last Name: " + lastName + " Email: " + email + " Salary: " + salary + " Date of Birth: " + dob + "]");
            return str;
        }

        public double ComputeSalary()
        {
            return this.salary;
        }

    }
}