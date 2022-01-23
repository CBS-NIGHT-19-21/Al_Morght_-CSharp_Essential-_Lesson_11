
namespace Task4
{
    class ArrayList : IArrayList
    {
        object[] array = new object[default];

        public void Add(object value)
        {
            object[] tmpArray = new object[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
                tmpArray[i] = array[i];

            tmpArray[array.Length] = value;

            array = tmpArray;
        }

        public void Clear() { array = new object[default]; }

        public object this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];

                return default;
            }
        }

        public string Contains(object value)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == value)
                    return "Массив содержит " + value;

            return "Массив не содержит " + value;
        }

        public int Length { get { return array.Length; } }
    }
}
