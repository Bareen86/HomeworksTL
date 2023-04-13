using Hotels.Domain.Hotels;
using Hotels.Infrastucture.Foundation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Infrastructure.Data.Rooms
{
    internal class RoomRepository : IRoomRepository
    {
        private readonly HotelsDbContext dbContext;
        private DbSet<Room> _rooms => dbContext.Set<Room>();
        public RoomRepository(HotelsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

        public void DeleteRoom(Room room)
        {
            _rooms.Remove(room);
        }

        public List<Room> GetAllRooms()
        {
            return _rooms.ToList();
        }

        public Room GetRoomById(int id)
        {
            return _rooms.Where(r => r.Id == id).FirstOrDefault();
        }

        public void UpdateRoom(Room room)
        {
            var searchedRoom = GetRoomById(room.Id);
            searchedRoom.UpdateRoomType(room.RoomType);
            searchedRoom.UpdateCapacity(room.Capacity);
        }
    }
}
