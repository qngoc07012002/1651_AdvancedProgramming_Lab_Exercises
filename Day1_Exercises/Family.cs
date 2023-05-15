using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Exercises
{
    internal class Family
    {
        List<Person> listOfPeople;

        public Family()
        {
            listOfPeople = new List<Person>();
        }

        public void AddMember(Person member)
        {
            listOfPeople.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestMember = new Person(0);


            foreach (var person in listOfPeople)
            {
                if (oldestMember.age < person.age)
                {
                    oldestMember = person;
                }
            }

            return oldestMember;
        }
    }
}
