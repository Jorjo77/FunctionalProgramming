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

            //MyJob
            //var text = Console.ReadLine();
            //var words = text.Split();
            //Func<string, bool> predicate = word => char.IsUpper(word[0]);
            //var result = words.Where(predicate).OrderBy(w => w);
            //Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
