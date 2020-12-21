using System;
using System.Linq;
namespace LampdaЕxpresionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(IsEvenNumber(5));
            //Console.WriteLine(IsEvenNumber(10));

            //Func<int, bool> predicate = IsEvenNumber;
            //Func<int, bool> predicate = /*(int a)*/ a => a % 2 == 0; това е запис на същия този IsEvenNumber метод, но без име, това е анонимна функция(съкратения запис)! От Linq сме свикнали параметъра да е x, t.e. x=>x;

            //Func<int, bool> predicate = /*(int a)*/ a =>
            //{
            //    return a % 2 == 0;
            //};
            //това е запис на същата тази анонимна функция, но с тяло (дългия запис)!

            Func<int, bool> predicate = a => a % 2 == 0;

            var result = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.Where(a => a % 2 == 0/*predicate*/);//тук подаваме лампда израза(не е нужно името)
            Console.WriteLine(string.Join(", ", result));

        }

        //static bool IsEvenNumber(int a)
        //{
        //    return a % 2 == 0;
        //}
        //static bool IsEvenNumber(int a)
        //=> a % 2 == 0;//Този запис е еквивалентен на горния !!!

    }
}
