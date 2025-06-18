<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
﻿using hotel_management_nhom5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> feature/room-crud

namespace hotel_management_nhom5.Models
{
    public class RoomType
    {
<<<<<<< HEAD
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; } // "Normal", "Premium"
=======
        public int RoomTypeId { get; set; }
        public string TypeName { get; set; }
>>>>>>> feature/room-crud
    }
}
