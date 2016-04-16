using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YieldTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbl = 1.To(10).Multiply(2);

            foreach (var i in dbl)
                Console.WriteLine(i);

            Console.ReadLine();
        }
    }

    static class yieldTest
    {
        public static IEnumerable<int> Multiply(this IEnumerable<int> value, int multiplier)
        {
            foreach (int v in value)
                yield return v * multiplier;
        }

        public static IEnumerable<int> To(this int value, int inclusiveMax)
        {
            for (int i = value; i <= inclusiveMax; i++)
                yield return i;
        }
    }
}
