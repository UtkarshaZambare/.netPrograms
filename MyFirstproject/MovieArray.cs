    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
  public  class MovieArray
    {
        private Movie[] movies;
        private int size;
        private const int CapacityIncrement = 10;

        public MovieArray()
        {

            movies = new Movie[CapacityIncrement];
            size = 0;
        }

        public void Insert(Movie movie)
        {

            if (size >= movies.Length)
            {
                Array.Resize(ref movies, movies.Length + CapacityIncrement);
            }

            movies[size++] = movie;
        }

        public void Update(int movieId, Movie updatedMovie)
        {

            for (int i = 0; i < size; i++)
            {
                if (movies[i].MovieId == movieId)
                {
                    movies[i] = updatedMovie;
                    return;
                }
            }
            Console.WriteLine($"Movie with ID {movieId} not found.");

        }

        public void Delete(int movieId)
        {

            for (int i = 0; i < size; i++)
            {
                if (movies[i].MovieId == movieId)
                {
                    for (int j = i; j < size - 1; j++)
                    {
                        movies[j] = movies[j + 1];
                    }
                    size--;
                    movies[size] = null;
                    return;
                }
            }
            Console.WriteLine($"Movie with ID {movieId} not found.");

        }

        public void DisplayByID(int movieId)
        {

            for (int i = 0; i < size; i++)
            {
                if (movies[i].MovieId == movieId)
                {
                    Console.WriteLine($"Movie ID: {movies[i].MovieId}, Name: {movies[i].Name}, Ticket Cost: {movies[i].TicketCost}, Producer: {movies[i].ProducerName}");
                    return;

                }

            }
            Console.WriteLine($"Movie with ID {movieId} not found.");

        }

        public void DisplayAll()
        {
            foreach (var movie in movies)
            {
                if (movie != null)
                {
                    Console.WriteLine($"Movie ID: {movie.MovieId}, Name: {movie.Name}, Ticket Cost: {movie.TicketCost}, Producer: {movie.ProducerName}");
                }
            }
        }

    }
}
