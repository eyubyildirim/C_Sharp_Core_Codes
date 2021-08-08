using System;
using System.Linq;
using System.Reflection;

namespace Basics
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            System.Data.DataSet ds;
            System.Net.Http.HttpClient client;

            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                var a = Assembly.Load(new AssemblyName(r.FullName));

                var methodCount = a.DefinedTypes.Sum(t => t.GetMethods().Count());

                Console.WriteLine(
                    "{0:N0} types with {1:N0} methods in {2} assembly.",
                    arg0: a.DefinedTypes.Count(),
                    arg1: methodCount,
                    arg2: r.Name
                );
            }
        }
    }
}
