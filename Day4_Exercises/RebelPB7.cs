using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal class RebelPB7 : IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        private int _food;

        public RebelPB7(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
            _food = 0;
        }

        public void BuyFood()
        {
            _food += 5;
        }

        public int Food
        {
            get { return _food; }
        }
    }
}
