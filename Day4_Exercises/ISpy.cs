using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal interface ISpy : ISoldier
    {
        int CodeNumber { get; }
    }
}
