using System;

namespace _6._Vehicle_Catalogue
{
    internal class Program
    {

        static List<Vehicle> vehicles = new List<Vehicle>();

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while(input != "End")
            {
                string[] token = input.Split().ToArray();
                vehicles.Add(new Vehicle(token[0] == "car" ? "Car" : "Truck", token[1], token[2], int.Parse(token[3])));
                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            int carsTotalPower = 0;
            double carscount = 0;

            int truckTotalPower = 0;
            double truckcount = 0;

            while(input != "Close the Catalogue")
            {
                List<Vehicle> vehicle = new List<Vehicle>();
                Vehicle v = GetVehicle(input);

                Console.WriteLine($"Type: {v.Type}");
                Console.WriteLine($"Model: {v.Model}");
                Console.WriteLine($"Color: {v.Color}");
                Console.WriteLine($"Horsepower: {v.Horsepower}");

                input = Console.ReadLine();
            }
            if (CarsCount() == 0) { Console.WriteLine($"Cars have average horsepower of: 0.00."); }
            else Console.WriteLine($"Cars have average horsepower of: {(CarsAverageHorsePower()/ CarsCount()):F2}.");
            if(TrucksCount() == 0) { Console.WriteLine($"Trucks have average horsepower of: 0.00."); }
            else Console.WriteLine($"Trucks have average horsepower of: {(TruckAverageHorsePower()/ TrucksCount()):F2}.");
        }

        public static Vehicle GetVehicle(string name) => vehicles.Where(x => x.Model == name).ToArray()[0];

        public static double CarsAverageHorsePower()
        {
            double total = 0;

            foreach (Vehicle v in vehicles.Where(x => x.Type == "Car"))
            {
                total += v.Horsepower;
            }

            return total;
        }

        public static double TruckAverageHorsePower()
        {
            double total = 0;

            foreach (Vehicle v in vehicles.Where(x => x.Type == "Truck"))
            {
                total += v.Horsepower;
            }

            return total;
        }

        public static int CarsCount() => vehicles.Where(x => x.Type == "Car").Count();
        public static int TrucksCount() => vehicles.Where(x => x.Type == "Truck").Count();

        public class Vehicle
        {

            public Vehicle(string Type, string Model, string Color, int Horsepower)
            {
                this.Type = Type;
                this.Model = Model;
                this.Color = Color;
                this.Horsepower = Horsepower;
            }

            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int Horsepower { get; set; }


        }
    }
}