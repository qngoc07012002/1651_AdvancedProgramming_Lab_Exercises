using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Exercises
{
    internal class Person
    {
        public string name;
        public int age;



        public Person()
        {
            this.name = "No Name";
            this.age = 1;
        }

        public Person(int age)
        {
            this.name = "No Name";
            this.age = age;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{this.name} {this.age}";
        }
    }
}
