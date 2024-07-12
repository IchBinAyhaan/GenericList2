using System;

namespace Custom
{
    class Program
    {
        static void Main(string[] args)
        { 
            CustomList<int> list = new CustomList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.GetAll();
            list.Remove(20);
            list.GetAll();
            list.Clear();
            Console.WriteLine(list.Contains(20));
            Console.WriteLine(list.Any());
            Console.WriteLine(list.FirstOrDefault());
            Console.WriteLine(list.ElementAtOrDefault(10));
            Console.WriteLine(list.LastOrDefault());

        }
    }
}