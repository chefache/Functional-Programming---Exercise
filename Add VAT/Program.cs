using System;
using System.Linq;

namespace Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine()
                 .Split(", ")
                 .Select(double.Parse);

            var VatPrice = prices.Select(x => x * 1.2);
            foreach (var price in VatPrice)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
