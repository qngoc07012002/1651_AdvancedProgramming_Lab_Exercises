using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal interface IMission
    {
        string CodeName { get; }
        string State { get; }
        void CompleteMission();
    }
}
