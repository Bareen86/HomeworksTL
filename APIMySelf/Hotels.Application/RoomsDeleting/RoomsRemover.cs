using Hotels.Domain.Hotels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.RoomsDeleting
{
    public interface IRoomRemover
    {
        void Remove(int hotelid, int roomid);
    }
    public class RoomsRemover : IRoomRemover
    {
        private readonly IRoomRepository _roomRepository;

        public RoomsRemover(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        public void Remove(int hotelid, int roomid)
        {
            var hotel = _roomRepository.GetAllRooms().Single(r => r.Id == roomid && r.HotelId == hotelid);
            _roomRepository.DeleteRoom(hotel);
        }
    }
}
