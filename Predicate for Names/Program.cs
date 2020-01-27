using System;
using System.Linq;

namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());

            var names = Console.ReadLine()
                .Split();

            var resultNames = names.Where(x => x.Length <= nameLength).ToArray();
            Console.WriteLine(string.Join(" ", resultNames));
        }
    }
}
