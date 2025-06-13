using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management_nhom5.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string Room_number { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }

        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
