using System;
using System.Linq;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(", ")
                .Select(Parse);

            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());

        }
        static int Parse(string str)
        {
            int number = 0;
            foreach (var ch in str)
            {
                number *= 10;
                number += ch - '0';
            }

            return 0;
        }
    }
}
