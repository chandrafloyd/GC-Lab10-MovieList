using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_10_MovieList
{

    //MOVIE CLASS
    class Movie
    {
        private string movieName;
        private string movieCategory;

        //Category

        public string Animated;
        public string Drama;
        public string Horror;
        public string SciFi;
    }
    
        public static void MovieList()
        {
            ArrayList movieList = new ArrayList();
     
            //Horror
            //movieList.Add("Saw", "Horror");
           // movieList.Add("Stephen King's IT", "Horror");
            movieList.Add("Nightmare on Elm Street");
            movieList.Add("Get Out");
            //Animated
            movieList.Add("Mulan ");
            movieList.Add("Tarzan");
            movieList.Add("Shrek");
            movieList.Add("Hoodwinked");
            //Drama
            movieList.Add("The Color Purple");
            movieList.Add("The Boy in the Striped Pajamas");
            movieList.Add("The Notebook");
            movieList.Add("Wild");
            //SciFi
            movieList.Add("Maze Runner");
            movieList.Add("Star Trek");
            movieList.Add("Divergent");
            movieList.Add("Star Wars");



        }

        //example
        class MainClass
        {
            public static void Main()
            {
                ArrayList inv = new ArrayList();

                // Add elements to the list 
                inv.Add(new Product("A", 5.9, 3));
                inv.Add(new Product("B", 8.2, 2));
                inv.Add(new Product("C", 3.5, 4));
                inv.Add(new Product("D", 1.8, 8));
            }

        }
    }



    //METHOD CLASS
    class Methods
    {
        //METHOD - EXIT PROGRAM
        public static void ExitProgram()
        {
            bool ExitProgram;
            string Continue;
            if (Continue == ("no"))  //"N" || "n" 
            {
                ExitProgram = true;
                Console.WriteLine("Goodbye!");
            }
        }

    }


    //VALIDATION CLASS
    class Validations
    {
        //TO DO - add validation for y/n in exit program


        //TO DO - add regex validation for category selection

    }


    //PROGRAM CLASS
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the World's Smallest Netflix! \n Please choose a genre: \n");

            bool ExitProgram = false;
            while (ExitProgram == false)
            {

                //DISPLAY MOVIES BY CATEGORY
                Console.WriteLine("Excellent choice! Here are your movies: \n");
                //to do - add the output here



                //CONTINUE? Y/N
                #region ContinueYN
                Console.WriteLine("Would you like to choose another category? \n");
                string Continue = Console.ReadLine();

                if (Continue == "N")
                {
                    ExitProgram = true;
                   // ExitProgram();
                }

                else
                {
                    ExitProgram = false;
                }
                #endregion ContinueYN
            }



            //example
            ArrayList names = new ArrayList();
            names.Add("Mary");
            names.Add("Joseph");

            Console.WriteLine("Original names:");
            foreach (object name in names)
                Console.WriteLine(name);

            Console.ReadLine();



            string[] newNames = new string[] { "David", "Goliath" };
            names.InsertRange(1, newNames);


            Console.WriteLine("Original names:");
            foreach (object name in names)
                Console.WriteLine(name);

        }




}