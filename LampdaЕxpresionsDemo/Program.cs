using System;

namespace LampdaЕxpresionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsEvenNumber(5));
            Console.WriteLine(IsEvenNumber(10));

            //Func<int, bool> predicate = IsEvenNumber;
            //Func<int, bool> predicate = (int a) => a % 2 == 0; това е запис на същия този IsEvenNumber метод, но без име, това е анонимна функция (съкратения запис)! 
            //Func<int, bool> predicate = (int a) => 
            //{ 
            //return a % 2 == 0;
            //}; 
            //това е запис на същата тази анонимна функция, но с тяло (дългия запис)!


            while (true)
            {

            }
        }

        //static bool IsEvenNumber(int a)
        //{
        //    return a % 2 == 0;
        //}
        static bool IsEvenNumber(int a)
        => a % 2 == 0;//Този запис е еквивалентен на горния !!!

    }
}
