using Hotels.Domain.Hotels;

namespace Hotels.Application.RoomsUpdatinng
{
    public interface IRoomsEditor
    {
        void Update(UpdateRoomCommand command);
        
    }
    public class RoomsEditor : IRoomsEditor
    {
        private readonly IRoomRepository _roomRepository;

        public RoomsEditor(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        public void Update(UpdateRoomCommand command)
        {
            Room room = _roomRepository.GetRoomById(command.roomId);
            UpdateFiels(room, command);
        }
        private void UpdateFiels(Room room, UpdateRoomCommand command)
        {
            room.RoomType = command.RoomType;
            room.Capacity = command.Capacity;
        }
    }
}
