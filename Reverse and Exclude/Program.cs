using System;
using System.Linq;

namespace Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> print = x => Console.WriteLine(string.Join(" ", x)); 
            var array = Console.ReadLine()
                 .Split()
                 .Select(int.Parse);

            int number = int.Parse(Console.ReadLine());

            Predicate<int> filter = x => x % number != 0;
            Func<int, bool> filterFunc = x => filter(x);

            array = array
                .Where(filterFunc);

            print(array.Reverse().ToArray());
        }
    }
}
