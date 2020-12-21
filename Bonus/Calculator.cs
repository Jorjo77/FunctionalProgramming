using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus
{
    public class CalculatorOOP
    {
        public int A  { get; set; }
        public int B { get; set; }

        public int Result { get; set; }
        public int Sum ()
        {
            Result = A + B; //Side effect, т.е. тя прави нещо, но влияе на външния свят и това може да създаде проблеми за друг код, за други функции и тези бъгове се хващат много трудно - това е най-голямия проблем на ООП и хората които пишат такова ООП (от старата школа)!
            return A + B;
        }
        public int Sum(int a)
        {
            return a + B;
        }
        public void PrintCalculator()
        {
            Console.WriteLine(Result);
        }

    }
}
