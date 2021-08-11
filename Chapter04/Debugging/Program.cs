using System;
using static System.Console;

namespace Debugging
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var a = 4.5;
            var b = 2.5;
            var answer = Add(a, b);
            WriteLine($"{a} + {b} = {answer}");
            ReadLine();
        }

        private static double Add(double a, double b)
        {
            return a + b;
        }
    }
}
