using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06
{
    public partial class Cinema
    {
        public void PrintAllTickets()
        {
            foreach (var ticket in Tickets)
            {
                if (ticket != null)
                {
                    ticket.PrintTicket();
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("=== Cinema Ticket Roster ===");
            foreach (var ticket in Tickets)
            {
                ticket.Print();
            }
            Console.WriteLine("============================");
        }
        public IEnumerable<Ticket> GetTickets()
        {
            var tickets = new List<Ticket>();
            foreach (var t in Tickets)
            {
                if (t != null)
                {
                    tickets.Add(t);
                }
                else
                {
                    break;
                }
            }

            return tickets;
        }
    }
}
