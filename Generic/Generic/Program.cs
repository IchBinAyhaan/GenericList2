class Program
{
    static void SwapAndPrint<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
        Console.WriteLine("a: " + a);
        Console.WriteLine("b: " + b);
    }

    static void Main(string[] args)
    {
        int x = 5;
        int y = 10;
        Console.WriteLine("Before swapping:");
        Console.WriteLine("x: " + x);
        Console.WriteLine("y: " + y);

        SwapAndPrint(ref x, ref y);

        Console.WriteLine("After swapping:");
        Console.WriteLine("x: " + x);
        Console.WriteLine("y: " + y);
    }
}
