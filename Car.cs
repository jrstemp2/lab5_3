using System;
using System.Collections.Generic;
using System.Text;

namespace lab5_3
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double price;
        private int id;
        

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }

        

        public int Id { get => id; set => id = value; }

        public Car()
        {
            make = "";
            model = "";
            year = 0;
            price = 0;
            id = 0;
        }

        public Car(string make, string model, int year, double price, int id)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            this.id = id;
        }

        
        public override string ToString()
        {
            return $"ID: {id}\nMake: {make}\nModel: {model}\nYear: {year}\nPrice: ${price}";
        }
    }
}
