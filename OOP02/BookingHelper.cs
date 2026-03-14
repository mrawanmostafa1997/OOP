using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    public static class BookingHelper
    {
        private static int bookingCounter = 0;
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double totalPrice = numberOfTickets * pricePerTicket;
            if (numberOfTickets >= 5)
            {
                return totalPrice * 0.9; // 10% discount for groups of 5 or more
            }
            else
            {
                return totalPrice; // No discount for smaller groups
            }
        }
        public static string GenerateBookingReference()
        {
            bookingCounter++;
            return $"BK-{bookingCounter}";

        
        }
    }
}
