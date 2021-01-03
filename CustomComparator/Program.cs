using System;
using System.Linq;

namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

            //това отдолу може и с тернарен оператор ":" (кратко(решение на 3 реда), но поне за мен по-неясно)
            //Array.Sort(numbers, (x, y) =>  = (x % 2 == 0 && y % 2 != 0) ? -1 :
            //(x % 2 != 0 && y % 2 == 0) ? 1 : 
            // x.CompareTo(y);

            Array.Sort(numbers, (x, y) => /*x.CompareTo(y));*/
            //взависимост от инт който връща комперасъна, .Sort ги подрежда!
            {
                //така работи CompareTo
                //int compare = 0;
                //if (x<y)
                //{
                //    compare = -1;
                //}
                //else if(x>y)
                //{
                //    compare = 1;
                //}
                //return compare;

                int sorter = 0;

                if (x % 2 == 0 && y % 2 != 0)
                {
                    sorter = -1;
                }
                else if(x % 2 != 0 && y % 2 == 0)
                {
                    sorter = 1;
                }
                else
                {
                    /* return x - y;*/ //защото искаме да ги сортираме по възходящ ред, затова вадим от първото второто. това е еквивалентно на:
                    sorter = x.CompareTo(y);
                }
                return sorter;
            });
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
