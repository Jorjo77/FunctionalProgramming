using System;
using System.Linq;

namespace ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> action = items => Console.WriteLine(string.Join(Environment.NewLine, items));
            string[] input = Console.ReadLine().Split();

            action(input);

            //А ето и най-съкратения вариант:
            //Console.ReadLine()
            //    .Split()
            //    .ToList()
            //    .ForEach(Console.WriteLine);

            //    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    Action<string[]> printInput = PrintInput;
            //    printInput(input);
            //}
            //static void PrintInput(string[] array)
            //{
            //    Console.WriteLine(string.Join(/*"\n"*/Environment.NewLine, array));
            //}
        }
    }
}
