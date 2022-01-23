using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dic = new MyDictionary<string, string>();

            dic.Add("ручка", "pen");
            dic.Add("солнце", "sun");
            dic.Add("яблоко", "apple");
            dic.Add("машина", "car");
            dic.Add("дом", "house");

            Console.WriteLine(dic["яблоко"]);
            Console.WriteLine(dic["газета"]);

            Console.WriteLine(new string('-', 30));

            for (int i = 0; i < dic.Length; i++)
                Console.WriteLine(dic[i]);

            Console.WriteLine("\n" + dic[8]);

            Console.ReadKey();
        }
    }
}
