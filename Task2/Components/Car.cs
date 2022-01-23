
namespace Task2
{
    class Car<T>
    {
        T name, yaer;

        public Car(T a, T b)
        {
            name = a;
            yaer = b;
        }

        public T Name { get { return name; } }

        public T Yaer { get { return yaer; } }

    }
}
