using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal class Robot : ACitizen
    {
        private string model;

        public string Model { get { return model; } set { model = value; } }

        public Robot(string id, string model) : base(id)
        {
            Model = model;
        }
    }
}
