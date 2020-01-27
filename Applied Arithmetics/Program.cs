using System;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
             Func<int, int> addFunc = num => num += 1;
            Func<int, int> multiplyFunc = num => num *= 2;
            Func<int, int> subtractFunc = num => num -= 1;

            Action<int[]> printFunc = x => Console.WriteLine(string.Join(" ", x));

            while (command != "end")
            {
                if (command == "add")
                {
                    inputNumbers = inputNumbers.Select(addFunc).ToArray();
                }
                else if (command == "multiply")
                {
                    inputNumbers = inputNumbers.Select(multiplyFunc).ToArray();
                }
                else if (command == "subtract")
                {
                    inputNumbers = inputNumbers.Select(subtractFunc).ToArray();
                }
                else if (command == "print")
                {
                    printFunc(inputNumbers);
                }

                command = Console.ReadLine();
            }
        }
    }
}
