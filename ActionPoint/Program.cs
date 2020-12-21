using System;

namespace ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> printInput = PrintInput;
            printInput(input);
        }
        static void PrintInput(string[] array)
        {
            Console.WriteLine(string.Join(/*"\n"*/Environment.NewLine, array));
        }
    }

}
