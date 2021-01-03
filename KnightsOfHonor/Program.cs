using System;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => "Sir" + " " + n).ToArray();
            Action<string[]> printNames = items => Console.WriteLine(string.Join(Environment.NewLine, items));
            printNames(names);

            //static void PrintNames(string[] array)
            //{
            //    Console.WriteLine(string.Join(Environment.NewLine/*"\n"*/, array));
            //    //Console.WriteLine($"Sir (string.Join(\nSir ", array));
            //}
        }
    }
}
