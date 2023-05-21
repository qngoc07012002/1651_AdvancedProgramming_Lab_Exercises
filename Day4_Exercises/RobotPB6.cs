using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal class RobotPB6 : ICelebratable
    {
        public string Model { get; set; }
        public string ID { get; set; }

        public RobotPB6(string model, string id)
        {
            Model = model;
            ID = id;
        }

        public DateTime GetBirthdate()
        {
            return DateTime.MinValue;
        }
    }
}
