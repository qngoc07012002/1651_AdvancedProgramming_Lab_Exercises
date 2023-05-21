using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal class Smartphone : ICall, IBrowse
    {


        public void Call(string phoneNumber)
        {
            if (ContainsDigits(phoneNumber))
            {
                Console.WriteLine("Calling... " + phoneNumber);
            } else
            {
                Console.WriteLine("Invalid number!");
            }
        }

        public void Browse(string url)
        {
            if (ContainsDigits(url))
            {
                Console.WriteLine("Invalid URL!");
            } else
            {
                Console.WriteLine("Browsing: " + url + "!");
            }
        }

        private bool ContainsDigits(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
