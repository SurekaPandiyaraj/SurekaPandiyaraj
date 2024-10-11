using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem
{
    internal class CarManager
    {
        public List<Car> cars;
      

        public CarManager()
        {
            cars = new List<Car>();
        }

      public void  CreateCar(int carId, string brand, string model, decimal rentalPrice)
      {
            Car car = new Car(carId, brand, model, rentalPrice);
            cars.Add(car);
            Console.WriteLine("Add car successfully!");
      }

        public void ReadCar()
        {
            if (cars.Count == 0)
            {
                Console.WriteLine("No Cars available");
            }
            else
            {
                Console.WriteLine("Programs lists:");
                foreach (var car in cars)
                {
                    Console.WriteLine(car.ToString());
                }
            }  
            
        }

        public void UpdateCar(int carId)
        {
            var car = cars.Find(c => c.carId == carId);
            if (car != null)
            {

                Console.WriteLine("Car update successfully");
            }
            else
            {
                Console.WriteLine("No Car found");
            }
        }

        public void DeleteCar(int carId)
        {
            var car = cars.Find(c => c.carId.carId);
            if (car != null)
            {
                cars.Remove(car);
                Console.WriteLine("Car deleted successfully");
            }
            else
            {
                Console.WriteLine("No car found");
            }
        }

        public int ValidateCarRentalPrice(int carId)
        {
            decimal price;
            while (true)
            {
                Console.WriteLine("Enter the program price");
                if (decimal.TryParse(Console.ReadLine(), out price) && price > 0)
                {
                    return price;
                }
                Console.WriteLine("Invalid price!! Please enter correct value");
            }


        }


    }
}
