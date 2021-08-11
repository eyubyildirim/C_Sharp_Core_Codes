using System;
using static System.Console;

namespace WritingFunctions
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // RunTimesTable();
            // RunCalculateTax();
            // RunCardinalToOrdinal();
            RunFactorial();
        }

        private static void RunFactorial()
        {
            bool isNumber;
            do
            {
                Write("Enter a number: ");

                isNumber = int.TryParse(ReadLine(), out int number);

                if (isNumber)
                {
                    WriteLine($"{number:N0}! = {Factorial(number):N0}");
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            } while (isNumber);
        }

        private static int Factorial(int number)
        {
            if (number < 1)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        private static void RunCardinalToOrdinal()
        {
            for (int number = 0; number < 40; number++)
            {
                Write($"{CardinalToOrdinal(number + 1)} ");
            }

            WriteLine();
        }

        /// <summary>
        /// Pass a 32-bit integer and it will be converted into its ordinal equivalent
        /// </summary>
        /// <param name="number">Number is a cardinal value e.g. 1, 2, 3, and so on.</param>
        /// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on.</returns>
        private static string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11:
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    string numberAsText = number.ToString();
                    char lastDigit = numberAsText[^1];
                    string suffix = string.Empty;
                    switch (lastDigit)
                    {
                        case '1':
                            suffix = "st";
                            break;
                        case '2':
                            suffix = "nd";
                            break;
                        case '3':
                            suffix = "rd";
                            break;
                        default:
                            suffix = "th";
                            break;
                    }

                    return $"{number}{suffix}";
            }
        }

        private static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0.0M;
            // switch (twoLetterRegionCode)
            // {
            //     case "CH":
            //         rate = 0.08M;
            //         break;
            //     case "DK":
            //     case "NO":
            //         rate = 0.25M;
            //         break;
            //     case "GB": // United Kingdom
            //     case "FR": // France
            //         rate = 0.2M;
            //         break;
            //     case "HU": // Hungary
            //         rate = 0.27M;
            //         break;
            //     case "OR": // Oregon
            //     case "AK": // Alaska
            //     case "MT": // Montana
            //         rate = 0.0M; break;
            //     case "ND": // North Dakota
            //     case "WI": // Wisconsin
            //     case "ME": // Maryland
            //     case "VA": // Virginia
            //         rate = 0.05M;
            //         break;
            //     case "CA": // California
            //         rate = 0.0825M;
            //         break;
            //     default: // most US states
            //         rate = 0.06M;
            //         break;
            // }

            rate = twoLetterRegionCode switch
            {
                "CH" => 0.08M,
                "DK" => 0.25M,
                "NO" => 0.25M,
                "GB" => 0.2M,
                "FR" => 0.2M,
                "HU" => 0.27M,
                "OR" => 0.0M,
                "AK" => 0.0M,
                "MT" => 0.0M,
                "ND" => 0.05M,
                "WI" => 0.05M,
                "ME" => 0.05M,
                "VA" => 0.05M,
                "CA" => 0.0825M,
                _ => 0.06M
            };

            return amount * rate;
        }

        private static void RunCalculateTax()
        {
            Write("Enter an amount: ");
            string amountInText = ReadLine();
            Write("Enter a two-letter region code: ");
            string region = ReadLine();

            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = CalculateTax(amount, region);
                WriteLine($"You must pay {taxToPay} in sales tax.");
            }
            else
            {
                WriteLine("You did not enter a valid amount!");
            }
        }

        private static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table:");
            for (int row = 0; row < number; row++)
            {
                WriteLine($"{row + 1} x {number} = {(row + 1) * number}");
            }

            WriteLine();
        }

        private static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Write("Enter a number between 0 and 255: ");

                isNumber = byte.TryParse(ReadLine(), out byte number);

                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            } while (isNumber);
        }
    }
}