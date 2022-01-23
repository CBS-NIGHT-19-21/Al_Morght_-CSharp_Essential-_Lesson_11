using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(15);
            list.Add("Hello");
            list.Add('e');
            list.Add((double)2.25);
            list.Add(true);

            for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i]);

            Console.WriteLine(new string('-',30));

            Console.WriteLine(list.Contains("Hello"));

            Console.WriteLine(new string('-', 30));

            list.Clear();

            list.Add("New");
            list.Add("List");

            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);

            Console.ReadKey();
        }
    }
}
