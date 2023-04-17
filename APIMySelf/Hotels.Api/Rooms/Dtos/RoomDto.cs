namespace Hotels.Api.Rooms.Dtos
{
    public class RoomDto
    {
        public int Id { get; init; }
        public string RoomType { get; init; }
        public int Capacity { get; init; }
        public int HotelId { get; init; }
    }
}
