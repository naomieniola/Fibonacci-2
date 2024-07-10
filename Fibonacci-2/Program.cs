//int f(int n) = int n-1 + int n-2;

//for (int f = 0; f < 100; f++)
//{

//}

using System;

class Program
{
    public static void Main(string[] args)
    {
        uint n = 20;
        n--; // where the first number in sequence is 0
        uint sequence = n;
        // Console.WriteLine(sequence);
        Console.WriteLine($"The answer for sequence {sequence} is {Fibonacci(n)}");
    }

    private static ulong Fibonacci(uint n)
    {
        if (n <= 1)
        {
            return n;
        }
        return Fibonacci(n - 2) + Fibonacci(n - 1);
    }
}
