using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal class Spy : ISpy
    {
        public string Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int CodeNumber { get; }

        public Spy(string id, string firstName, string lastName, int codeNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CodeNumber = codeNumber;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id}\nCode Number: {CodeNumber}";
        }
    }
}
