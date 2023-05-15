﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Lab
{
    internal class BankAccount
    {
        private int id;
        private decimal balance;

        public BankAccount()
        {
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }
        
        public override string ToString()
        {
            return $"Account {this.Id}, balance {this.Balance}";
        }


    }
}
