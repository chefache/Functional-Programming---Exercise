using System;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split();

            Action<string[]> print = items => 
            Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", names));

            print(names);
        }
    }
}
