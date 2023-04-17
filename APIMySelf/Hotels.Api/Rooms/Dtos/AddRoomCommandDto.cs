namespace Hotels.Api.Rooms.Dtos
{
    public class AddRoomCommandDto
    {
        public string RoomType { get; init; }
        public int Capacity { get; init; }
    }
}
