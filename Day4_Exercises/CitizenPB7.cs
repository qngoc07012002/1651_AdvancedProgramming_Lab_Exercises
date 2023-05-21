using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal class CitizenPB7 : ICelebratable, IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string ID { get; set; }
        public DateTime Birthdate { get; set; }
        private int _food;

        public CitizenPB7(string name, int age, string id, DateTime birthdate)
        {
            Name = name;
            Age = age;
            ID = id;
            Birthdate = birthdate;
            _food = 0;
        }

        public DateTime GetBirthdate()
        {
            return Birthdate;
        }

        public void BuyFood()
        {
            _food += 10;
        }

        public int Food
        {
            get { return _food; }
        }
    }
}
