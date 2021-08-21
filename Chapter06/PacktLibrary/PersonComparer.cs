using System.Collections.Generic;

namespace Packt.Shared
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = x.Name.Length.CompareTo(y.Name.Length);

            return result == 0 ? x.Name.CompareTo(y.Name) : result;
        }
    }
}