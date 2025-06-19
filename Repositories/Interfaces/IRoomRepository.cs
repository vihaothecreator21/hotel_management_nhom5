using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotel_management_nhom5.Models;

namespace hotel_management_nhom5.Repositories.Interfaces
{
    public interface IRoomRepository
    {
        IEnumerable<Room> GetAll();
        IEnumerable<Room> GetAvailable();   // lọc theo Room.Status == "Available"
        Room GetById(int id);
        void Update(Room r);
    }
}