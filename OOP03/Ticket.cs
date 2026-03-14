using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class Ticket
    {
		static int _ticketIdCounter = 0;
		public Ticket(string movieName,double price)
		{
			_movieName = movieName;
			_price = price;
            TicketId = $"BK{++_ticketIdCounter}";
        }
        private string _movieName;

		public string MovieName
		{
			get { return _movieName; }
			set { _movieName = value; }
		}
		private double _price;

		public double Price
		{
			get { return _price; }
			set {
				if (value < 0)
				{
					return;
                }
                _price = value; 
			}
		}
        public string TicketId { get; }
		private double _priceAfterTax;

		public double PriceAfterTax => _price * 1.14; // Assuming a tax rate of 10%
		
		public override string ToString()
		{
			return $"Ticket ID: {TicketId}, Movie: {MovieName}, Price: {Price}, Price After Tax: {PriceAfterTax}";
        }
		public static int GetTotalTickets()
		{
			return _ticketIdCounter;
        }

    }
	class StandardTicket : Ticket
	{
        public string SeatNumber { get; set; }
        public StandardTicket(string movieName, double price, string seatNumber) : base(movieName, price)
		{
			SeatNumber = seatNumber;
        }
		override public string ToString()
		{
			return $"Ticket ID: {TicketId}, Movie: {MovieName}, Price: {Price}, Price After Tax: {PriceAfterTax}, Seat Number: {SeatNumber}";
        }
    }
	class VIPTicket : Ticket
	{
        public bool LoungeAccess { get; set; }
		public decimal ServiceFee { get; set; } = 50;
        public VIPTicket(string movieName, double price,bool loungeAccess) : base(movieName, price)
		{
			LoungeAccess = loungeAccess;
			if (loungeAccess)
			{
				Price *= 1.2; // Increase price by 20% for VIP tickets with lounge access
            }
        }
		override public string ToString()
		{
            return $"Ticket ID: {TicketId}, Movie: {MovieName}, Price: {Price}, Price After Tax: {PriceAfterTax}, LoungeAccess: {LoungeAccess}";

        }
    }
	class IMAXTicket : Ticket
	{
		private bool is3D;

		public bool Is3D
		{
			get { return is3D; }
			set {
				
				is3D = value; 
			}

		}
		

		public IMAXTicket(string movieName, double price,bool is3D) : base(movieName, price)
		{

			this.is3D = is3D;
			if (is3D)
			{
				Price *= 1.3; // Increase price by 50% for 3D IMAX tickets
            }
        }
		 public override string ToString()
		{
			return $"Ticket ID: {TicketId}, Movie: {MovieName}, Price: {Price}, Price After Tax: {PriceAfterTax}, Is 3D: {Is3D}";
        }
    }
}
