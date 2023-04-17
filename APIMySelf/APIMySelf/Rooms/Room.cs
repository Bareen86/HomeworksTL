namespace Hotels.Domain.Hotels
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomType { get;  set;}
        public int Capacity { get;  set; }
        public int HotelId { get; set; }
        public Hotel? Hotel { get; set; }
        public Room(string roomType, int capacity, int hotelId)
        {
            RoomType = roomType;
            Capacity = capacity;
            HotelId = hotelId;
        }
        public void UpdateRoomType(string roomType)
        {
            RoomType = roomType;
        }
        
        public void UpdateCapacity(int roomCapacity)
        {
            Capacity = roomCapacity;
        }
    }
}
