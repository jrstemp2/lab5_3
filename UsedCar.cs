using System;
using System.Collections.Generic;
using System.Text;

namespace lab5_3
{
    class UsedCar : Car
    {
        private double mileage;
        public double Mileage { get => mileage; set => mileage = value; }

        public UsedCar(string make, string model, int year, double price, int id, double mileage) : base(make, model, year, price, id)
        {
            this.mileage = mileage;
        }

        public override string ToString()
        {
            return base.ToString() + $"\n(Used) Mileage: {mileage}";
        }
    }
}
