using hotel_management_nhom5.Data;
using hotel_management_nhom5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace hotel_management_nhom5.Repositories
{
    public class RoomRepository
    {
        private readonly AppDbContext _context = new AppDbContext();

        // Lấy tất cả các phòng
        public List<Room> GetAll() => _context.Rooms.ToList();

        // Thêm một phòng mới
        public void Add(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();
        }

        // Cập nhật thông tin phòng
        public void Update(Room room)
        {
            _context.Entry(room).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        // Xóa phòng
        public void Delete(int id)
        {
            var room = _context.Rooms.Find(id);
            if (room != null)
            {
                _context.Rooms.Remove(room);
                _context.SaveChanges();
            }
        }
    }
}
