﻿using System;
using static System.Console;

namespace CheckingForOverflow
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            checked
            {
                try
                {
                    int x = int.MaxValue - 1;
                    WriteLine($"Initial value: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                }
                catch (OverflowException)
                {
                    WriteLine("The code overflowed but I caught the exception!");
                }
            }

            unchecked
            {
                int y = int.MaxValue + 1;
                WriteLine($"Initial value: {y}");
                y--;
                WriteLine($"After incrementing: {y}");
                y--;
                WriteLine($"After incrementing: {y}");
            }
        }
    }
}