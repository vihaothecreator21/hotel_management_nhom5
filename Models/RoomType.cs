using System.ComponentModel.DataAnnotations;

namespace hotel_management_nhom5.Models
{
    public class RoomType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; } // "Normal", "Premium"
    }
}
