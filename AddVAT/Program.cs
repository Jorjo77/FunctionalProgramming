using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine()
                .Split(", ")
                .Select(decimal.Parse)
                .Select(x=>x *1.2m)
                .ToArray();
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:f2}");
            }
        }
    }
}
