using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Employee
    {
        const double Default_Salary = 10000;
        private string name;
        private Date applicationDate;
        private double salary;

        public Employee(string name, Date applicationDate, double salary)
        {
            this.name = name;
            this.applicationDate = applicationDate;
            this.salary = salary;
        }

        public Employee(string name, Date applicationDate)
        {
            this.name = name;
            this.applicationDate = applicationDate;
            this.salary = Default_Salary;
        }

        public string GetName()
        {
            return this.name;
        }

        public Date GetApplicationDate()
        {
            return new Date(this.applicationDate);
        }

        public double GetSalary()
        {
            return this.salary;
        }
        public void SetSalary(double setSalary)
        {
            if (salary > 0)
            this.salary = setSalary;
        }

        public double bonus()
        {
            return this.salary * 1.7;
        }

        public override string ToString()
        {
            return $"Name : {this.name}" +
                $"\nApplicationDate : {this.applicationDate}" +
                $"\nSalary : {this.salary}";         

        }
    }
}
