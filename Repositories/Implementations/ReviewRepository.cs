using System.Collections.Generic;
using System.Linq;
using hotel_management_nhom5.Data;
using hotel_management_nhom5.Models;
using hotel_management_nhom5.Repositories.Interfaces;

namespace hotel_management_nhom5.Repositories.Implementations
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly AppDbContext _db = new AppDbContext();

        public IEnumerable<Review> GetAll() =>
            _db.Reviews.ToList();

        public void Add(Review r)
        {
            _db.Reviews.Add(r);
            _db.SaveChanges();
        }
    }
}
