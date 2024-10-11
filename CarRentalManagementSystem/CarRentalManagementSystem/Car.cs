using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem
{
    internal class Car
    {
        private int CarId { get; set; }
        private string Brand { get; set; }
        private string Model { get; set; }
        private decimal RentalPrice { get; set; }
        public int TotalCar {  get; set; }
      

        public Car(int carId, string brand, string model, decimal rentalPrice)
        {
            CarId = carId;
            Brand = brand;
            Model = model;
            RentalPrice = rentalPrice;
            TotalCar++;
        }

        public override string ToString()
        {
            return $"ID: {CarId}, Brand: {Brand}, Model: {Model}, RentalPrice: {RentalPrice}";
        }
    }
}
