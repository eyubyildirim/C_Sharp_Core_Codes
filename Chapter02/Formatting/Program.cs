using System;
using static System.Console;

namespace Formatting
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            const int numberOfApples = 12;
            const decimal pricePerApple = 0.35M;

            WriteLine(
                format: "{0} apples cost {1:C}",
                arg0: numberOfApples,
                arg1: numberOfApples * pricePerApple);

            // string formatted = string.Format(
            //     format: "{0} apples cost {1:C}",
            //     arg0: numberOfApples,
            //     arg1: numberOfApples * pricePerApple);

            WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;

            WriteLine(
                format: "{0, -16} {1,6:N0}",
                arg0: "Name",
                arg1: "Count");

            WriteLine(
                format: "{0, -16} {1,6:N0}",
                arg0: applesText,
                arg1: applesCount);

            WriteLine(
                format: "{0, -16} {1,6:N0}",
                arg0: bananasText,
                arg1: bananasCount);

            Write("Type your first name and press enter: ");
            string firstName = Console.ReadLine();

            Write("Type your age and press enter: ");
            string age = Console.ReadLine();

            WriteLine($"Hello {firstName}, you look good for age {age}!");

            Write("Press any key combination: ");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();
            WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
                arg0: key.Key,
                arg1: key.KeyChar,
                arg2: key.Modifiers);
        }
    }
}