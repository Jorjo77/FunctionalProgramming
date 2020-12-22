using System;
using System.Linq;

namespace MyParse
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Console.ReadLine()
                .Split(", ")
                .Select(Parse);

            Console.WriteLine(string.Join(", ", result));
            Console.WriteLine(result.Count());
            Console.WriteLine(result.Sum());
        }
        static int Parse(string str)
        {
            int number = 0;
            foreach (var ch in str)
            {
                number *= 10;
                number += ch - '0';
            }
            return number;
        }
    }
}
