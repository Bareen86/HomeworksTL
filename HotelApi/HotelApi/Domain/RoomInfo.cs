namespace HotelApi.Domain
{
    public class RoomInfo
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; init; }
        /// <summary>
        /// Amount of people who can stay in the room
        /// </summary>
        public int Capacity { get; init; }
        public List<Guest> Guests { get; set; }
        public RoomInfo(int roomNumber, string roomType, int peopleRoomCapacity)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            Capacity = peopleRoomCapacity;
        }
        public RoomInfo(string roomType, int peopleRoomCapacity)
        {
            RoomType = roomType;
            Capacity = peopleRoomCapacity;
        }
    }
}
