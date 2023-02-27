using System.Diagnostics;

namespace _7._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            CatalogVehicle cv = new CatalogVehicle();

            while (input != "end")
            {
                string[] token = input.Split("/");                

                if (token[0] == "Car")
                {
                    cv.Cars.Add(new Car
                    {
                        Brand = token[1],
                        Model = token[2],
                        horsePower = token[3]
                    });                   
                }
                else
                {
                    cv.Trucks.Add(new Truck
                    {
                        Brand = token[1],
                        Model = token[2],
                        Weight = token[3]
                    });
                }

                input = Console.ReadLine();
            }
            
            if(cv.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in cv.Cars.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.horsePower}hp");
                }
            }
            if (cv.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck car in cv.Trucks.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.Weight}kg");
                }
            }
        }

        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Weight { get; set; }
        }

        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string horsePower { get; set; }
        }

        class CatalogVehicle
        {
            public CatalogVehicle()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }
            public List<Car> Cars { get; set;}
            public List<Truck> Trucks { get; set;}
        }
    }
}