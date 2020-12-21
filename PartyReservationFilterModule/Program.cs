using System;
using System.Collections.Generic;
using System.Linq;

namespace PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split().ToList();
            List<string> filters = new List<string>();
            while (true)
            {
                string inputCommand = Console.ReadLine();
                string[] splitedCommand = inputCommand.Split(";");
                string commandName = splitedCommand[0];
                string filterType = splitedCommand[1];
                string argument = splitedCommand[2];
                if (inputCommand=="Print")
                {
                    break;
                }
                if (commandName == "Add filter")
                {
                    filters.Add($"{filterType};{argument}");
                }
                else if (commandName == "Remove filter")
                {
                    filters.Remove($"{filterType};{argument}");
                }
            }

            foreach (var filterLine in filters)
            {
                string[] tokens = filterLine.Split(";");
                string filterType = tokens[0];
                string argument = tokens[1];

                switch (filterType)
                {
                    case "Starts with":
                        people = people.Where(p => !p.StartsWith(argument)).ToList();
                        break;
                    case "Ends with":
                        people = people.Where(p => !p.EndsWith(argument)).ToList();
                        break;
                    case "Length":
                        people = people.Where(p => p.Length != (int.Parse(argument))).ToList();
                        break;
                    case "Contains":
                        people = people.Where(p => !p.Contains(argument)).ToList();
                        break;
                    default:
                        break;
                }
            }
            Console.Write(string.Join(" ", people));

        }
    }
}
