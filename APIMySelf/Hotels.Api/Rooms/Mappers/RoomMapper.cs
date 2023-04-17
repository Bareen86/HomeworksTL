using Hotels.Api.Rooms.Dtos;
using Hotels.Domain.Hotels;

namespace Hotels.Api.Rooms.Mappers
{
    public static class RoomMapper
    {
        public static RoomDto Map(this Room room)
        {
            return new RoomDto
            {
                Id = room.Id,
                HotelId = room.HotelId,
                RoomType = room.RoomType,
                Capacity = room.Capacity
            };
        }
    }
}
