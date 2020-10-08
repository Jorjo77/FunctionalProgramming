using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensОrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ranges = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int start = ranges[0];
            int end = ranges[1];
            string command = Console.ReadLine();
            Func<int, int, List<int>> generateList = (start, end) =>
            {
                List<int> nums = new List<int>();
                for (int i = start; i <= end; i++)
                {
                    nums.Add(i);
                }
                return nums;
            };
            List<int> numbers = generateList(start, end);
            Predicate<int> evenPredicate = n => n % 2 == 0;
            numbers = numbers.Where()
        }
    }
}
