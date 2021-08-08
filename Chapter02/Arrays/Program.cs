using System;

namespace Arrays
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            string[] names;

            // Allocating memory for 4 string objects
            names = new string[4];

            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";

            for (var i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            
        }
    }
}
