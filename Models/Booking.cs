using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management_nhom5.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }

        public DateTime Check_in { get; set; }
        public DateTime Check_out { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal Total_Price { get; set; }
        public DateTime Booking_Date { get; set; }
        public string Status { get; set; }

        public List<Review> Reviews { get; set; } = new List<Review>();
        
    }
}
