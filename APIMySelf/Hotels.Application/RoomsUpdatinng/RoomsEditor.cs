using Hotels.Domain.Hotels;

namespace Hotels.Application.RoomsUpdatinng
{
    public interface IRoomsEditor
    {
        void Update(Room room);
    }
    public class RoomsEditor : IRoomsEditor
    {
        private readonly IRoomRepository _roomRepository;

        public RoomsEditor(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        public void Update(Room room)
        {
            _roomRepository.UpdateRoom(room);
        }
    }
}
