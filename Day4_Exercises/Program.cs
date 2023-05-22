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
                case 8:
                    Problem8();
                    break;
                case 9:
                    Problem9();
                    break;
                case 10:
                    Problem10();
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
        // Problem 8
        static void Problem8()
        {
            List<ISoldier> soldiers = new List<ISoldier>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(' ');

                string type = tokens[0];
                string id = tokens[1];
                string firstName = tokens[2];
                string lastName = tokens[3];

                if (type == "Private")
                {
                    double salary = double.Parse(tokens[4]);
                    soldiers.Add(new Private(id, firstName, lastName, salary));
                }
                else if (type == "LeutenantGeneral")
                {
                    double salary = double.Parse(tokens[4]);

                    LeutenantGeneral leutenantGeneral = new LeutenantGeneral(id, firstName, lastName, salary);

                    for (int i = 5; i < tokens.Length; i++)
                    {
                        string privateId = tokens[i];

                        IPrivate @private = (IPrivate)soldiers.Find(s => s.Id == privateId);

                        leutenantGeneral.AddPrivate(@private);
                    }

                    soldiers.Add(leutenantGeneral);
                }
                else if (type == "Engineer")
                {
                    double salary = double.Parse(tokens[4]);
                    string corps = tokens[5];

                    if (corps != "Airforces" && corps != "Marines")
                    {
                        continue;
                    }

                    Engineer engineer = new Engineer(id, firstName, lastName, salary, corps);

                    for (int i = 6; i < tokens.Length; i += 2)
                    {
                        string partName = tokens[i];
                        int hoursWorked = int.Parse(tokens[i + 1]);

                        engineer.AddRepair(new Repair(partName, hoursWorked));
                    }

                    soldiers.Add(engineer);
                }
                else if (type == "Commando")
                {
                    double salary = double.Parse(tokens[4]);
                    string corps = tokens[5];

                    if (corps != "Airforces" && corps != "Marines")
                    {
                        continue;
                    }

                    Commando commando = new Commando(id, firstName, lastName, salary, corps);

                    for (int i = 6; i < tokens.Length; i += 2)
                    {
                        string codeName = tokens[i];
                        string state = tokens[i + 1];

                        if (state != "inProgress" && state != "Finished")
                        {
                            continue;
                        }

                        commando.AddMission(new Mission(codeName, state));
                    }

                    soldiers.Add(commando);
                }
                else if (type == "Spy")
                {
                    int codeNumber = int.Parse(tokens[4]);
                    soldiers.Add(new Spy(id, firstName, lastName, codeNumber));
                }
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.ToString());
            }
        }

        // Problem 9
        static void Problem9()
        {
            string[] addInput = Console.ReadLine().Split(' ');
            int removeOperations = int.Parse(Console.ReadLine());

            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            string addColect = "";
            string addRemoveColect = "";
            string myListColect = "";

            foreach (var item in addInput)
            {
                addColect = addColect + " " + addCollection.Add(item);
                addRemoveColect = addRemoveColect + " " + addRemoveCollection.Add(item);
                myListColect = myListColect + " " + myList.Add(item);
            }

            Console.WriteLine(addColect);
            Console.WriteLine(addRemoveColect);
            Console.WriteLine(myListColect);

            string addRemoveColectRemove = "";
            string myListColectRemove = "";

            for (int i = 0; i < removeOperations; i++)
            {
                addRemoveColectRemove = addRemoveColectRemove + " " + addRemoveCollection.Remove();
                myListColectRemove = myListColectRemove + " " + myList.Remove();
            }

            Console.WriteLine(addRemoveColectRemove);
            Console.WriteLine(myListColectRemove);
        }

        // Problem 10
        static void Problem10()
        {
        }
    }


}
