using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> func = inputNumbers =>
            {
                int minValue = int.MaxValue;
                foreach (var currNumber in inputNumbers)
                {
                    if (currNumber < minValue)
                    {
                        minValue = currNumber;
                    }
                }
                return minValue;
            };

            int[] numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

            int result = func(numbers);

            Console.WriteLine(result);


            //Func<string, int> myIntParse = s => int.Parse(s);
            //int[] numbers = Console.ReadLine()
            //.Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //.Select(myIntParse).ToArray();
            //.Select(int.Parse).ToArray();
            //.Select(x => int.Parse(x)) еквивалентно с горния съкратен запис

            //решение на един ред (но не е чрез изискваната по условие Custom Min Function): Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).OrderBy(n => n).First());

            //    Func<int[], int> minFunc = nums =>
            //    {
            //        int minNum = int.MaxValue;
            //        foreach (var num in numbers)
            //        {
            //            if (num < minNum)
            //            {
            //                minNum = num;
            //            }
            //        }
            //        return minNum;
            //    };
            //    Console.WriteLine(minFunc(numbers));
            //}

            //еквивалентно е с този метод:
            //static int GetSmallest(int[] array)
            //{
            //    int minValue = array.Min();
            //    int minValue = int.MaxValue;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] < minValue)
            //        {
            //            minValue = array[i];
            //        }
            //    }
            //    return minValue;
        }
    }
}
