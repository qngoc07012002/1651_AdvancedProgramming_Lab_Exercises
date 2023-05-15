using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Exercises
{
    internal class Employee
    {
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public Employee()
        {
        }

        public decimal Salary { get { return salary; } set { salary = value; } }

        public string Department { get { return department; }}

        public Employee(string name, decimal salary, string position, string department, string email, int age) : this(name, salary, position, department, email)
        {
            this.age = age;
        }

        public Employee(string name, decimal salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = "n/a";
            this.age = -1;
        }

        public Employee(string name, decimal salary, string position, string department, string email) : this(name, salary, position, department)
        {
            this.email = email;
        }

        public Employee(string name, decimal salary, string position, string department, int age) : this(name, salary, position, department)
        {
            this.age = age;
        }

        public override string ToString()
        {
            return $"{this.name} {this.salary} {this.email} {this.age}";
        }
    }
}
