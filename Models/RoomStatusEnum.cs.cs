using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management_nhom5.Models
{
    public class RoomStatusEnumHelper
    {
        public enum RoomStatusEnum
        {
            Available,  // Phòng có sẵn
            Occupied,   // Phòng đã được thuê
            Cleaning    // Phòng đang được dọn dẹp
        }
    }
}
