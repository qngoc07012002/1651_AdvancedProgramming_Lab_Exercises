using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Exercises
{
    internal class Car
    {
        private String model;
        private float fuelAmount;
        private float fuelConsumptionFor1km;
        private float amountOfKm = 0;


        public String Model { get { return model; } set { model = value; } }
        public float FuelAmount { get { return fuelAmount; } set { fuelAmount = value; } }
        public float FuelConsumptionFor1km { get { return fuelConsumptionFor1km; } }
        public float AmountOfKm { get { return amountOfKm; } set { amountOfKm = value; } }

        public Car(string model, float fuelAmount, float fuelConsumptionFor1km)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionFor1km = fuelConsumptionFor1km;
        }

        public override string ToString()
        {
            return $"{this.model} {this.fuelAmount} {this.amountOfKm}";
        }


    }
}
