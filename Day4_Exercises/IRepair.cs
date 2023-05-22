using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal interface IRepair
    {
        string PartName { get; }
        int HoursWorked { get; }
    }
}
