
namespace Task3
{
    class MyDictionary<TKey, TValue> : IMyInterface<TKey, TValue>
    {
        TKey[] keys = new TKey[default];
        TValue[] values = new TValue[default];

        public void Add(TKey a, TValue b)
        {
            TKey[] tempKey = new TKey[keys.Length + 1];
            TValue[] tempValues = new TValue[keys.Length + 1];

            for (int i = 0; i < keys.Length; i++)
            {
                tempKey[i] = keys[i];
                tempValues[i] = values[i];
            }

            tempKey[keys.Length] = a;
            tempValues[keys.Length] = b;

            keys = tempKey;
            values = tempValues;
        }

        public string this[TKey index]
        {
            get
            {
                for (int i = 0; i < keys.Length; i++)
                    if (keys[i].ToString() == index.ToString())
                        return keys[i].ToString() + " - " + values[i].ToString();

                return "Перевода для " + index + " не найденно.";
            }
        }

        public string this[int index]
        {
            get
            {
                if ((index >= 0) && (index < keys.Length))
                    return keys[index].ToString() + " - " + values[index].ToString();

                else
                    return "Не верный индекс.";
            }
        }

        public int Length { get { return keys.Length; } }
    }
}
