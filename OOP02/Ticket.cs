using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    class Ticket
    {
        private string _movieName;

        public string MovieName
        {
            //• MovieName : cannot be null or empty. If an invalid value is set, keep the previous value.


            get { return _movieName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return;
                }
                _movieName = value;
            }
        }

        public type TicketType { get; set; }

        public SeatLocation SeatLocation { get; set; }

        private double _price;

        public double Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _price = value;
            }
        }
        private static int ticketCount = 0;

        public string TicketId { get; set; }


        private static int totalTicketsSold = 0;
        public Ticket(string movieName, double price, type type, SeatLocation seatLocation)
        {
            MovieName = movieName;
            Price = price;
            TicketType = type;
            SeatLocation = seatLocation;
            ticketCount++;
            TicketId = BookingHelper.GenerateBookingReference();
   
        }
        public Ticket(string movieName) : this(movieName, 50.0, type.Standard, new SeatLocation('A', 1))
        {


        }
        public static int GetTotalTicketsSold()
        {
            return ticketCount;
        }
        public double PriceAfterTax()
        {
            var taxPercent = 14;
            var TotalPrice = Price + (Price * taxPercent / 100);
            return TotalPrice;


        }
        public double CalcTotal(double taxPercent)
        {
            var TotalPrice = Price + (Price * taxPercent / 100);
            return TotalPrice;
        }
        public double ApplyDiscount(double discountAmount)
        {
            if (discountAmount < 0 || discountAmount > Price)
            {
                return 0.0;
            }
            Price = Price - (Price * discountAmount / 100);
            return discountAmount;
        }
        public void PrintTicket()
        {
            Console.WriteLine($"Movie: {MovieName}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Type: {TicketType}");
            Console.WriteLine($"Seat: Row {SeatLocation.Row}, Number {SeatLocation.Number}");
        }
    }
    struct SeatLocation
    {
        public char Row { get; set; }
        public int Number { get; set; }
        public SeatLocation(char row, int number)
        {
            Row = row;
            Number = number;
        }
    }
    enum type
    {
        Standard,
        VIP,
        IMAX,
    };

}
