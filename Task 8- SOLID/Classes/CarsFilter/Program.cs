using System;
using System.Collections.Generic;
using CarsFilter.Enums;

namespace CarsFilter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Car {Name = "Tesla model 3", Type = CarType.Sedan, Color = Color.Red},
                new Car {Name = "Jaguar F-Type", Type = CarType.Coupe, Color = Color.Blue},
                new Car {Name = "Aston Martin Vantage", Type = CarType.Coupe, Color = Color.Red},
                new Car {Name = "Cybertruck", Type = CarType.Truck, Color = Color.Gray},
                new Car {Name = "Mercedes Benz A Class", Type = CarType.Sedan, Color = Color.Blue}
            };

            var filter = new CarFilter();

            var sedanCars = filter.FilterByType(cars, CarType.Sedan);
            Console.WriteLine($"All {nameof(sedanCars)}");
            foreach (var car in sedanCars)
            {
                Console.WriteLine($"Name: {car.Name}, Type: {car.Type}, Color: {car.Color}");
            }
        }
    }
}