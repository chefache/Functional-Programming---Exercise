using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrParams = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int startNum = arrParams[0];
            int endNum = arrParams[1];

            var workList = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                workList.Add(i);
            }

            Predicate<int> isEvenPredicate = num => num % 2 == 0;

            string command = Console.ReadLine();

            if (command == "odd")
            {
                workList.RemoveAll(x => isEvenPredicate(x));
            }
            else if (command == "even")
            {
                workList.RemoveAll(x => !isEvenPredicate(x));
            }

            Action<int[]> printNumbers = nums => 
            Console.WriteLine(string.Join(" ", nums));

            printNumbers(workList.ToArray());
        }
    }
}
