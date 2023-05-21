using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal class People : ACitizen
    {
        public string Name { get; }
        public int Age { get; }

        public People(string id, string name, int age) : base(id)
        {
            Name = name;
            Age = age;
        }


    }
}
