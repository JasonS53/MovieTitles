using System;
using System.Collections.Generic;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie("The Ring", "horror"),
                new Movie("Stargate", "scifi"),
                new Movie("Wolf", "drama"),
                new Movie("It", "horror"),
                new Movie("Aeon Flux", "animated"),
                new Movie("Namesake", "drama"),
                new Movie("Toy Story", "animated"),
                new Movie("Star Trek", "scifi"),
                new Movie("Twister", "drama"),
                new Movie("Hitchhikers Guide to the Galaxy", "scifi")
            };

            //start of program
            Console.WriteLine("Welcome to the Movie List Application");
            Console.WriteLine();
            Console.WriteLine($"There are {movies.Count} movies in this list.");

            //user input

            bool runProgram = (true);
            while (runProgram)
            {
                Console.WriteLine("What category are you interested in?");
                Console.WriteLine("animated, drama, horror or scifi");
                string result = Console.ReadLine();

                if (result == "")
                {
                    Console.WriteLine("That was an empty entry");
                }
                               
                //display all movies that match category
                foreach (Movie movie in movies)
                {
                    if (movie.Category == result)
                    {
                        Console.WriteLine($"{movie.Title}");
                    }
                }

                //ask if they want to continue
                Console.WriteLine();
                Console.WriteLine("Would you like to see another category? y/n");
                while (runProgram)
                {
                    string yesno = Console.ReadLine();
                    if (yesno == "y")
                    {
                        break;
                    }
                    else if (yesno == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid choice");
                    }
                }
            }
        }
    }
}
