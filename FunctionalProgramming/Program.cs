using System;
using System.IO;
using System.Linq;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //във функционалното програмиране (ФП) винаги една функция дава еднакъв резултат, няма стейт (състояние), като в ООП. Променливите са константи!
            //ФП е много силно когато едновременно се случват много процеси!
            //haskel е много добър език за учене на ФП
            //lisp и scala се много известни, ако ни е интересно ФП Виктор би ни насочил към scala!
            // F# e майкросовтския, а JS много хора го пишат по функционално и много хора с JS им се отдава функционалното програмиране.  JS е много мощен за много неща!!!
            // pattern matching в C# e функционална парадигма, която набира скорост напоследък (има базово много хубави неща).
            // лампда експрешънса е съкратен запис на метод (анонимна функция) - използват се за писане набързо и когато няма да се ползват повече - много полезни за сортиране и филтриране!!!
            // анонимните функции приемат параметър и връщат резултат.

            //Lampda:

            //int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            //numbers = numbers.Where(numbers => numbers % 2 == 0).ToArray();
            // а where може и така:
            //numbers = numbers.Where(CheckEven).ToArray();

            //Важното за Linq: така можем да пишем и по сериозно твло в Linq
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            numbers = numbers.Where(x =>
            { Console.WriteLine($"X : {x} -> {x % 2 == 0}");
            return x % 2 == 0;
            }).ToArray();

            //Важното за Linq:така можем (със скобите) да подадем повече от един параметър
            //int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            //numbers = numbers.Where((x, index) =>
            //{
            //    Console.WriteLine($"X : {x} -> {x % 2 == 0}");
            //    return x % 2 == 0;
            //}).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
            //същото като лампдата, но с име и може да се вика:
            //static bool CheckEven(int number)
            //{
            //    return number % 2 == 0;
            //}

            //Делегати Delegates:
            //Това е референция към функция/поинтер към функция/променлива която държи/сочи към функция. Тази променлива/тип може да бъде извиквана като функция или да я подаваме наляво, надясно както подаваме променлива - това е ключовото нещо за делегата!!!
            //Делегата описва каква е сигнатурата на самия метод (какви параметри приема, какви данни връща)
            //Func<T,V>, T е параметъра който приема, V е параметъра който връща (може да са различни типове). Това Func е клас, който е така направен че да може да приема методи, които може да използваме.
            //Пример: Func<int, string> func = n =>n.ToString(); , това с var не работи!
            // информацията която ни трябва за да направим от дадена функция(метод) делегат е какви типове приема и връща
            //първите два инта са параметрите които приема, а последния в скобите е този който връща.

            //Func<int, int, int> sumDelegate = SumNumbers;
            //sumDelegate(5, 5);
            //Console.WriteLine(sumDelegate(5,5));
            //SumNumbers(5,5); e абсолютно същото!
            //sumDelegate = MultiplyNumbers;
            //може заради същата сигнатура (два инта са параметрите които приема, а един връща)
            //Console.WriteLine(sumDelegate(5, 5));
            //така един и същи код връща различни резултати!

            //Action -> returns void !; Func -> returns something!
            //т.e. всички методи(функции), които връщат void (т.е. не връщат стойност) са Action !!! Демо в проект Actions!
            //цялата концепция е че вече нашите променливи могат да сочат към функции и да ги използваме като ги подаваме насам, натам, да ги извикваме когато поискаме.
            //Реално правим тип данни за метод и можем в другите методи да казваме тук искам метод от даден тип.
            //Това Е МНОГО МОЩНО, постепенно ще осъзнаем това и какви мощни абстракции ще можем да правим с това, но след няколко месеца ще го оценим наистина.

            //Predicate всъшност е анонимна функция, която връща bool
            //Работи с Overload
            //Когато имаме по-сложна анонимна функция, можем да си я сложим на делегат и удобно да си я подаваме насам, натам.
            //Пример:             Func<string, bool> upperChecker = s => s[0] == s.ToUpper()[0];
            //var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Where(upperChecker)
            //    .ToArray();
            //FP ни го препоръчва за по натам да задълбаем, сега важното е ООП - то да разберем добре - доста по-използвано е!
            //Като завършим SoftUni - Learn You a Haskell - това е момента и перфектната книга за ФП!!!
            //Има функционален форич - ForEach, 
            //Пример: Array.ForEach(new int[]{1, 2, 3, 4 }, p=>Console.ReadLine(p.Name));
            //Func ползваме когато искаме да напишем по абстрактен код. И без това можем да програмираме, това си иска време за да го разбервм!
            Func<int, int, int> sumDelegate = SumNumbers;
            sumDelegate(5, 5);
            Func<int, int, int> multiplyDelegate = MultiplyNumbers;
            Calculate(5, 5, sumDelegate);
            Calculate(5, 5, multiplyDelegate);
            Calculate(5, 5, (a, b) => a / b);
            Calculate(5, 5, (a, b) => a * 100 * b * 100);
        }
        static int SumNumbers(int a, int b)
        {
            Console.WriteLine("Summing numbers is the best feeling");
            return a + b;
        }
        static int MultiplyNumbers(int a, int b)
        {
            Console.WriteLine("Multiply numbers is the worse feeling");
            return a * b;
        }
        //ключово тук е че кода дето пише не се занимава със самите операции!
        static void Calculate(int a, int b,Func<int, int, int> operation)
        {
            //с ,true му казваме да апендва
            using (StreamWriter writer = new StreamWriter("../../../result.txt)",true))
            {
                writer.WriteLine("Start calculating");
                writer.WriteLine(operation(a, b));
            }
        }
    }
}
