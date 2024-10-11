using CarRentalManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager();
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("\nCarRental Management System:");
                Console.WriteLine("1. Add a Car");
                Console.WriteLine("2. View All Cars");
                Console.WriteLine("3. Update a Car");
                Console.WriteLine("4. Delete a Car");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.CreateCar(carManager);
                        break;
                    case "2":
                        Console.Clear();
                        carManager.ReadCar();
                        break;
                    case "3":
                        Console.Clear();
                        Console.UpdateCar(carManager);
                        break;
                    case "4":
                        Console.Clear();
                        Console.DeleteCar(carManager);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Pleace select valid choice");
                        break;
                }

                if (exit)
                {
                    exit = true;
                    Console.ReadLine();

                }
            }

        }

        static void CreateCar(CarManager carManager)
        {
            Console.WriteLine("Enter Car Brand:");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter Car Model:");
            string model = Console.ReadLine();

            decimal price = carManager.ValidateCarRentalPrice();
        }

        static void UpdateCar(CarManager carManager)
        {
            Console.WriteLine("Enter Car ID  to update:");
            int carid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new Brand:");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter new Model:");
            string model = Console.ReadLine();
            
            decimal price = carManager.ValidateCarRentalPrice();
        }

        static void DeleteCar(CarManager carManager)
        {
            Console.WriteLine("Enter Car ID  to delete:");
            int id = int.Parse(Console.ReadLine());

            carManager.DeleteCar(id);
        }
    }
}
