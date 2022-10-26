using System;
namespace _10_advance_topic
{
    class Program
    {
        struct Game
        {
            public string name;
            public string developer;
            public double rating;
            public string releaseDate;

        }

        public static void Main(string[] args)
        {
            Game game1;
            game1.name = "Pokemon Go";
            game1.rating = 3.5;
            game1.developer = "Niantic";
            game1.releaseDate = "01.07.2016";

            Console.WriteLine("Game 1's name is : {0}", game1.name);
        }
    }
}
