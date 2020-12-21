using System;

namespace Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            var calclatorFP = new CalculatorFP();

            calclatorFP.Print(calclatorFP.Sum(5, 6));
            var calculator = new CalculatorOOP();
            calculator.A = 5;
            calculator.B = 6;
            Console.WriteLine(calculator.Sum());
            PrintSomeData(calculator);
        }

        static void PrintSomeData(CalculatorOOP calculator)
        {
            //2000 реда код
            calculator.Result = 43;
            calculator.B = 55;
            calculator.Sum();
            Console.WriteLine(calculator.Result);

        }
    }
}
