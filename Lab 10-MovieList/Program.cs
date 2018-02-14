using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;

namespace MovieList
{

    class Program
    {
        public static void Main(string[] args)
        {
            List<Movie> movieObjects = Movie.MovieBuilder();
            //have to make a list of the movieObject list so that it pull the list from movie class into program

            //WELCOME
            Console.WriteLine("Welcome to Tiny Netflix!");

            //RUN PROGRAM
            bool ExitProgram = false;
            while (ExitProgram == false)
            {
                //REQUEST CATEGORY
                Console.WriteLine("\nPlease choose a category: \nAnimated, Drama, Horror, or SciFi\n");
                string userChoice =  Console.ReadLine();

                Console.WriteLine("\nExcellent choice! Here are your movies: \n");



                //DISPLAY MOVIES
           
                foreach (Movie movies in movieObjects)
                {
                    if (movies.Category == userChoice)  //making this match the userchoice eliminates unnecessary if statements
                        Console.WriteLine(movies.Name, movies.Category);
                }


                //EXIT OR CONTINUE?
                Console.WriteLine("\nWould you like to make another selection? y/n");
                string Continue = Console.ReadLine();
                if (Continue == "y")
                {
                    ExitProgram = false;
                    
                }
                else
                {
                    ExitProgram = true;
                    Console.WriteLine("\nThank you for choosing Tiny Netflix! Please come again.\n");
                }

            }
        }

    }

}



