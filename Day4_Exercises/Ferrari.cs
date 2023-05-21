using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal class Ferrari : ICar
    {
        private string model;
        private string driverName;

        public string Model { get { return model; } set { model = value; } }

        public string DriverName { get { return driverName; } set { driverName = value; } }

        public Ferrari(string driverName)
        {
            model = "488-Spider";
            this.driverName = driverName;
        }

        public string Brake()
        {
            return "Brakes!";
        }

        public string PushGas()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{model}/{Brake()}/{PushGas()}/{driverName}";
        }
    }
}
