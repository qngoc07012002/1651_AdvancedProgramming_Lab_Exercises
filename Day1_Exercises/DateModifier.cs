using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Exercises
{
    internal class DateModifier
    {
        private int daysDifferent;
        
        public int DaysDifferent
        {
            get { return daysDifferent; }
            set { daysDifferent = value; }
        }

        public void CalculateDifferentDays(String first, String last)
        {
            DateTime firstDate = DateTime.ParseExact(first, "yyyy MM dd", null);
            DateTime lastDate = DateTime.ParseExact(last, "yyyy MM dd", null);

            TimeSpan span = lastDate - firstDate;

            Console.WriteLine(Math.Abs(span.Days));
        }
    }
}
