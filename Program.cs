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
            int id = 2;
            int buy;
            string searchMake;

            CarLot lot1 = new CarLot();
            Console.WriteLine("Welcome to the Car Lot!");
            lot1.AddCar(new UsedCar("OLDSMOBILE", "INTRIGUE", 1999, 5000, 1, 60000));
            lot1.AddCar(new UsedCar("FORD", "EDGE", 2017, 25000, 2, 40000));
            

            do
            {
                Console.Clear();
                MenuItems();
                Console.WriteLine();
                Console.Write("Please select an option 1-5: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Please provide the Make: ");
                    make = Console.ReadLine().ToUpper();

                    Console.Write("Please Provide the Model: ");
                    model = Console.ReadLine().ToUpper(); ;

                    Console.Write("Please enter the year: ");
                    year = int.Parse(Console.ReadLine());

                    Console.Write("Please enter the price: ");
                    price = int.Parse(Console.ReadLine());

                    id++;

                    Console.Write("Please provide the mileage: ");
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
                    Console.Clear();
                    SearchOptions();
                    Console.Write("Please enter a number 1-4: ");
                    choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.Write("Please Enter a Make to search by: ");
                        searchMake = Console.ReadLine().ToUpper();
                        lot1.SearchCar(searchMake);
                    }
                    else if (choice == 2)
                    {
                        Console.Write("Please Enter a Model to search by: ");
                        string searchModel = Console.ReadLine().ToUpper();
                        lot1.SearchCar(searchModel);
                    }
                    else if (choice == 3)
                    {
                        Console.Write("Please Enter a Year to search by: ");
                        int searchYear = int.Parse(Console.ReadLine());
                        lot1.SearchCar(searchYear);
                    }
                    else if (choice == 4)
                    {
                        Console.Write("Please Enter a Maximum number of miles to search by: ");
                        double searchMiles = int.Parse(Console.ReadLine());
                        lot1.SearchCar(searchMiles);
                    }





                }

                if (choice == 5)
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
            Console.WriteLine("=================================");
            Console.WriteLine("1. Add a Car");
            Console.WriteLine("2. Buy a Car");
            Console.WriteLine("3. Print List of Inventory");
            Console.WriteLine("4. Search by Make");
            Console.WriteLine("5. Quit");
            Console.WriteLine("=================================");
        }

        static void SearchOptions()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("What would you like to search by? ");
            Console.WriteLine("1. Make");
            Console.WriteLine("2. Model");
            Console.WriteLine("3. Year");
            Console.WriteLine("4. Price");
            Console.WriteLine("=================================");

        }
    }
}
