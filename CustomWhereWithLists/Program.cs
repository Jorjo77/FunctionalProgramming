using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomWhereWithLists
{
    static class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            string x = "ljkdsj";
            var input = new[] { 100, 200, 300 };
            var result = MyWhere(input, x => x % 2 == 0);
                Console.WriteLine(string.Join(", ", result));


            var result2 = input.Where(x => x % 2 == 0);
            Console.WriteLine(string.Join(", ", result2));

            //var result2 = input.Where((x, i) => i % 2 == 0);*///можем и така с два параметъра и по този начин освен да е четно (х -а) искаме и да е на четен индекс(i - то)
           //Console.WriteLine(string.Join(", ", result2));
        }

        static List<Т> MyWhere<Т>(this IEnumerable<Т> input, Func<Т, bool> filter)//така написан моя метод ще работи със всички типове (защото е дженерик)
        {
            var newList = new List<Т>();
            foreach (var number in input)
            {
                if (filter(number))
                {
                    newList.Add(number);
                }
            }
            return newList;
        }
        //static List<int> MyWhere(IEnumerable<int> input, Func<int, bool> filter)//така написан моя метод ще работи само с int
        //{
        //    var newList = new List<int>();
        //    foreach (var number in input)
        //    {
        //        if (filter(number))
        //        {
        //            newList.Add(number);
        //        }
        //    }
        //    return newList;
        //}

    }
}
