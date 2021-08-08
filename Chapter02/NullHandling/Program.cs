#nullable enable

using System;

namespace NullHandling
{
    internal class Address
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }

    internal static class Program
    {
        private static void Main(string[] args)
        {
            // int thisCannotBeNull = 4;
            // thisCannotBeNull = null;

            int? thisCanBeNull = null;
            Console.WriteLine(thisCanBeNull);
            Console.WriteLine(thisCanBeNull.GetValueOrDefault());

            thisCanBeNull = 7;
            Console.WriteLine(thisCanBeNull);
            Console.WriteLine(thisCanBeNull.GetValueOrDefault());

            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;
            
            Console.WriteLine(address.Street);
        }
    }
}