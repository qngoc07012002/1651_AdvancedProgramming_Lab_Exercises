using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal class LeutenantGeneral : ILeutenantGeneral
    {
        public string Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public double Salary { get; }
        public IReadOnlyCollection<IPrivate> Privates => privates.AsReadOnly();

        private List<IPrivate> privates;

        public LeutenantGeneral(string id, string firstName, string lastName, double salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            privates = new List<IPrivate>();
        }

        public void AddPrivate(IPrivate @private)
        {
            privates.Add(@private);
        }

        public override string ToString()
        {
            string result = $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}\nPrivates:\n";

            foreach (var @private in privates)
            {
                result += $"  {@private.ToString()}\n";
            }

            return result;
        }
    }
}
