namespace Custom
{
    internal class CustomList<T>
    {
        private T[] items;
        private int count;
        private int capacity;
        public int Count { get => count; }
        public int Capacity { get => capacity; }

        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;
        }
        public void Add(T item)
        {
            if (count == capacity)
            {
                capacity *= 2;
                T[] newItems = new T[capacity];
                Array.Copy(items, newItems, count);
                items = newItems;
            }

            items[count] = item;
            count++;
        }
        public void GetAll()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
        public void Remove(T item)
        {
            var index = Array.IndexOf(items, item);

            if (index >= 0)
            {
                for (int i = index; i < count - 1; i++)
                {
                    items[i] = items[i + 1];
                }

                items[count - 1] = default; 
                count--;
            }
        }
        public bool Contains(T item)
        {
            int Index = Array.IndexOf(items, item);
            if (Index != -1)
            {
                return true;
            }
            return false;
        }
        public bool Any()
        {
            if (count > 0)
            {
                return true;

            }
            return false;
        }
        public void Clear()
        {
            for (int i = 0; i < count; i++)
            {
                items[i] = default;
                
            }
            count = 0;
        }
        public T FirstOrDefault()
        {
            if (count > 0)
            {
                return items[0];
            }
            return default(T);
        }
        public T ElementAtOrDefault(int index)
        {
            if (index >= 0 && index < count)
            {
                return items[index];
            }
            return default(T);
        }
        public T LastOrDefault()
        {
            if (count > 0)
            {
                return items[count - 1];
            }
            return default(T);
        }






    }
}
