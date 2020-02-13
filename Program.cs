using System;
using System.Collections.Generic;

namespace lab5_3
{
    class Program

    {
        



        static List<Car> cars = new List<Car>();
        static void Main(string[] args)
        {

            int choice;
          
            string make;
            string model;
            int year;
            int price;
            double mileage;
            int id;
            int buy;
            CarLot lot1 = new CarLot();
            Console.WriteLine("Welcome to the Car Lot!");
            lot1.AddCar(new UsedCar("Oldsmobile", "Intrigue", 1999, 5000, 1, 60000));
            lot1.AddCar(new UsedCar("Ford", "Edge", 2017, 25000, 2, 40000));
            MenuItems();
            Console.WriteLine();

            do
            {
                Console.Write("Please select an option");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Please provide the Make: ");
                    make = Console.ReadLine();

                    Console.Write("Please Provide the Model: ");
                    model = Console.ReadLine();

                    Console.Write("Please enter the year: ");
                    year = int.Parse(Console.ReadLine());

                    Console.Write("Please enter the price: ");
                    price = int.Parse(Console.ReadLine());

                    Console.Write("Please enter the ID: ");
                    id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please provide the mileage: ");
                    mileage = double.Parse(Console.ReadLine());
                    lot1.AddCar(new UsedCar(make, model, year, price, id, mileage));
                }
                
                if (choice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Here is the inventory:");
                    lot1.ListCars();
                    Console.Write("Please enter the ID number of the car you want to purchase: ");
                    buy = int.Parse(Console.ReadLine());

                    lot1.RemoveCar(buy);
                    

                }

                if (choice == 3)
                {
                    lot1.ListCars();
                }

                if (choice == 4)
                {
                    break;
                }
                
                
            } while (GoAgain());
            

            


            
        }

        static bool GoAgain()
        {
            char c;
            do
            {
                Console.Write("Would you like to do something else? ");
                c = Console.ReadKey().KeyChar;
                if (c == 'n')
                {
                    return false;
                }


            } while (c != 'y');
            return true;
        }

        static void MenuItems()
        {
            Console.WriteLine("1. Add a Car");
            Console.WriteLine("2. Buy a Car");
            Console.WriteLine("3. Print List of Inventory");
            Console.WriteLine("4. Quit");
        }
        
    }
}
