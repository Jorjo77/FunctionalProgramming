using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //така най-лесно проверяваме дали първата буква е голяма:s=>s[0]==s.ToUpper()[0]
            Func<string, bool> upperChecker = s => s[0] == s.ToUpper()[0];
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(upperChecker)
                .ToArray();
            Console.WriteLine(string.Join("\n", input));
        }
    }
}
