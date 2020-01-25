using System;

namespace creating_Delegate
{
    class Program
    {
        delegate bool IntPredicate(int number);
        static void Main(string[] args)
        {
            IntPredicate funcPredicate = x => x % 2 == 0;
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(funcPredicate(number));

        }
    }
}
