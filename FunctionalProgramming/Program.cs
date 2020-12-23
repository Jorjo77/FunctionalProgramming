using System;
using System.IO;
using System.Linq;

namespace FunctionalProgramming
{
    class Program
    {
        delegate void DoSomethingWithThisString();
        delegate bool IntPredicate(int number);// дадох име на всички методи, които приемат int и връщат bool)
        static void Main(string[] args)
        {
            Action action = () => Console.WriteLine("Hello!");
            //DoSomethingWithThisString action = () => Console.WriteLine("Hello!"); Така можем да използваме този екшън (с името на делегата, който сме декларирали горе)
            Func<int, bool> funcPredicate = x => x % 2 == 0;
            IntPredicate intPredicateVariable = x => true;//горе декларирам (делегатите са към класа (декларираме ги в класа Program например, но може и извън него в namespace -а и така ще са видими и за другите класове), не може да ги сложим в метод, дори и в Main -а !!!) и тук вече мога да го изполозвам (Какво постигнах - дадох име на всички методи, които приемат int и връщат bool, като например на funcPredicate името на типа да не е общото Func а IntPredicate)
            
            //По принцип не създаваме делегати (ползваме готови) освен в случаите когато ползваме events (събития)!!!

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

            //LinqUsefulMethods - да си видя демото !!!
            //Важното за Linq: така можем да пишем и по сериозно твло в Linq
            //int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            //numbers = numbers.Where(x =>
            //{ Console.WriteLine($"X : {x} -> {x % 2 == 0}");
            //return x % 2 == 0;
            //}).ToArray();

            ////Важното за Linq:така можем (със скобите) да подадем повече от един параметър
            ////int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            ////numbers = numbers.Where((x, index) =>
            ////{
            ////    Console.WriteLine($"X : {x} -> {x % 2 == 0}");
            ////    return x % 2 == 0;
            ////}).ToArray();

            //Console.WriteLine(string.Join(" ", numbers));
            //същото като лампдата, но с име и може да се вика:
            //static bool CheckEven(int number)
            //{
            //    return number % 2 == 0;
            //}

            //Делегати Delegates:
            //Делегата е тип данни който описва метод (може да се нарече шаблон за метод)!
            //Това е референция към функция/поинтер към функция/променлива която държи/сочи към функция. Тази променлива/тип може да бъде извиквана като функция или да я подаваме наляво, надясно както подаваме променлива - това е ключовото нещо за делегата!!!
            //Делегата описва каква е сигнатурата на самия метод (какви параметри приема, какви данни връща)
            //Func<T,V>, T е параметъра който приема, V е параметъра който връща (може да са различни типове, а при повече параметри return type-a e винаги последния). Това Func е клас, който е така направен че да може да приема методи, които може да използваме.
            //Пример: Func<int, string> func = n => n.ToString(); , това с var не работи!
            // информацията която ни трябва за да направим от дадена функция(метод) делегат е какви типове приема и връща
            //първите два инта са параметрите които приема, а последния в скобите е този който връща.
            //Делегатите се декларират извън методи с ключовата думичка delegate и описват метода (една декларация на метод без тяло) като какво приема, какво връща и какво му е името!

            //Пример: 
            //public delegate int Multiplier (int x, int y)
            //Multiplier calc = (x, y) => x * y;
            //, това е същото като Func<int, int, int> но типа си има име (Multiplier) a не е общото Func.


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
            //цялата концепция е че вече нашите променливи могат да сочат към методи (функции) и да ги използваме като ги подаваме насам, натам, да ги извикваме когато поискаме.
            //Реално правим тип данни за метод и можем в другите методи да казваме тук искам метод от даден тип.
            //Това Е МНОГО МОЩНО, постепенно ще осъзнаем това и какви мощни абстракции ще можем да правим с това, но след няколко месеца ще го оценим наистина.

            //Predicate всъшност е анонимна функция. Може да се каже че е частен случай на Func защото приема нещо (променлива) и връща bool
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

            //Препоръча ни LINQ който е време да започнем да използваме!!!:
            // * First/ FirstOrDefault - връща първия елемент от зададено условие и ако не го намери гърми/връща дефолтната стойност на типа. 
            // * Last/ LastOrDefault - - връща последния елемент от зададено условие и ако не го намери гърми/връща дефолтната стойност на типа. 
            // * Single/ SingleOrDefault - - връща един елемент от зададено условие и ако има (намери) повече от един гърми/връща дефолтната стойност на типа. 
            // * Skip (и производните) - казваме му колко елемента да прескача!
            // * Find, Where, Select, Any, All, Average, Max, Min, Sum, OrderBy/Desending да си ги разгледам внимателно.

            //    //В JS Select e Map!
            //    Func<int, int, int> sumDelegate = SumNumbers;//Този тип данни Func ни дава възможността при добре написан код много лесно да променим функционалността(работата) на програмата (например сменям SumNumbers с SumNumbers).
            //    sumDelegate(5, 5);
            //    Func<int, int, int> multiplyDelegate = SumNumbers;
            //    Calculate(5, 5, sumDelegate);
            //    Calculate(5, 5, multiplyDelegate);
            //    Calculate(5, 5, (a, b) => a / b);
            //    Calculate(5, 5, (a, b) => a *100 * b *100);
            //}
            //static int SumNumbers(int a, int b)
            //{
            //    Console.WriteLine("Summing numbers is the best feeling");
            //    return a + b;
            //}
            //static int MultiplyNumbers(int a, int b)
            //{
            //    Console.WriteLine("Multiply numbers is the worse feeling");
            //    return a * b;
            //}
            ////ключово тук е че кода дето пише не се занимава със самите операции!
            //static void Calculate(int a, int b,Func<int, int, int> operation)
            //{
            //    //с ,true му казваме да апендва
            //    using (StreamWriter writer = new StreamWriter("../../../result.txt)",true))
            //    {
            //        writer.WriteLine("Start calculating");
            //        writer.WriteLine(operation(a, b));
            //    }
            //}

            //Друг добър пример:

            //Func<int, long> operation = Square;//Този тип данни Func ни дава възможността при добре написан код много лесно да променим функционалността(работата) на програмата (например сменям Factorial със Square).
            //Console.WriteLine(operation(5));
            //PrintResult(5, Square);
            //PrintResult(5, Factorial);

            //Action<int> action = PrintToConsoleWithLines;//и тук мога следващия момент да кажа PrintToConsole и от едно място да променя функционалността на кода надолу!

            // оператора += работи и върху Action и Func (не само с числа), можем да добавим метод със същата сигнатура! Например:
            //action += PrintToConsole;
            //action += PrintToConsole;
            //action += PrintToConsole;
            //action(3);//Taka можем да извикаме тези две функции една след дуга (PrintToConsoleWithLines и PrintToConsole (през action)). Така можем да си направим списък от методи които да бъдат извикани колкото пъти поискаме.
            /* action -= PrintToConsole;*/// а така мога да премахна функция когато поискам, с -=.
                                          //Това += и -= не се ползва в стандартните програми, но евенти, които ще ползваме по-нататък се ползва (нарича се закачане и откачане на събитие и е част от парадигмата event hendling, която имаме в C#)
                                          //action(100);
                                          //action.GetInvocationList().Length();//така можем да вземем броя на закачените елементи.
        }

        //static void PrintToConsoleWithLines(int x)
        //{
        //    Console.WriteLine("=========================");
        //    Console.WriteLine($"   PrintToConsoleWithLines: {x}");
        //    Console.WriteLine("=========================");
        //}
        //static void PrintToConsole(int x)
        //{
        //    Console.WriteLine($"   PrintToConsole: {x}");
        //}
        //static void PrintResult(int x, Func<int, long> func)//подавайки тук функция(приемаща int и връщаща long), правим метода преизползваем (лесно от тук можем да променим поведението наадолу на програмата със смяна на функцията). Taка горе веднъж викаме PrintResult със Square, втори път с Factorial (и двете приемат int и връщат long) и кода става преизползваем (вдигаме нивото на абстракция). Така PrintResult ще има различно поведение взависимост от функцията която сме подали (PrintResult е функция от по висок ред)
        //{
        //    var result = func(x);//така взависимост от това с какво викаме PrintResult(стига да приема int и връщаща long) тук веднъж ще е Square, втоти път Factorial)
        //    Console.WriteLine("=========================");
        //    Console.WriteLine($"   Result: {result}");
        //    Console.WriteLine("=========================");
        //}
        //static long Square(int num)
        //{
        //    return num * num;
        //}
        //static long Factorial(int num)
        //{
        //    long result = 1;
        //    for (int i = 2; i <= num; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}

        //CustomWhereWithLists - виж демото: 

        //Lampda expresions (анонимна/инлайн функция) виж LampdaЕxpresionsDemo
        //Func<int, bool> predicat - всяка функция, която връща bool наричаме predicat !!!

        //var използваме САМО когато типа е очевиден и само тогава е в помощ и удобство за програмиста !!!

        //?. означава ако не е null направи еди какво си с това
        //?? означават ако лявото е  null използвай дясното, ако не е използвай лявото!
        // базовия резултат от Linq винаги е IEnumerable и е нещо което мога да форийчна. Ако ще печатаме само после със string.Join например не ни трябва да слагаме ToList() или ToArray() накрая (те биха ни трябвали за да си имаме индексатор ако ни трябва!).  т.е. мощната абстракция IEnumerable ни дава възможност да използваме колекцията нататак според нуждите ни!
        //Самият език C# е много мощен, а Linq допринася много за тази мощ!!!

        //Unity е уникален енджин на който се пише само на  C#  и съсн него и знанията ни до момента можем да правим игри!
    }
}
