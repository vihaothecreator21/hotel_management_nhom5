using System.Collections.Generic;
using hotel_management_nhom5.Models;

namespace hotel_management_nhom5.Repositories.Interfaces
{
    public interface IBookingRepository
    {
        IEnumerable<Booking> GetAll();
        IEnumerable<Booking> GetByCustomer(int custId);
        Booking GetActiveByCustomer(int custId);
        Booking GetByIdentity(string identityNumber);   // ← thêm dòng này

        void Add(Booking r);
        void Update(Booking r);
    }
}
