using System.Collections.Generic;
using System.Linq;
using hotel_management_nhom5.Data;
using hotel_management_nhom5.Models;
using hotel_management_nhom5.Repositories.Interfaces;

namespace hotel_management_nhom5.Repositories.Implementations
{
    public class RoomRepository : IRoomRepository
    {
        private readonly AppDbContext _db = new AppDbContext();

        public IEnumerable<Room> GetAll() =>
            _db.Rooms.ToList();

        public IEnumerable<Room> GetAvailable() =>
            _db.Rooms.Where(r => r.Status == "Available").ToList();

        public Room GetById(int id) =>
            _db.Rooms.Find(id);

        public void Update(Room r)
        {
            _db.Entry(r).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
