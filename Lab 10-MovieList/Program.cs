using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_10_MovieList
{

    //CREATE MOVIE CLASS
    class Movie
    {
        private string movieName;
        private string movieCategory;
        private int categoryNumber;


        //CREATE GET/SET PROPERTIES IN ORDER TO RETRIEVE AND SET THE FIELD NAMES FOR EACH OBJECT
        //public methods need to be created in order to write and read those fields (Name and Category)
        public string Name
        {
            get
            {
                return movieName;
            }
            set
            {
                movieName = value;
            }
        }
        public string Category
        {
            get
            {
                return movieCategory;
            }
            set
            {
                movieCategory = value;
            }
        }

        public int categoryNumber
        {
            get
            {
                return categoryNumber;
            }
            set
            {
                categoryNumber = value;
            }
        }

        //CREATE METHOD FOR CREATING THE INDVIDUAL MOVIE OBJECTS
        //constructors

        //CREATE THE MOVIE OBJECTS

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


        Console.WriteLine("Welcome to the World's Smallest Netflix! \n Please choose a genre: \n");

            bool ExitProgram = false;
            while (ExitProgram == false)
            {


            //DISPLAY MOVIES BY CATEGORY
            Console.WriteLine("Excellent choice! Here are your movies: \n");
            // ARRAY - LIST OF MOVIES

            
            //FOR EACH MOVIE IN THE ARRAY, PRINT THE MOVIE TITLE IF THE USER-SELECTED CATEGORY MATCHES THE CATEGORY OF THE MOVIE
            foreach object in

                if (true)
                {

                }


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



         
        }




}