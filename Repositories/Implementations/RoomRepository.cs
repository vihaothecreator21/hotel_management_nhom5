using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using hotel_management_nhom5.Data;
using hotel_management_nhom5.Models;
using hotel_management_nhom5.Repositories.Interfaces;

namespace hotel_management_nhom5.Repositories.Implementations
{
    public class RoomRepository : IRoomRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Room> _rooms;

        public RoomRepository()
        {
            
        }

        public RoomRepository(AppDbContext context)
        {
            _context = context;
            _rooms = context.Set<Room>();
        }

        public IEnumerable<Room> GetAll() =>
            _rooms.ToList();

        public Room GetById(int id) =>
            _rooms.Find(id);

        public void Update(Room room)
        {
            _context.Entry(room).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Add(Room room)
        {
            _rooms.Add(room);
            _context.SaveChanges();
        }

        public IEnumerable<Room> GetAvailable() => _rooms.Where(r => r.Type == "Available").ToList();

        public void Delete(int id)
        {
            var room = GetById(id);
            _rooms.Remove(room);
            _context.SaveChanges();
        }
    }
}
