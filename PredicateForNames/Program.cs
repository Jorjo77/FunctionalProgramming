using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split();

            Func<string, bool> func = x => x.Length <= n;

            Action<List<string>> printer = x => Console.WriteLine(string.Join(Environment.NewLine, x));

            List<string> result = names.Where(func).ToList();

            printer(result);




            //int n = int.Parse(Console.ReadLine());
            //List<string> names = Console.ReadLine().Split().ToList();
            //names = names.Where(x => x.Length <= n).ToList();
            //Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
