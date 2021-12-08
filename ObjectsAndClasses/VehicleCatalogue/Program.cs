using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cars> catalogue = new List<Cars>();
            int counterCars = 0;
            int counterTrucks = 0;
            double sumCars = 0;
            double sumTrucks = 0;
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }
                string typeOfvehicle = input[0];
                string model = input[1];
                string color = input[2];
                double horsepower = double.Parse(input[3]);
                if (typeOfvehicle == "car")
                {
                    typeOfvehicle = "Car";
                    counterCars += 1;
                    sumCars += horsepower;
                }
                if (typeOfvehicle == "truck")
                {
                    typeOfvehicle = "Truck";
                    counterTrucks += 1;
                    sumTrucks += horsepower;
                }
                Cars cars = new Cars(typeOfvehicle, model, color, horsepower);
                catalogue.Add(cars);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Close the Catalogue")
                {
                    double averageCar = sumCars / counterCars;
                    double averageTruck = sumTrucks / counterTrucks;
                    if (averageTruck > 0 && averageCar > 0
                        )
                    {
                        Console.WriteLine($"Cars have average horsepower of: {averageCar:f2}.");
                        Console.WriteLine($"Trucks have average horsepower of: {averageTruck:f2}.");
                        break;
                    }
                    else if (counterTrucks == 0)
                    {
                        Console.WriteLine($"Cars have average horsepower of: {averageCar:f2}.");
                        Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
                        break;
                    }
                    else if (counterCars == 0)
                    {
                        Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
                        Console.WriteLine($"Trucks have average horsepower of: {averageTruck:f2}.");
                        break;
                    }

                }

                foreach (var car in catalogue)
                {
                    if (car.Model == input)
                    {
                        Console.WriteLine("Type: " + car.TypeOfVehicle);
                        Console.WriteLine("Model: " + car.Model);
                        Console.WriteLine("Color: " + car.Color);
                        Console.WriteLine("Horsepower: " + car.HorsePower);
                    }
                }
            }
        }
    }
    class Cars
    {
        public Cars(string typeOfvehicle, string model, string color, double horsepower)
        {
            TypeOfVehicle = typeOfvehicle;
            Model = model;
            Color = color;
            HorsePower = horsepower;
        }
        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
        public override string ToString()
        {
            return $"Type: {TypeOfVehicle} Model: {Model} Color: {Color} Horsepower: {HorsePower}";
        }
    }
}