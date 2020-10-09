using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
            int n = int.Parse(Console.ReadLine());
            //Reverse() е void метод което означава че модифицира настоящата колекция (не връща нова т.е. не така List<int> reversedNumbers = numbers.Reverse();); да презаписваме на друга променлива а така numbers.Reverse(); !!!
            numbers.Reverse();
            //решение с предикат:
            //Func <int, bool> predicate = x => x % n != 0;
            //numbers = numbers.Where(predicate).ToList();

            numbers = numbers.Where(x => x % n != 0).ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
