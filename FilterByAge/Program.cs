using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace FilterByAge
{
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ////MyJob

            List<Person> people = new List<Person>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(", ");
                Person person = new Person(input[0], int.Parse(input[1]));
                people.Add(person);
            }
            string condition = Console.ReadLine();
            int filteredAge = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> predicate = p => true; ;

            if (condition == "older")
            {
                predicate = p => p.Age >= filteredAge;
            }
            else if (condition == "younger")
            {
                predicate = p => p.Age < filteredAge;
            }

            var result = people.Where(predicate);

            foreach (var person in result)
            {
                //var output = format
                //.Replace("age", person.Age.ToString())
                //.Replace("name", person.Name);
                //Console.WriteLine(output);С този формат.Replace много хитро заменяме кода отдолу!!!
                if (format=="name age")
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
                else if (format=="name")
                {
                    Console.WriteLine(person.Name);
                }
                else if (format == "age")
                {
                    Console.WriteLine(person.Age);
                }
            }

            //    int n = int.Parse(Console.ReadLine());
            //    Person[] people = new Person[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        var input = Console.ReadLine().Split(", ");

            //        people[i] = new Person()
            //        {
            //            Name = input[0],
            //            Age = int.Parse(input[1])
            //        };
            //    }

            //    string condition = Console.ReadLine();
            //    int ageToFilter = int.Parse(Console.ReadLine());
            //    string format = Console.ReadLine();

            //    Func<Person, bool> conditionDelegate = GetCondition(condition, ageToFilter);
            //    Action<Person> printerDelegate = GetPrinter(format);

            //    foreach (var person in people)
            //    {
            //        if (conditionDelegate(person))
            //        {
            //            printerDelegate(person);
            //        }
            //    }
            //}

            //static Action<Person> GetPrinter(string format)

            //{
            //    switch (format)
            //    {
            //        case "name":
            //            return p =>
            //            {
            //                Console.WriteLine($"{p.Name}");
            //            };
            //        case "age":
            //            return p =>
            //            {
            //                Console.WriteLine($"{p.Age}");
            //            };
            //        case "name age":
            //            return p =>
            //            {
            //                Console.WriteLine($"{p.Name} - {p.Age}");
            //            };

            //        default:
            //            return null;
            //    }
            //}
            //static Func<Person, bool> GetCondition(string condition, int age)
            //{
            //    switch (condition)
            //    {
            //        case "younger": return p => p.Age < age;
            //        case "older": return p => p.Age >= age;
            //        default:
            //            return null;
            //    }
            //}
        }
    }
}



