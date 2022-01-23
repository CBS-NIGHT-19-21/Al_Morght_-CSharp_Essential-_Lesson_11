using System;
using System.Collections;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();

            array.Add(5);
            array.Add("five");
            array.Add((double)2.56);
            array.Add(false);
            array.Add((float)0.254);
            array.Add("No problem.");


            for (int i = 0; i < array.Count; i++)
                Console.WriteLine(array[i]);

            //Я возможно не правильно понял задание:"В коллекцию ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа,
            //переберите данную коллекцию с помощью, цикла for – С какой проблемой вы столкнулись ?"
            //Но я не столкнулся ни с одной проблемой если несчитать таковой необходимость добавить библиотеку "using System.Collections;".

            Console.ReadKey();
        }
    }
}
