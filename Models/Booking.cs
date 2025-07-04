using System;
using System.Collections.Generic;

namespace hotel_management_nhom5.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        // Foreign keys
        public int CustomerId { get; set; }
        public int RoomId { get; set; }

        // Navigation
        public Customer Customer { get; set; }
        public Room Room { get; set; }

        // Booking info
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime BookingDate { get; set; }
        public BookingStatus Status { get; set; } = BookingStatus.Booked;

        public List<Review> Reviews { get; set; } = new List<Review>();
      
        public string GuestName => Customer?.FullName ?? "";

     
        public string RoomNumber => Room?.RoomNumber ?? "";

      
        public string CheckInOut
            => $"{CheckIn:dd/MM/yyyy} → {CheckOut:dd/MM/yyyy}";
    }
}
