using System;
using System.Linq;

namespace Sumary
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateNumbers(5, 6, Sum);
            CalculateNumbers(5, 6, Divide);
            CalculateNumbers(5, 6, Multiply);
        }
        static void CalculateNumbers(int a, int b, Func<int, int, int> operation)
        {
            Console.WriteLine($"Calculating {a} and {b}");
            int result = operation(a, b);
            Console.WriteLine($"The result is: {result}");
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
