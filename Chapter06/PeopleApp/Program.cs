﻿using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var harry = new Person() {Name = "Harry"};
            var mary = new Person() {Name = "Mary"};
            var jill = new Person() {Name = "Jill"};

            var baby1 = mary.ProcreateWith(harry);
            var baby2 = Person.Procreate(harry, jill);
            var baby3 = harry * mary;

            WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            WriteLine($"{jill.Name} has {jill.Children.Count} children.");

            WriteLine(
                format: "{0}'s first child is named \"{1}\".",
                arg0: harry.Name,
                arg1: harry.Children[0].Name);

            WriteLine($"5! is {Person.Factorial(5)}");

            harry.Shout += Harry_Shout;

            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();
        }

        private static void Harry_Shout(object sender, EventArgs e)
        {
            var p = (Person) sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
        }
    }
}