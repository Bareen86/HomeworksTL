namespace HotelApi.Domain
{
    public class Hotel
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public int AmountOfRooms { get; init; }
        public List<RoomInfo> RoomsInfo { get; set; }
        public Hotel(int id, string name, int amountOfRooms, List<RoomInfo> roomInfo)
        {
            Id = id;
            Name = name;
            AmountOfRooms = amountOfRooms;
            RoomsInfo = roomInfo;
        }
        public Hotel(int id, string name, int amountOfRooms)
        {
            Id = id;
            Name = name;
            AmountOfRooms = amountOfRooms;
        }
    }
}
