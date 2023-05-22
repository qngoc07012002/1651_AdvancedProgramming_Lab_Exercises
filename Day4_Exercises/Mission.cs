using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal class Mission : IMission
    {
        public string CodeName { get; }
        public string State { get; private set; }

        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            State = state;
        }

        public void CompleteMission()
        {
            State = "Finished";
        }

        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {State}";
        }
    }
}
