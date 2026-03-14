using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    class Cinema
    {
        private Ticket[] tickets = new Ticket[20];

        public Ticket[] Tickets
        {
            get { return tickets; }
        }

        public Ticket this[int index]
        {
            get
            {
                if (index > 0 && index < tickets.Length)
                {
                    return tickets[index];

                }
                return null;

            }
            set
            {
                if (index > 0 && index < tickets.Length)
                {
                    return;

                }
                tickets[index] = value;

            }
        }
        public Ticket this[string movieName]
        {
            get
            {
                foreach (var ticket in tickets)
                {
                    if (ticket != null && ticket.MovieName == movieName)
                    {
                        return ticket;
                    }

                }

                return null;

            }

        }
        public string Name { get; set; }
        public string Location { get; set; }
        public Cinema(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public bool AddTicket(Ticket ticket)
        {
            for (int i = 0; i < Tickets.Length; i++)
            {
                if (Tickets[i] == null)
                {
                    Tickets[i] =ticket;
                    return true;
                }

            }
            return false;
        }
    }

}
