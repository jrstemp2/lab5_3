using System;
using System.Collections.Generic;
using System.Text;

namespace lab5_3
{
    class CarLot
    {
        private List<Car> inventory;
        public CarLot()
        {
            this.inventory = new List<Car>();
        }
        public void AddCar(Car c)
        {


            inventory.Add(c);

        }

        public void RemoveCar(int id)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].Id == id)
                {
                    inventory.Remove(inventory[i]);
                }
            }
        }

        public void SearchCar(string make)
        {

            foreach (Car c in inventory)
            {

                if (c.Make == make)
                {
                    Console.WriteLine(c);
                }
                else if (c.Model == make)
                {
                    Console.WriteLine(c);
                }
            }
        }

        public void SearchCar(int input)
        {

            foreach (Car c in inventory)
            {

                if (c.Year <= input)
                {
                    Console.WriteLine(c);
                }

            }
        }
        public void SearchCar(double input)
        {

            foreach (UsedCar c in inventory)
            {

                if (c.Mileage <= input)
                {
                    Console.WriteLine(c);
                }

            }
        }

        public void ListCars()
        {
            foreach (Car c in inventory)
            {
                Console.WriteLine(c);
                Console.WriteLine("===================");
            }
        }

    }
}
