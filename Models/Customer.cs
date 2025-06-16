using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management_nhom5.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Full_Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Identity_Card { get; set; }
        public DateTime Created_at { get; set; }

        public List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}

