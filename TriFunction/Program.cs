using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<string, int, bool> wordValidtor = (word, target) => word.Sum(x => x) >= target;

            int target = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split().ToArray();

            Func<string[], Func<string, int, bool>, string> wordSurcher = (names, wordValidtor) => names.FirstOrDefault(x => wordValidtor(x, target));

            string targetWord = wordSurcher(names, wordValidtor);

            Console.WriteLine(targetWord);


            //int target = int.Parse(Console.ReadLine());

            //string[] names = Console.ReadLine().Split();

            //List<string> result = new List<string>();

            //Func<string, int> nameEvaluator = name =>
            //{
            //    int nameValue = 0;
            //    for (int i = 0; i < name.Length; i++)
            //    {
            //        char curr = name[i];
            //        nameValue += curr;
            //    }
            //    return nameValue;
            //};

            //Func<int, int, bool> nameValidator = (nameValue, target) => nameValue >= target;

            //foreach (var name in names)
            //{
            //    var nameValue = nameEvaluator(name);
            //    if (nameValidator(nameValue, target))
            //    {
            //        result.Add(name);
            //    }
            //}

            //Console.WriteLine(string.Join(Environment.NewLine, result));

        }
    }
}
