namespace Hotels.Api.Rooms.Dtos
{
    public class UpdateRoomCommandDto
    {
        public string RoomType { get; init; }
        public int Capacity { get; init; }
    }
}
