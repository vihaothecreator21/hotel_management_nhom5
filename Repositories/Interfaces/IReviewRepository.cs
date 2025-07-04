using System.Collections.Generic;
using hotel_management_nhom5.Models;

namespace hotel_management_nhom5.Repositories.Interfaces
{
    public interface IReviewRepository
    {
        IEnumerable<Review> GetAll();   // trả về IEnumerable<Review>
        void Add(Review r);
    }
}
