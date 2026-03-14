using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class Cinema
    {
        private Ticket[] Tickets = new Ticket[20];

        public string CinemaName { get; set; }
        public Projector projector { get; set; }
        public Cinema(string cinemaName, string location)
        {
            CinemaName = cinemaName;
            projector = new Projector();
        }
        public void AddTicket(Ticket ticket)
        {
            for (int i = 0; i < Tickets.Length; i++)
            {
                if (Tickets[i] == null)
                {
                    Tickets[i] = ticket;
                    return;
                }
            }
                
        }
        public void PrintAllTickets()
        {
            foreach (var ticket in Tickets)
            {
                if (ticket != null)
                {
                    Console.WriteLine(ticket);
                }
            }
        }
        public void OpenCinema()
        {
            projector.TurnOn();
        }
         public void CloseCinema()
        {
            projector.TurnOff();
        }
    }

    public class Projector
    {
        public bool IsOn { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Projector is now ON.");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Projector is now OFF.");
        }
    }
}
