using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;                      // dùng cho Include
using hotel_management_nhom5.Data;
using hotel_management_nhom5.Models;
using hotel_management_nhom5.Repositories.Interfaces;

namespace hotel_management_nhom5.Repositories.Implementations
{
    public class BookingRepository : IBookingRepository
    {
        private readonly AppDbContext _db = new AppDbContext();

        public IEnumerable<Booking> GetAll() =>
            _db.Bookings.ToList();

        public IEnumerable<Booking> GetByCustomer(int custId) =>
            _db.Bookings.Where(r => r.CustomerId == custId).ToList();

        public Booking GetActiveByCustomer(int custId) =>
            _db.Bookings
               .FirstOrDefault(r => r.CustomerId == custId
                                 && r.Status != BookingStatus.CheckedOut);

        // ← Thêm phương thức này cho interface GetByIdentity
        public Booking GetByIdentity(string identityNumber) =>
            _db.Bookings
               .Include(b => b.Customer)
               .Include(b => b.Room)
               .FirstOrDefault(b =>
                   b.Customer.IdentityCard == identityNumber
                   && b.Status != BookingStatus.CheckedOut
               );

        public void Add(Booking r)
        {
            _db.Bookings.Add(r);
            _db.SaveChanges();
        }

        public void Update(Booking r)
        {
            _db.Entry(r).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
