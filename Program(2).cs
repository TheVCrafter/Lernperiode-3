using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<ICar> cars = new List<ICar>()
            {
                // Audi
                new Audi { brand = "Audi", model = "R8 e-tron", engine = "electric", horsePower = "462", maxSpeed = "250 km/h", acceleeration = "3.9 sec.", price = "170'000 €" },
                new Audi { brand = "Audi", model = "RS e-tron GT", engine = "electric", horsePower = "912", maxSpeed = "245 km/h", acceleeration = "3.2 sec.", price = "150'000 €" },

                // BMW
                new BMW { brand = "BMW", model = "i8", engine = "hybrid", horsePower = "369", maxSpeed = "250 km/h", acceleeration = "4.4 sec.", price = "140'000 €" },
                new BMW { brand = "BMW", model = "M3", engine = "petrol", horsePower = "503", maxSpeed = "290 km/h", acceleeration = "3.9 sec.", price = "80'000 €" },

                // Tesla
                new Tesla { brand = "Tesla", model = "Model S Plaid", engine = "electric", horsePower = "1,020", maxSpeed = "322 km/h", acceleeration = "2.1 sec.", price = "130'000 €" },
                new Tesla { brand = "Tesla", model = "Model 3 Performance", engine = "electric", horsePower = "450", maxSpeed = "261 km/h", acceleeration = "3.3 sec.", price = "55'000 €" },

                // Porsche
                new Porsche { brand = "Porsche", model = "911 Turbo S", engine = "petrol", horsePower = "650", maxSpeed = "330 km/h", acceleeration = "2.7 sec.", price = "210'000 €" },
                new Porsche { brand = "Porsche", model = "Taycan Turbo S", engine = "electric", horsePower = "761", maxSpeed = "260 km/h", acceleeration = "2.8 sec.", price = "185'000 €" },

                // Ferrari
                new Ferrari { brand = "Ferrari", model = "SF90 Stradale", engine = "hybrid", horsePower = "986", maxSpeed = "340 km/h", acceleeration = "2.5 sec.", price = "500'000 €" },
                new Ferrari { brand = "Ferrari", model = "F8 Tributo", engine = "petrol", horsePower = "720", maxSpeed = "340 km/h", acceleeration = "2.9 sec.", price = "240'000 €" },

                // Lamborghini
                new Lamborghini { brand = "Lamborghini", model = "Aventador SVJ", engine = "petrol", horsePower = "770", maxSpeed = "351 km/h", acceleeration = "2.8 sec.", price = "400'000 €" },
                new Lamborghini { brand = "Lamborghini", model = "Huracán EVO", engine = "petrol", horsePower = "640", maxSpeed = "325 km/h", acceleeration = "2.9 sec.", price = "200'000 €" },

                // Bugatti
                new Bugatti { brand = "Bugatti", model = "Chiron Super Sport", engine = "petrol", horsePower = "1,600", maxSpeed = "490 km/h", acceleeration = "2.4 sec.", price = "3'000'000 €" },
                new Bugatti { brand = "Bugatti", model = "Veyron Grand Sport", engine = "petrol", horsePower = "1,200", maxSpeed = "408 km/h", acceleeration = "2.5 sec.", price = "1'700'000 €" }
            };

                Console.OutputEncoding = Encoding.UTF8;
                while (true)
                {
                    Console.WriteLine("Which Car brand do you want to see? Type 'All' or the Name of the brand:");
                    string input = Console.ReadLine();
                    try
                    {
                        if (!input.Equals("all", StringComparison.OrdinalIgnoreCase))
                        {
                            int counter = 0;
                            Console.Clear();
                            Console.WriteLine("Car Data:");
                            foreach (var car in cars)
                            {
                                if (input.Equals(car.brand, StringComparison.OrdinalIgnoreCase))
                                {
                                    car.Data();
                                    counter++;
                                }
                            }
                            if (counter == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"No data available for the brand '{input}'.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Car Data:");
                            foreach (var car in cars)
                            {
                                car.Data();
                            }
                        }
                        break;
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No Data found. Make sure you entered the correct brand");
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Press [Enter] to search for new Data or [Esc] to leave the Program");
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo Key;
                while (true)
                {
                    Key = Console.ReadKey(intercept: true);
                    if (Key.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        break;
                    }
                    if (Key.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
                if (Key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }

        }

        public interface ICar
        {
            string brand { get; set; }
            string model { get; set; }
            string engine { get; set; }
            string horsePower { get; set; }
            string maxSpeed { get; set; }
            string acceleeration { get; set; }
            string price { get; set; }
            void Data();
        }

        public class Audi : ICar {public string brand { get; set; } public string model { get; set; } public string engine { get; set; } public string horsePower { get; set; } public string maxSpeed { get; set; } public string acceleeration { get; set; } public string price { get; set; } public void Data() { Console.WriteLine($@"
{brand} {model}
--------------------------------
engine:     {engine}
horsepower: {horsePower}
max Speed:  {maxSpeed}
0 - 100:    {acceleeration}
price:      {price}
--------------------------------"); } }

        public class BMW : ICar {public string brand { get; set; } public string model { get; set; } public string engine { get; set; } public string horsePower { get; set; } public string maxSpeed { get; set; } public string acceleeration { get; set; } public string price { get; set; } public void Data() { Console.WriteLine($@"
{brand} {model}
--------------------------------
engine:     {engine}
horsepower: {horsePower}
max Speed:  {maxSpeed}
0 - 100:    {acceleeration}
price:      {price}
--------------------------------"); } }

        public class Tesla : ICar {public string brand { get; set; } public string model { get; set; } public string engine { get; set; } public string horsePower { get; set; } public string maxSpeed { get; set; } public string acceleeration { get; set; } public string price { get; set; } public void Data() { Console.WriteLine($@"
{brand} {model}
--------------------------------
engine:     {engine}
horsepower: {horsePower}
max Speed:  {maxSpeed}
0 - 100:    {acceleeration}
price:      {price}
--------------------------------"); } }

        public class Porsche : ICar { public string brand { get; set; } public string model { get; set; } public string engine { get; set; } public string horsePower { get; set; } public string maxSpeed { get; set; } public string acceleeration { get; set; } public string price { get; set; } public void Data() { Console.WriteLine($@"
{brand} {model}
--------------------------------
engine:     {engine}
horsepower: {horsePower}
max Speed:  {maxSpeed}
0 - 100:    {acceleeration}
price:      {price}
--------------------------------"); } }
        public class Ferrari : ICar { public string brand { get; set; } public string model { get; set; } public string engine { get; set; } public string horsePower { get; set; } public string maxSpeed { get; set; } public string acceleeration { get; set; } public string price { get; set; } public void Data() { Console.WriteLine($@"
{brand} {model}
--------------------------------
engine:     {engine}
horsepower: {horsePower}
max Speed:  {maxSpeed}
0 - 100:    {acceleeration}
price:      {price}
--------------------------------"); } }
        public class Lamborghini : ICar { public string brand { get; set; } public string model { get; set; } public string engine { get; set; } public string horsePower { get; set; } public string maxSpeed { get; set; } public string acceleeration { get; set; } public string price { get; set; } public void Data() { Console.WriteLine($@"
{brand} {model}
--------------------------------
engine:     {engine}
horsepower: {horsePower}
max Speed:  {maxSpeed}
0 - 100:    {acceleeration}
price:      {price}
--------------------------------"); } }
        public class Bugatti : ICar { public string brand { get; set; } public string model { get; set; } public string engine { get; set; } public string horsePower { get; set; } public string maxSpeed { get; set; } public string acceleeration { get; set; } public string price { get; set; } public void Data() { Console.WriteLine($@"
{brand} {model}
--------------------------------
engine:     {engine}
horsepower: {horsePower}
max Speed:  {maxSpeed}
0 - 100:    {acceleeration}
price:      {price}
--------------------------------"); } }
    }
}
