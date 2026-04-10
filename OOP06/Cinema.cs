using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06
{
    public partial class Cinema:IPrintable
    {
        private  Ticket[] Tickets = new Ticket[20];

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


        public void ProcessTicket(Ticket t)
        {
            t.PrintTicket();
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


}
