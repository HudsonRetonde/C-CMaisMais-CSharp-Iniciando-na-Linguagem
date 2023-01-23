using Poust.Entities;

namespace Poust
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                    DateTime.Parse("21/06/2018 13:05:01"),
                    "Traveling to New Zeland",
                    "I'am going to visit this wonderful country!",
                    12
                );
            p1.AddComent(c1);
            p1.AddComent(c2);

            Comment c3 = new Comment("Have a nice trip!");
            Comment c4 = new Comment("Wow that's awesome!");

            Post p2 = new Post(
                    DateTime.Parse("28/07/2018 23:55:59"),
                    "Good nigth guys",
                    "See you tomorow",
                    5
                );
            p1.AddComent(c3);
            p1.AddComent(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}