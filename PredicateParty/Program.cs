using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int, bool> lengthFunc = (name, length) => name.Length == length;
            Func<string, string, bool> startsWithFunc = (name, substing) => name.StartsWith(substing);
            Func<string, string, bool> endsWithFunc = (name, substing) => name.EndsWith(substing);

            string command = Console.ReadLine();
            while (command != "Party!")
            {
                string[] splitedCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string action = splitedCommand[0];
                string condition = splitedCommand[1];

                if (action == "Double")
                {
                    if (condition == "Length")
                    {
                        int length = int.Parse(splitedCommand[2]);
                        var tempNames = names.Where(name => lengthFunc(name, length)).ToList(); ;

                        MyAddRange(names, tempNames);
                    }

                    else if (condition == "StartsWith")
                    {
                        string substring = splitedCommand[2];
                        var tempNames = names.Where(name => startsWithFunc(name, substring)).ToList(); ;

                        MyAddRange(names, tempNames);
                    }

                    else if (condition == "EndsWith")
                    {
                        string substring = splitedCommand[2];
                        var tempNames = names.Where(name => endsWithFunc(name, substring)).ToList(); ;

                        MyAddRange(names, tempNames);
                    }
                }
                else if (action == "Remove")
                {
                    if (condition == "Length")
                    {
                        int length = int.Parse(splitedCommand[2]);
                        names = names.Where(name => !lengthFunc(name, length)).ToList();
                    }

                    else if (condition == "StartsWith")
                    {
                        string substring = splitedCommand[2];
                        names = names.Where(name => !startsWithFunc(name, substring)).ToList();
                    }

                    else if (condition == "EndsWith")
                    {
                        string substring = splitedCommand[2];
                        names = names.Where(name => !endsWithFunc(name, substring)).ToList();
                    }
                }
 
                command = Console.ReadLine();
            }
            if (names.Count>0)
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void MyAddRange(List<string> names, List<string> tempNames)
        {
            foreach (var currName in tempNames)
            {
                int index = names.IndexOf(currName);
                names.Insert(index, currName);
            }
        }
    }
}
