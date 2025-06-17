using hotel_management_nhom5.Data;
using hotel_management_nhom5.Models;
using hotel_management_nhom5.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace hotel_management_nhom5.Repositories
{
    public class RoomTypeRepository : IRoomTypeRepository
    {
        private readonly AppDbContext _context = new AppDbContext();

        public List<RoomType> GetAll() => _context.RoomTypes.ToList();

        public void Add(RoomType type)
        {
            _context.RoomTypes.Add(type);
            _context.SaveChanges();
        }

        public void Update(RoomType type)
        {
            _context.Entry(type).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var type = _context.RoomTypes.Find(id);
            if (type != null)
            {
                _context.RoomTypes.Remove(type);
                _context.SaveChanges();
            }
        }

        public RoomType GetById(int id) => _context.RoomTypes.Find(id);
    }
}