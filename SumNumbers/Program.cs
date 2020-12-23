using System;
using System.Linq;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split(", ")
                .Select(ParseNumber)
                .ToArray();
            PrintResults(array, GetCount, Sum);

            //MyJob:
            //int[] result = Console.ReadLine()
            //.Split(", ", StringSplitOptions.RemoveEmptyEntries)
            //.Select(int.Parse)
            //.ToArray();
            //Console.WriteLine(result.Length);
            //Console.WriteLine(result.Sum());

        }
        static int GetCount(int[] array)
        {
            return array.Length;
        }
        static int Sum(int[] array)
        {
            return array.Sum();
        }
        static void PrintResults(int[] array, Func<int[], int> count, Func<int[], int> sum)
        {
            Console.WriteLine(count(array));
            Console.WriteLine(sum(array));
        }
        static int ParseNumber(string number)
        {
            return int.Parse(number);
        }
    }
}
