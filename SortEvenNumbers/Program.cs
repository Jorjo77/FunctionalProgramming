using System;
using System.Linq;

namespace SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //един по различен запис на селекта в смисъла на функционалното програмиране
            int[] numbers = Console.ReadLine()
                .Split(", ").Select((number) =>
                {
                    return int.Parse(number);
                })
                //това горе е същиото като това простото: .Select(x=> int.Parse(x))
                .Where(x => x % 2 == 0)
                //малко по различен запис на лампда израз:
                .OrderBy((int x) =>
                {
                    return x;
                })
                //това горе е същиото като това простото: OrderBy(x=>x)
                .ToArray();
            Console.WriteLine(string.Join(", ", numbers));



        }
    }
}
