using Hotels.Api.Rooms.Dtos;
using Hotels.Application.RoomsUpdatinng;

namespace Hotels.Api.Rooms.Mappers
{
    public static class UpdateRoomCommandMapper
    {
        public static UpdateRoomCommand Map(this UpdateRoomCommandDto command, int id)
        {
            return new UpdateRoomCommand
            {
                roomId= id,
                RoomType = command.RoomType,
                Capacity = command.Capacity,
            };
        }
    }
}
