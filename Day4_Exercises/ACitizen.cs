using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    abstract class ACitizen
    {
        public string Id;


        protected ACitizen(string id)
        {
            Id = id;
        }

        public bool isDetained(string lastDigits)
        {
            int d = Id.Length - 1;
            for (int i = lastDigits.Length - 1; i >= 0; i--)
            {
                if (lastDigits[i] != Id[d])
                {
                    return false;
                }
                d--;
            }
            return true;
        }
    }
}
