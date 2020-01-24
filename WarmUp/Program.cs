using System;
using System.Linq;

namespace WarmUp
{
    class Program
    {
        static void Main(string[] args)
        {
          //  var myNum = int.Parse(Console.ReadLine());
            string x = "asdasdasd";

            //  Func<int, long> operation = numBy75; // тук мога да сменям numBy75 или Power функциите

            //  Console.WriteLine(operation(myNum));

            //  Printresult(myNum, Power);
            //  Printresult(myNum, numBy75);

            Action<int> action = PrintToConsoleWithLine;
            action += PrintToConsole;
            action += PrintToConsole;
            action += PrintToConsole;
            action += PrintToConsole;
            action += PrintToConsole;
            action(3);
            action(100);

            var nums = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNums = nums.Where(x => x % 2 == 0); //приема int и връща bool !!!
            Console.WriteLine(string.Join(", ", evenNums));

        }
        static long Power(int num)
        {
            return num * num;
        }
        static long numBy75(int num)
        {
            return num * 75;
        }
        static void Printresult(int x, Func<int, long> func)
        {
            var result = func(x);
            Console.WriteLine("=======================");
            Console.WriteLine($"***Result: {result}***");
            Console.WriteLine("=======================");
        }

        static void PrintToConsoleWithLine(int x)
        {
            Console.WriteLine("=======================");
            Console.WriteLine($"***Result: {x}***");
            Console.WriteLine("=======================");
        }
        static void PrintToConsole(int x)
        {
            Console.WriteLine($"***Result: {x}***");
        }
    }
}
