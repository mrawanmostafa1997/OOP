using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06
{
    public static class TicketExtension
    {
        //3. Useful Utilities Without Modifying Existing Classes — The team needs to add some handy features to the existing Ticket types without touching their source code. For example: a method to generate a formatted receipt string from any ticket, and a method that takes an array of tickets and returns the total revenue. These should feel like they belong to the Ticket class when you call them, even though they are defined elsewhere.
        
        public static string GenerateReceipt(this Ticket ticket)
        {
            return $"--- Receipt ---\nTicket ID: {ticket.TicketId}\nMovie: {ticket.MovieName}\nPrice: {ticket.Price}\nPrice After Tax: {ticket.PriceAfterTax}\n----------------";
        }
        public static double GetTotalRevenue(this IEnumerable<Ticket> tickets)
        {
            var revenue = 0.0;
            foreach (var ticket in tickets)
            {
                revenue += ticket.PriceAfterTax;
            }
            return revenue;
        }
        


    }
}
