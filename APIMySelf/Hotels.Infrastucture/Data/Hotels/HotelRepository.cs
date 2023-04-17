using Hotels.Domain.Hotels;
using Hotels.Infrastucture.Foundation;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Infrastructure.Data.Hotels
{
    internal class HotelRepository : IHotelRepository
    {
        private readonly HotelsDbContext context;
        private DbSet<Hotel> _hotels => context.Set<Hotel>();
        public HotelRepository(HotelsDbContext dbContext)
        {
            context = dbContext;
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotels.ToList();
        }

        public void AddHotel(Hotel hotel)
        {
            _hotels.Add(hotel);
        }

        public void DeleteHotel(Hotel hotel)
        {
            _hotels.Remove(hotel);
        }

        public Hotel GetById(int id)
        {
            return _hotels.SingleOrDefault(h => h.Id == id);
        }

        public void UpdateHotel(Hotel hotel)
        {
            var searchedHotel = GetById(hotel.Id);
            searchedHotel.UpdateName(hotel.Name);
            searchedHotel.UpdateNumberOfStars(hotel.NumberOfStars);
        }
    }
}
