using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
    public class MovieMain
    {
        static void Main(string[] args)
        {
            MovieArray movies = new MovieArray();

            movies.Insert(new Movie(1, "Maidan", 499, "Yashraj"));
            movies.Insert(new Movie(2, "3 Idiots", 350, "Rajkumar Hirani"));
            movies.Insert(new Movie(3, "Mimi", 500, "Amit Khanna"));
            movies.Insert(new Movie(4, "Raone", 550, "Sanjay Lila"));

            Console.WriteLine("All Movies:");
            movies.DisplayAll();
            Console.WriteLine();


            /*Console.WriteLine("Movie with ID 2:");
            movies.DisplayByID(2);
            Console.WriteLine();*/

            /*movies.Update(3, new Movie(3, "Avengers: Endgame", 520, "Walt Disney Studios"));
            Console.WriteLine("All Movies after Update:");
            movies.DisplayAll();
            Console.WriteLine();*/

            movies.Delete(2);
            Console.WriteLine("All Movies after Delete:");
            movies.DisplayAll();

            /*movies.Insert(new Movie(5, "movie5", 499, " S.S.Rajamouli"));
            Console.WriteLine("--------------------------------------");
            movies.DisplayAll();*/





        }
    }
}
