using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensОrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>();

            string[] range = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int minBound = int.Parse(range[0]);

            int maxBound = int.Parse(range[1]);

            string command = Console.ReadLine();

            for (int i = minBound; i < maxBound; i++)
            {
                result.Add(i);
            }

            Action<List<int>> printResult = nums
                => Console.WriteLine(string.Join(" ", result));

            Predicate<int> isEvenPredicate = x => x % 2 == 0;
            if (command == "even")
            {
                result.RemoveAll(x => !isEvenPredicate(x));
            }

            else if (command == "odd")
            {
                result.RemoveAll(x => isEvenPredicate(x));
            }
            printResult(result);
        }







        //string[] range = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        //int minBound = int.Parse(range[0]); 

        //int maxBound = int.Parse(range[1]);

        //string command = Console.ReadLine();

        //Func<int, bool> predicate;//Само че решението е с Func, а не с Predicate!!!
        //if (command == "even")
        //{
        //    predicate = x => x % 2 == 0;
        //}

        //else if (command == "odd")
        //{
        //    predicate = x => x % 2 != 0;
        //}
        //else
        //{
        //    predicate = null;
        //}

        //int count = maxBound - minBound + 1;

        //var result = Enumerable.Range(minBound, count).Where(predicate);

        //Console.WriteLine(string.Join(" ", result));





        //    int[] ranges = Console.ReadLine()
        //        .Split()
        //        .Select(int.Parse)
        //        .ToArray();
        //    int start = ranges[0];
        //    int end = ranges[1];
        //    string command = Console.ReadLine();
        //    Func<int, int, List<int>> generateList = (start, end) =>
        //    {
        //        List<int> nums = new List<int>();
        //        for (int i = start; i <= end; i++)
        //        {
        //            nums.Add(i);
        //        }
        //        return nums;
        //    };
        //    List<int> numbers = generateList(start, end);
        //    //тук за демо разписваме и двата начина:
        //    //ако променим лампдата на труе ще печата всички числа
        //    Predicate<int> evenPredicate = n => n % 2 == 0;
        //    if (command == "odd")
        //    {
        //        evenPredicate = n => n % 2 != 0;
        //    }
        //    numbers = MyWhere(numbers, evenPredicate);
        //    //Func<int, bool> evenPredicate = n => n % 2 == 0;
        //    //numbers = numbers.Where(evenPredicate).ToList();
        //    Console.WriteLine(string.Join(" ",numbers));
        //}
        //static List<int> MyWhere(List<int> numbers, Predicate<int> predicate)
        //{
        //    List<int> res = new List<int>();
        //    foreach (var number in numbers)
        //    {
        //        if (predicate(number))
        //        {
        //            res.Add(number);
        //        }
        //    }
        //    return res;
        //}

    }
}
