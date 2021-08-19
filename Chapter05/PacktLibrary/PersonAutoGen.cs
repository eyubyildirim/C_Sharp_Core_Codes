using System;

namespace Packt.Shared
{
    public partial class Person
    {
        private string favoritePrimaryColor;

        public string Origin
        {
            get { return $"{Name} was born on {HomePlanet}"; }
        }

        public string Greeting => $"{Name} says 'Hello!'";

        public int Age => System.DateTime.Today.Year - DateOfBirth.Year;

        public string FavoriteIceCream { get; set; }

        public string FavoritePrimaryColor
        {
            get { return favoritePrimaryColor; }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new ArgumentException(
                            $"{value} is not a primary color. " +
                            "Choose from: red, green, blue.");
                }
            }
        }

        public Person this[int index]
        {
            get => Children[index];
            set => Children[index] = value;
        }
    }
}