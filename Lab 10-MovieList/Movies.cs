using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace MovieList
{
    class Movie
    {

        //FIELDS
        private string name, category;

        //PROPERTIES

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Category
        {
            set { category = value; }
            get { return category; }
        }


        //CONSTRUCTOR

        public Movie(string name, string category)
        {
            Name = name;
            Category = category;
        }

        //CREATE THE MOVIE OBJECTS

        public static List<Movie> MovieBuilder()  //had to create a method in order to bring the list to life
        {
          
            List<Movie> movies = new List<Movie>
                          
            {
                new Movie("Hoodwinked", "Animated"),   //this is the correct syntax for adding a new movie with type of 
                new Movie("Shrek", "Animated"),
                new Movie("Lego Batman", "Animated"),
                new Movie("The Notebook", "Drama"),
                new Movie("Dunkirk", "Drama"),
                new Movie("The Color Purple", "Drama"),
                new Movie("Stephen King's IT", "Horror"),
                new Movie("The Shining", "Horror"),
                new Movie("Nightmare on Elm Street", "Horror"),
                new Movie("Little Shop of Horrors", "SciFi"),
                new Movie("Star Wars", "SciFi"),
                new Movie("Divergent", "SciFi")
            
        };
         
            return movies;
    }

        //DISPLAY MOVIES BY CATEGORY
        // ENUM - Movie categories
        enum CategoryList
        {
            Animated = 1,
            Drama,
            Horror,
            SciFi,
        };
    }
}


