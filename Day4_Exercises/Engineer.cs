using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal class Engineer : IEngineer
    {
        public string Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public double Salary { get; }
        public string Corps { get; }
        public IReadOnlyCollection<IRepair> Repairs => repairs.AsReadOnly();

        private List<IRepair> repairs;

        public Engineer(string id, string firstName, string lastName, double salary, string corps)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Corps = corps;
            repairs = new List<IRepair>();
        }

        public void AddRepair(IRepair repair)
        {
            repairs.Add(repair);
        }

        public override string ToString()
        {
            string result = $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}\nCorps: {Corps}\nRepairs:\n";

            foreach (var repair in repairs)
            {
                result += $"  {repair.ToString()}\n";
            }

            return result;
        }
    }
}
