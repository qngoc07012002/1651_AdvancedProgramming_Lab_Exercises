using Day1_Lab;
using System;
using System.Collections.Generic;

namespace AdvancedProgramming_1651_Lab_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose your lab: ");
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
            }
        }

        // Problem 1
        public static void Problem1()
        {
            BankAccount acc = new BankAccount();

            acc.Id = 1;
            acc.Balance = 15;
            Console.WriteLine($"Account {acc.Id}, balance {acc.Balance}");

        }

        // Problem 2
        public static void Problem2()
        {
            BankAccount acc = new BankAccount();

            acc.Id = 1;
            acc.Deposit(15);
            acc.Withdraw(10);

            Console.WriteLine(acc);
        }

        //Problem 3
        public static void Problem3()
        {
            Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

            string command = "";
            
            do {
                command = Console.ReadLine();

                var cmdArgs = command.Split();

                var cmdType = cmdArgs[0];

                switch (cmdType)
                {
                    case "Create":
                        Create(cmdArgs, accounts);
                        break;
                    case "Deposit":
                        Deposit(cmdArgs, accounts);
                        break;
                    case "Withdraw":
                        Withdraw(cmdArgs, accounts);
                        break;
                    case "Print":
                        Print(cmdArgs, accounts);
                        break;

                }

            } while (String.Equals(command,"End") == false);


        }

        private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new BankAccount();
                acc.Id = id;
                accounts.Add(id, acc);
            }
        }

        private static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);

            decimal amount = Decimal.Parse(cmdArgs[2]);

            BankAccount acc = new BankAccount();

            if (accounts.TryGetValue(id,out acc))
            {
                acc.Deposit(amount);
                accounts[id] = acc;
            } else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);

            decimal amount = Decimal.Parse(cmdArgs[2]);

            BankAccount acc = new BankAccount();
            if (accounts.TryGetValue(id, out acc)){
                decimal check = acc.Balance - amount;
                if (check < 0)
                {
                    Console.WriteLine("Insufficient balance");
                } else
                {
                    acc.Withdraw(amount);
                }
            } else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            BankAccount acc = new BankAccount();
            if (accounts.TryGetValue(id, out acc))
            {
                Console.WriteLine(acc);
            } else
            {
                Console.WriteLine("Account does not exist");
            }
        }
    }

    // Problem 4

}
