using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management_nhom5.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string Staff_name { get; set; }
        public string Position { get; set; }
        public string Phone_number { get; set; }
        public string Email { get; set; }
        public DateTime Worked_date { get; set; }
    }
}
