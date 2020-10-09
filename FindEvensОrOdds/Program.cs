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
            //тук за демо разписваме и двата начина:
            //ако променим лампдата на труе ще печата всички числа
            Predicate<int> evenPredicate = n => n % 2 == 0;
            if (command == "odd")
            {
                evenPredicate = n => n % 2 != 0;
            }
            numbers = MyWhere(numbers, evenPredicate);
            //Func<int, bool> evenPredicate = n => n % 2 == 0;
            //numbers = numbers.Where(evenPredicate).ToList();
            Console.WriteLine(string.Join(" ",numbers));
        }
        static List<int> MyWhere(List<int> numbers, Predicate<int> predicate)
        {
            List<int> res = new List<int>();
            foreach (var number in numbers)
            {
                if (predicate(number))
                {
                    res.Add(number);
                }
            }
            return res;
        }
    }
}
