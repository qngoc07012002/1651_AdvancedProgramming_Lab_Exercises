using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal class CitizenPB6 : ICelebratable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string ID { get; set; }
        public DateTime Birthdate { get; set; }

        public CitizenPB6(string name, int age, string id, DateTime birthdate)
        {
            Name = name;
            Age = age;
            ID = id;
            Birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return Birthdate;
        }
    }
}
