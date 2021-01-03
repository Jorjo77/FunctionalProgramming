using System;
using System.Collections.Generic;
using System.Linq;
namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int> addFunc = x => x + 1;

            Func<int, int> subtractFunc = x => x - 1;

            Func<int, int> multiplyFunc = x => x * 2;

            Action<List<int>> printer = x => Console.WriteLine(string.Join(" ", x));

            List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            while (command!="end")
            {
                switch (command)
                {
                    case "add":
                        nums = nums.Select(addFunc).ToList();
                        break;

                    case "multiply":
                        nums = nums.Select(multiplyFunc).ToList();
                        break;

                    case "subtract":
                        nums = nums.Select(subtractFunc).ToList();
                        break;

                    case "print":
                        printer(nums);
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();
            }
                        
            
            //Func<int, int> addFunc = x => x + 1;
            ////ако ползваме тази лампда само веднъж не е нужно да я изнасяме така във Func,
            ////няма смисъл, смисъла е ако ще я ползваме повече пъти!(сега с учебна цел го правим!!!)
            ////сега когато се учим var не ни трябва, той е като се научим!!!
            //Func<int, int> multiplyFunc = x => x * 1;
            //Func<int, int> subtractFunc = x => x - 1;
            //Action<List<int>> printFunc = x => Console.WriteLine(string.Join(" ", x));
            //List<int> numbers = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToList();
            //string command = Console.ReadLine();
            //while (command != "end")
            //{
            //    switch (command)
            //    {
            //        case "add":
            //            //numbers.Select(x => addFunc(x)).ToList();
            //            //numbers.Select(addFunc).ToList();
            //            numbers = numbers.Select(x => x + 1).ToList();
            //            break;
            //        case "multiply":
            //            //numbers.Select(x => multiplyFunc(x)).ToList();
            //            //numbers.Select(multiplyFunc).ToList();
            //            numbers = numbers.Select(x => x * 1).ToList();
            //            break;
            //        case "subtract":
            //            //numbers.Select(x => subtractFunc(x)).ToList();
            //            //numbers.Select(subtractFunc).ToList();
            //            numbers = numbers.Select(x => x - 1).ToList();
            //            break;
            //        case "print":
            //            printFunc(numbers);
            //            break;

            //        default:
            //            break;
            //    }

            //    command = Console.ReadLine();
            //}

        }
    }
}


  
