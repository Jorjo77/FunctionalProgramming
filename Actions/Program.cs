using System;

namespace Actions
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> logger = LoggInfo ;
            logger("pesho");
            LoggInfo("ivo");
            //Дали logger("pesho") или LoggInfo("ivo") няма значение, все едно е!
            //Action може и без параметри:
            Action noParamsLogger = LogInfoNoParams;
            noParamsLogger();
        }
        static void LogInfoNoParams()
        {
            Console.WriteLine($"Say my name no params");
        }
        static void LoggInfo(string name)
        {
            Console.WriteLine($"Say my name {name}");
        }
    }
}
