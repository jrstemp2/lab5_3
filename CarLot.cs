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
            for (int i = 0;i < inventory.Count; i++)
            {
                if (inventory[i].Id == id)
                {
                    inventory.Remove(inventory[i]);
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
