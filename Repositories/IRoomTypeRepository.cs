using hotel_management_nhom5.Models;
using System.Collections.Generic;

namespace hotel_management_nhom5.Repositories
{
    public interface IRoomTypeRepository
    {
        List<RoomType> GetAll();
        void Add(RoomType type);
        void Update(RoomType type);
        void Delete(int id);
        RoomType GetById(int id);
    }
}