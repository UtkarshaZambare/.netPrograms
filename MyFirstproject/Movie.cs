using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstproject
{
   public  class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public double TicketCost { get; set; }
        public string ProducerName { get; set; }

        public Movie(int movieId, string name, double ticketCost, string producerName)
        {
            MovieId = movieId;
            Name = name;
            TicketCost = ticketCost;
            ProducerName = producerName;
        }

        public override string ToString()
        {
            return $"Movie ID: {MovieId}, Name: {Name}, Ticket Cost: {TicketCost}, Producer: {ProducerName}";
        }
       



    }
}
