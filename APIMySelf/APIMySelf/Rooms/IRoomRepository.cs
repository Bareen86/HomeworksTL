using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.Hotels
{
    public interface IRoomRepository
    {
        public List<Room> GetAllRooms();
        public void AddRoom(Room room);

        public void UpdateRoom(Room room);

        public void DeleteRoom(Room room);

        public Room GetRoomById(int id);
    }
}
