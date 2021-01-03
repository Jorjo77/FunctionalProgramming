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
            //Console.WriteLine(string.Join(", ", numbers));

            //var numbers = Enumerable.Range(1, 100)
            //.GroupBy(x => x % 10)//много основна в работата с бази данни и колекции(прави малки колекции(групички по зададен критерий "key"))
            //.Select(g => g.Key());//по зададения критерий в GroupBy, по "key"!
            //Console.WriteLine(string.Join(", ", numbers));

            //var numbers = Enumerable.Range(1, 100)
            //    .GroupBy(x => x.ToString().Length)
            //    .Select(g => g.Sum());//За всяка група ми дай сумата (обикновенно след GroupBy в Select пишем агрегиращи функции(функции които взимат числата и правят нещо във тях - kато(.Sum, .Count, .Min, .Max, Average)
            //Console.WriteLine(string.Join(", ", numbers));

            //При групинга Dictionary е много полезно:
            //var numbers = Enumerable.Range(1, 100)
            //.GroupBy(x => x.ToString().Length)
            //.ToDictionary(g => g.Key, g => g.ToList());

            //foreach (var keyValue in numbers)
            //{
            //    Console.WriteLine($"{keyValue.Key} => {string.Join(", ", keyValue.Value)}");//така ще изпишем ключа и след всеки ключ стойностите - Value -то!
            //}

            //var numbers = Enumerable.Range(1, 100)
            //    .Aggregate((a, b) => a + b);//прилича на .Sum, но връща само цяло число и може да се ползва и с умножение
            //Console.WriteLine(string.Join(", ", numbers));

            //var numbers = Enumerable.Range(1, 100)
            //.Any(x => x==5);//питаме има ли поне едно число равно на 5
            //Console.WriteLine(string.Join(", ", numbers));

            //.FirstOrDefault - дава първият елемент който отговаря на условието което пишем вътре или връща дефолтната ст-ст на типа!

            //.ForEach ot Linq по добре да не ползваме, а стандартния.

            //.SelectMany - прилага нещо на елементите на клекция от колекции.(при масив от масиви може да ни свърши работа)

            var numbers = Enumerable.Range(1, 100)
            .All(x => x == 5);//питаме всички ли отговарат на условието!?
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
