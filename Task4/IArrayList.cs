
namespace Task4
{
    interface IArrayList
    {
         void Add(object obj);

         void Clear();

        string Contains(object value);

        object this[int index] { get; }
    }
}
