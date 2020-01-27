using System;

namespace Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
              .Split(" ");

            Action<string[]> printToConsole = items => 
            Console.WriteLine(string.Join(Environment.NewLine, items));

            printToConsole(names);
        
        }
    }
}
