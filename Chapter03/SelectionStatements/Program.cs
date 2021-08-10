using System;
using System.IO;
using static System.Console;

namespace SelectionStatements
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("There are no arguments.");
            }
            else
            {
                WriteLine("There is at least one argument.");
            }

            object o = 3;
            int j = 4;

            if (o is int i)
            {
                WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                WriteLine("o is not an int so it cannot multiply!");
            }

            A_label:
            var number = (new Random()).Next(1, 7);
            WriteLine($"My random number is {number}");

            switch (number)
            {
                case 1:
                    WriteLine("One");
                    break;
                case 2:
                    WriteLine("Two");
                    goto case 1;
                case 3:
                    WriteLine("Three or four");
                    goto case 1;
                case 5:
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
                default:
                    WriteLine("Default");
                    break;
            }

            string path = @"C:\Users\vator\Documents\c_sharp_and_net_core\Code\Chapter03";

            Stream s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);

            string message = string.Empty;

            switch (s)
            {
                case FileStream writableFile when s.CanWrite:
                    message = "The stream is a file that I can write to.";
                    break;
                case FileStream readOnlyFile:
                    message = "The stream is a read-only file.";
                    break;
                case MemoryStream ms:
                    message = "The stream is a memory address.";
                    break;
                default:
                    message = "The stream is some other type.";
                    break;
                case null:
                    message = "The stream is null.";
                    break;
            }
            
            WriteLine(message);

            message = s switch
            {
                FileStream writableFile when s.CanWrite => "The stream is a file that I can write to.",
                FileStream readOnlyFile => "The stream is a read-only file.",
                MemoryStream ms => "The stream is a memory address.",
                null => "The stream is a null.",
                _ => "The stream is some other type.",
            };
            
            WriteLine(message);
        }
    }
}