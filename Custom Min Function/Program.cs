using System;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> printSmallest = inputNums =>
            {
                int minNum = int.MaxValue;

                foreach (var currentNum in inputNums)
                {
                    if (currentNum < minNum)
                    {
                        minNum = currentNum;
                    }
                }
                return minNum;
            };

            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int result = printSmallest(nums);
            Console.WriteLine(result);
        }
    }
}
