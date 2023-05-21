using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal class PetPB6 : ICelebratable
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        public PetPB6(string name, DateTime birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return Birthdate;
        }
    }
}
