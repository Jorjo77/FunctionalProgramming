using System;
using System.Linq;

namespace LinqUsefulMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable.Range(1, 10);//Дава ни бързо и удобно колекция в рейнджа (като втория параметър е count, т.е. броя на елементите), която можем да форийчнем или string.Join

            //var numbers = Enumerable.Range(1, 100)
            //    .Where(x => x % 6 == 0)
            //    .OrderBy(x => x % 10)//подредени по големина на последна цифра
            //    .Select(x => x / 6);

            var numbers = Enumerable.Range(1, 100)
                .GroupBy(x => x.ToString().Length)
                .Select(g => g.Sum());//обикновенно след GroupBy в Select пишем агрегиращи функции ()
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
