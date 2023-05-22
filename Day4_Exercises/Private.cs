using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal class Private : IPrivate
    {
        public string Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public double Salary { get; }

        public Private(string id, string firstName, string lastName, double salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}";
        }
    }
}
