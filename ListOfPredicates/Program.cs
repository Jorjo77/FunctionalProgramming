using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> result = new List<int>();

            for (int i = 1; i <= endOfRange; i++)
            {
                int currNum = i;
                //Func<int, int, bool> validator = x => x % currDevider == 0;

                for (int j = 0; j < dividers.Length; j++)
                {
                    int currDevider = dividers[j];

                    if (currNum % currDevider == 0 )
                    {
                        result.Add(currNum);
                    }

                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
