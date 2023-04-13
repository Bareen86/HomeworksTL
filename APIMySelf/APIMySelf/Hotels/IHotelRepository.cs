namespace Hotels.Domain.Hotels
{
    public interface IHotelRepository
    {
        public List<Hotel> GetAllHotels();
        public void AddHotel(Hotel hotel);

        public void UpdateHotel(Hotel hotel);

        public void DeleteHotel(Hotel hotel);

        public Hotel GetById(int id);
    }
}
