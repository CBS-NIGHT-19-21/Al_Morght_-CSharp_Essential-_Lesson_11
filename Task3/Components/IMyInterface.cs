
namespace Task3
{
    interface IMyInterface<TKey, TValue>
    {
        void Add(TKey a, TValue b);

        string this[TKey index] { get; }

        string this[int index] { get; }

        int Length { get; }
    }
}
