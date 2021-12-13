using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryExercise3
{
    class CarInfo
    {
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, CarInfo> car = new Dictionary<string, CarInfo>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var commands = Console.ReadLine().Split("|");
                var carModel = commands[0];
                var mileage = int.Parse(commands[1]);
                var fuel = int.Parse(commands[2]);
                if (!car.ContainsKey(carModel))
                {
                    car.Add(carModel, new CarInfo { Mileage = mileage, Fuel = fuel });
                }
            }
            var cmds = Console.ReadLine();
            while (cmds != "Stop")
            {
                var tokens = cmds.Split(" : ");
                if (tokens[0] == "Drive")
                {
                    var carModel = tokens[1];
                    var distance = int.Parse(tokens[2]);
                    var fuel = int.Parse(tokens[3]);
                    if (car.ContainsKey(carModel))
                    {

                        if (car[carModel].Fuel <= fuel)
                        {
                            Console.WriteLine($"Not enough fuel to make that ride");
                        }
                        else
                        {
                            car[carModel].Mileage += distance;
                            car[carModel].Fuel -= fuel;
                            Console.WriteLine($"{carModel} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }
                        if (car[carModel].Mileage >= 100000)
                        {
                            car.Remove(carModel);
                            Console.WriteLine($"Time to sell the {carModel}!");
                        }
                    }
                }
                else if (tokens[0] == "Refuel")
                {
                    var carModel = tokens[1];
                    var fuel = int.Parse(tokens[2]);
                    if (car.ContainsKey(carModel))
                    {
                        var saveFuel = car[carModel].Fuel;
                        car[carModel].Fuel += fuel;
                        if (car[carModel].Fuel > 75)
                        {
                            car[carModel].Fuel = 75;
                            Console.WriteLine($"{carModel} refueled with {car[carModel].Fuel - saveFuel} liters");
                        }
                        else
                        {
                            Console.WriteLine($"{carModel} refueled with {fuel} liters");
                        }
                    }
                }
                else if (tokens[0] == "Revert")
                {
                    var carModel = tokens[1];
                    var kilometers = int.Parse(tokens[2]);
                    if (car.ContainsKey(carModel))
                    {
                        car[carModel].Mileage -= kilometers;
                        if (car[carModel].Mileage > 10000)
                        {
                            Console.WriteLine($"{carModel} mileage decreased by {kilometers} kilometers");
                        }
                        else
                        {
                            car[carModel].Mileage = 10000;
                        }
                    }
                }

                cmds = Console.ReadLine();
            }
            car = car.OrderByDescending(x => x.Value.Mileage).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in car)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value.Mileage} kms, Fuel in the tank: {item.Value.Fuel} lt.");
            }
        }
    }
}
