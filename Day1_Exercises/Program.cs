using System;
using System.Collections.Generic;
using System.Reflection;

namespace Day1_Exercises
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
            }
        }
        

        // Problem 1
        public static void Problem1()
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            Person ps1 = new Person("Pescho", 20);
            Person ps2 = new Person("Gosho", 18);
            Person ps3 = new Person("Stamat", 43);

        }

        // Problem 2
        public static void Problem2()
        {
            Type personType = typeof(Person);
            ConstructorInfo emptyCtor = personType.GetConstructor(new Type[] { });
            ConstructorInfo ageCtor = personType.GetConstructor(new[] { typeof(int) });
            ConstructorInfo nameAgeCtor = personType.GetConstructor(new[] { typeof(string), typeof(int) });
            bool swapped = false;
            if (nameAgeCtor == null)
            {
                nameAgeCtor = personType.GetConstructor(new[] { typeof(int), typeof(string) });
                swapped = true;
            }

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Person basePerson = (Person)emptyCtor.Invoke(new object[] { });
            Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });
            Person personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) : (Person)nameAgeCtor.Invoke(new object[] { name, age });

            Console.WriteLine("{0} {1}", basePerson.name, basePerson.age);
            Console.WriteLine("{0} {1}", personWithAge.name, personWithAge.age);
            Console.WriteLine("{0} {1}", personWithAgeAndName.name, personWithAgeAndName.age);


        }

        // Problem 3
        public static void Problem3()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            } else
            {
                Family myFamily = new Family();

                int numberOfPerson = int.Parse(Console.ReadLine());
                for (int i = 0; i < numberOfPerson; i++)
                {
                    string st = Console.ReadLine();
                    String[] listSt = st.Split();

                    Person person = new Person(listSt[0], int.Parse(listSt[1]));

                    myFamily.AddMember(person);

                }

                Person oldestPerson = myFamily.GetOldestMember();
                Console.WriteLine(oldestPerson);
            }
        }

        // Problem 4
        public static void Problem4()
        {
            List<Person> listOfPerson = new List<Person>();

            int numberOfPerson = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPerson; i++)
            {
                string st = Console.ReadLine();
                String[] listSt = st.Split();

                Person person = new Person(listSt[0], int.Parse(listSt[1]));

                listOfPerson.Add(person);
            }

            listOfPerson.Sort((x,y) => x.name.CompareTo(y.name));

            foreach (var person in listOfPerson)
            {
                if (person.age > 30)
                {
                    Console.WriteLine(person);
                }
            }
        }

        // Problem 5
        public static void Problem5()
        {
            DateModifier dateModifier = new DateModifier();

            string firstDate = Console.ReadLine();
            string lastDate = Console.ReadLine();

            dateModifier.CalculateDifferentDays(firstDate, lastDate);
        }

        // Problem 6
        public static void Problem6()
        {
            List<Employee> employees = new List<Employee>();

            int numberOfEmployees = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> averageSalary = new Dictionary<string, decimal>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string st = Console.ReadLine();
                String[] listSt = st.Split();
                Employee employee = new Employee();
              

                switch (listSt.Length)
                {
                    case 6:
                       employee = new Employee(listSt[0], decimal.Parse(listSt[1]), listSt[2], listSt[3], listSt[4], int.Parse(listSt[5]));
                        break;
                    case 5:
                        int age = -1;

                        if (int.TryParse(listSt[4], out age))
                        {
                            employee = new Employee(listSt[0], decimal.Parse(listSt[1]), listSt[2], listSt[3], int.Parse(listSt[4]));
                        } else
                        {
                            employee = new Employee(listSt[0], decimal.Parse(listSt[1]), listSt[2], listSt[3], listSt[4]);
                        }
                        break;
                    case 4:
                        employee = new Employee(listSt[0], decimal.Parse(listSt[1]), listSt[2], listSt[3]);
                        break;
                }
                if (averageSalary.ContainsKey(employee.Department) == false)
                {
                    averageSalary.Add(employee.Department, 0);
                }

                employees.Add(employee);

            }

            employees.Sort((x, y) => y.Salary.CompareTo(x.Salary));

            string maxDepartment = "";
            decimal maxAverageSalary = 0;

            foreach (var item in averageSalary)
            {
                decimal totalSalary = 0;
                decimal numberEmployeeDepartment = 0;

                foreach (var employee in employees)
                {
                    if (item.Key == employee.Department)
                    {
                        numberEmployeeDepartment++;
                        totalSalary += employee.Salary;
                    }
                }
               
                averageSalary[item.Key] =(decimal)totalSalary / numberEmployeeDepartment;

       
                if (maxAverageSalary < averageSalary[item.Key])
                {
                    maxDepartment = item.Key;
                    maxAverageSalary = averageSalary[item.Key];
                }
        
            }
            Console.WriteLine();
            Console.WriteLine($"Highest Average Salary: {maxDepartment}");
            foreach (var employee in employees)
            {
                if (employee.Department.Equals(maxDepartment))
                {
                    Console.WriteLine(employee);
                }
            }
        }

        // Problem 7
        public static void Problem7()
        {
            List<Car> cars = new List<Car>();

            int numberOfCar = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCar; i++)
            {
                string st = Console.ReadLine();
                String[] listSt = st.Split();
                Car car = new Car(listSt[0], float.Parse(listSt[1]), float.Parse(listSt[2]));

                cars.Add(car);
            }


            String[] listStt = {"Drive"};

            do
            {
                string st = Console.ReadLine();
                listStt = st.Split();
                if (listStt[0].Equals("End") == false)
                {
                    foreach (var item in cars)
                    {
                        if (listStt[1].Equals(item.Model))
                        {
                            float amount = float.Parse(listStt[2]);
                            
                            if (item.FuelAmount-(item.FuelConsumptionFor1km * amount) >= 0) { 
                                 item.AmountOfKm = item.AmountOfKm + amount;
                                amount = item.FuelConsumptionFor1km * amount;
                                item.FuelAmount = item.FuelAmount - amount;
                            } else
                            {
                                Console.WriteLine("Insufficient fuel for the drive");
                            }
                            break;
                        }
                    }
                }
            } while (listStt[0].Equals("End") == false);

            foreach (var item in cars)
            {
                if (item.FuelAmount >= 0)
                {
                    Console.WriteLine(item);
                } else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
        }

        // Problem 8
        public static void Problem8()
        {
            List<CarPB8> cars = new List<CarPB8>();
            int numberOfCar = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCar; i++)
            {
                string st = Console.ReadLine();
                String[] listSt = st.Split();
                CarPB8 car = new CarPB8(listSt[0], int.Parse(listSt[1]), int.Parse(listSt[2]), int.Parse(listSt[3]), listSt[4],
                    double.Parse(listSt[5]), int.Parse(listSt[6]),
                    double.Parse(listSt[7]), int.Parse(listSt[8]),
                    double.Parse(listSt[9]), int.Parse(listSt[10]),
                    double.Parse(listSt[11]), int.Parse(listSt[12]));
                cars.Add(car);
            }

            string type = Console.ReadLine();

            foreach (var item in cars)
            {
                if (item.CargoType.Equals(type))
                {
                    switch (type)
                    {
                        case "fragile":
                            if (item.checkTire())
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        case "flamable":
                            if (item.EnginePower > 250)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                    }
                }
            }
        }
    }
}
