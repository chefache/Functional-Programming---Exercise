using System;
using System.Collections.Generic;
using System.Linq;

namespace My_Own_Where
{
    class Program
    {
        static void Main(string[] args)
        {
            var testArrray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = MyWhere(testArrray, x => x % 2 == 0);
            Console.WriteLine(string.Join(", ", result));
        }
        static List<T>MyWhere<T>(IEnumerable<T>input, Func<T, bool> filter )
        {
            var newList = new List<T>();
            foreach (var number in input)
            {
                if (filter(number))
                {
                    newList.Add(number);
                }
            }
            return newList;
        }
    }
}
