using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management_nhom5.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        public decimal Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}