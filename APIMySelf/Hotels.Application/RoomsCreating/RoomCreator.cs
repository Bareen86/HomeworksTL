using Hotels.Domain.Hotels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.RoomsCreating
{
    public interface IRoomCreator
    {
        void CreateRoom(Room  room);
    }
    public class RoomCreator : IRoomCreator
    {
        private readonly IRoomRepository _roomRepository;

        public RoomCreator(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        public void CreateRoom(Room room)
        {
            _roomRepository.AddRoom(room);
        }
    }
}
