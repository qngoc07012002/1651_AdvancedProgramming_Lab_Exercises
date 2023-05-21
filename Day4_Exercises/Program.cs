using System;
using System.Collections.Generic;
using System.Globalization;

namespace Day4_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose your Exercises: ");
            int choosen = int.Parse(Console.ReadLine());
            switch (choosen)
            {
                case 1:
                    Problem1();
                    break;
                case 2:
                    Problem2();
                    break;
                case 3:
                    Problem3();
                    break;
                case 4:
                    Problem4();
                    break;
                case 5:
                    Problem5();
                    break;
                case 6:
                    Problem6();
                    break;
                case 7:
                    Problem7();
                    break;
            }
        }


        // Problem 1
        static void Problem1()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            IPerson person = new Citizen(name, age);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

        }

        // Problem 2
        static void Problem2()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();
            IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            IBirthable birthable = new Citizen(name, age, id, birthdate);
            Console.WriteLine(identifiable.Id);
            Console.WriteLine(birthable.Birthdate);

        }

        // Problem 3
        static void Problem3()
        {
            string driverName = Console.ReadLine();
            Ferrari ferrari = new Ferrari(driverName);
            Console.WriteLine(ferrari);
        }

        // Problem 4
        static void Problem4()
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] websites = Console.ReadLine().Split(' ');

            Smartphone smartphone = new Smartphone();

            foreach (string number in phoneNumbers)
            {
                smartphone.Call(number);
            }

            foreach (string website in websites)
            {
                smartphone.Browse(website);
            }
        }

        // Problem 5
        static void Problem5()
        {
            List<string> detainedIds = new List<string>();

            List<ACitizen> citizens = new List<ACitizen>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] data = input.Split(' ');

                if (data.Length == 3)
                {
                    string name = data[0];
                    int age = int.Parse(data[1]);
                    string id = data[2];

                    People people = new People(id, name, age);
                    citizens.Add(people);
                }
                else if (data.Length == 2)
                {
                    string model = data[0];
                    string id = data[1];

                    Robot robot = new Robot(id, model);
                    citizens.Add(robot);
                }
            }

            string lastDigits = Console.ReadLine();
                
            foreach (ACitizen citizen in citizens)
            {
                if (citizen.isDetained(lastDigits))
                {
                    detainedIds.Add(citizen.Id);
                }
            }

            foreach (string detainedId in detainedIds)
            {
                Console.WriteLine(detainedId);
            }
        }


        // Problem 6
        static void Problem6()
        {
            List<ICelebratable> celebratables = new List<ICelebratable>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(' ');

                if (tokens[0] == "Citizen")
                {
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    string id = tokens[3];
                    DateTime birthdate = DateTime.ParseExact(tokens[4], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    CitizenPB6 citizen = new CitizenPB6(name, age, id, birthdate);
                    celebratables.Add(citizen);
                }
                else if (tokens[0] == "Robot")
                {
                    string model = tokens[1];
                    string id = tokens[2];

                    RobotPB6 robot = new RobotPB6(model, id);
                    celebratables.Add(robot);
                }
                else if (tokens[0] == "Pet")
                {
                    string name = tokens[1];
                    DateTime birthdate = DateTime.ParseExact(tokens[2], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    PetPB6 pet = new PetPB6(name, birthdate);
                    celebratables.Add(pet);
                }
            }

            int targetYear = int.Parse(Console.ReadLine());

            foreach (ICelebratable celebratable in celebratables)
            {
                if (celebratable.GetBirthdate().Year == targetYear)
                {
                    string formattedDate = celebratable.GetBirthdate().ToString("dd/MM/yyyy");
                    Console.WriteLine(formattedDate);
                }
            }
        }
    

        // Problem 7
        static void Problem7()
        {
            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                if (input.Length == 4)
                {
                    string id = input[2];
                    DateTime birthdate = DateTime.ParseExact(input[3], "dd/MM/yyyy", null);

                    CitizenPB7 citizen = new CitizenPB7(name, age, id, birthdate);
                    buyers[name] = citizen;
                }
                else if (input.Length == 3)
                {
                    string group = input[2];

                    RebelPB7 rebel = new RebelPB7(name, age, group);
                    buyers[name] = rebel;
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                if (buyers.ContainsKey(command))
                {
                    buyers[command].BuyFood();
                }
            }

            int totalFood = 0;
            foreach (IBuyer buyer in buyers.Values)
            {
                totalFood += buyer.Food;
            }

            Console.WriteLine(totalFood);
        }
    }
}
