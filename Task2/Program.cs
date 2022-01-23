using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCollection<string> cars = new CarCollection<string>();

            cars.Add("Mersedes", "1980");
            cars.Add("BMW", "1990");
            cars.Add("Audi", "2000");
            cars.Add("Volvo", "2010");
            cars.Add("Wolkswagen", "2015");

            for (int i = 0; i < cars.Length; i++)
                Console.WriteLine(cars[i]);

            cars.Clean();

            cars.Add("Mersedes", "1980");
            cars.Add("BMW", "1990");
            cars.Add("Audi", "2000");

            Console.WriteLine(new string('-', 30));

            Console.WriteLine(cars["Audi"]);
            Console.WriteLine(cars["BMW"]);
            Console.WriteLine(cars["Mersedes"]);

            Console.WriteLine(new string('-',30));

            Console.WriteLine(cars["Nissan"]);

            Console.ReadKey();
        }
    }
}
