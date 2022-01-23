
namespace Task2
{
    class CarCollection<T> : IMyInterface<T>
    {
        Car<T>[] collection = new Car<T>[default];

        public void Add(T n, T y)
        {
            Car<T>[] tmpColl = new Car<T>[collection.Length + 1];

            for (int i = 0; i < collection.Length; i++)
                tmpColl[i] = collection[i];

            tmpColl[collection.Length] = new Car<T>(n, y);

            collection = tmpColl;
        }

        public void Clean()
        {
            collection = new Car<T>[default];
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < collection.Length)
                    return collection[index].Name + " " + collection[index].Yaer;
                else
                    return "Попытка выхода за пределы массива.";
            }
        }

        public string this[T index]
        {
            get
            {
                for (int i = 0; i < collection.Length; i++)
                    if (collection[i].Name.ToString() == index.ToString())
                        return collection[i].Name + " " + collection[i].Yaer;

                return "Такой записи в колекции не найдено.";
            }
        }

        public int Length { get { return collection.Length; } }
    }
}
