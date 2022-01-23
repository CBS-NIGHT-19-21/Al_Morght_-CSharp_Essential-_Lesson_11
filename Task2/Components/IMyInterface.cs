
namespace Task2
{
    interface IMyInterface<T>
    {
        void Add(T a, T b);

        string this[int index] { get; }

        string this[T index] { get; }

        int Length { get; }
    }
}
