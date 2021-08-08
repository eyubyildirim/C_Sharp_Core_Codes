﻿using System;

namespace Numbers
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // Unsigned integer, positive whole numbers (includes 0)
            uint naturalNumber = 23;

            // Integer, negative or positive whole numbers (includes 0)
            int integerNumber = -23;

            // Float, negative or positive single-precision floating point numbers
            // F suffix makes it a float literal
            float realNumber = -2.3F;

            // Double, negative or positive double-precision floating point numbers
            double anotherRealNumber = -2.3;

            // Three variables that store two million number
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;

            // Check if they all have the same value
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

            Console.WriteLine(
                $"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine(
                $"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
            Console.WriteLine(
                $"decimal uses {sizeof(decimal)} bytes and can store numbers in range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            }

            Console.WriteLine("Using decimals:");

            decimal c = 0.1M;
            decimal d = 0.2M;

            if (c + d == 0.3M)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            }
        }
    }
}