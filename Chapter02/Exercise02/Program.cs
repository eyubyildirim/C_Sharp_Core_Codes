using System;
using static System.Console;

namespace Exercise02
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var formats = new[] {"Type", "Byte(s) of memory", "Min", "Max"};
            WriteLine("-------------------------------------------------------------------------------------------");
            WriteLine(
                format: "{0, -8} {1, -20} {2, 30} {3, 30}",
                formats
            );
            WriteLine("-------------------------------------------------------------------------------------------");

            // sbyte
            var sbyteFormats = new[]
                {"sbyte", sizeof(sbyte).ToString(), sbyte.MinValue.ToString(), sbyte.MaxValue.ToString()};
            WriteLine(
                format: "{0, -8} {1, -20} {2, 30} {3, 30}",
                sbyteFormats
            );

            // byte
            var byteFormats = new[]
                {"byte", sizeof(byte).ToString(), byte.MinValue.ToString(), byte.MaxValue.ToString()};
            WriteLine(
                format: "{0, -8} {1, -20} {2, 30} {3, 30}",
                byteFormats
            );
            
            // short
            var shortFormats = new[]
                {"short", sizeof(short).ToString(), short.MinValue.ToString(), short.MaxValue.ToString()};
            WriteLine(
                format: "{0, -8} {1, -20} {2, 30} {3, 30}",
                shortFormats
            );
            
            // ushort
            var ushortFormats = new[]
                {"ushort", sizeof(ushort).ToString(), ushort.MinValue.ToString(), ushort.MaxValue.ToString()};
            WriteLine(
                format: "{0, -8} {1, -20} {2, 30} {3, 30}",
                ushortFormats
            );

            // int
            var intFormats = new[]
                {"int", sizeof(int).ToString(), int.MinValue.ToString(), int.MaxValue.ToString()};
            WriteLine(
                format: "{0, -8} {1, -20} {2, 30} {3, 30}",
                intFormats
            );

            // uint
            var uintFormats = new[]
                {"uint", sizeof(uint).ToString(), uint.MinValue.ToString(), uint.MaxValue.ToString()};
            WriteLine(
                format: "{0, -8} {1, -20} {2, 30} {3, 30}",
                uintFormats
            );

            // long
            var longFormats = new[]
                {"long", sizeof(long).ToString(),long.MinValue.ToString(), long.MaxValue.ToString()};
            WriteLine(
                format: "{0, -8} {1, -20} {2, 30} {3, 30}",
                longFormats
            );
            // ulong
            var ulongFormats = new[]
                {"ulong", sizeof(ulong).ToString(), ulong.MinValue.ToString(), ulong.MaxValue.ToString()};
            WriteLine(
                format: "{0, -8} {1, -20} {2, 30} {3, 30}",
                ulongFormats
            );

            // float
            var floatFormats = new[]
                {"float", sizeof(float).ToString(), float.MinValue.ToString(), float.MaxValue.ToString()};
            WriteLine(
                format: "{0, -8} {1, -20} {2, 30} {3, 30}",
                floatFormats
            );

            // double
            var doubleFormats = new[]
                {"double", sizeof(double).ToString(), double.MinValue.ToString(), double.MaxValue.ToString()};
            WriteLine(
                format: "{0, -8} {1, -20} {2, 30} {3, 30}",
                doubleFormats
            );

            // decimal
            var decimalFormats = new[]
                {"decimal", sizeof(decimal).ToString(), decimal.MinValue.ToString(), decimal.MaxValue.ToString()};
            WriteLine(
                format: "{0, -8} {1, -20} {2, 30} {3, 30}",
                decimalFormats
            );
        }
    }
}