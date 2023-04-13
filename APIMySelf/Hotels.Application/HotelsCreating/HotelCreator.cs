using Hotels.Domain.Hotels;

namespace Hotels.Application.HotelsCreathing
{
    public interface IHotelCreator
    {
        void CreateHotel( AddHotelCommand command );
    }
    public class HotelCreator : IHotelCreator
    {
        private readonly IHotelRepository _hotelRepository;

        public HotelCreator( IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }
        public void CreateHotel( AddHotelCommand command )
        {
            Hotel hotel = new Hotel( command.Name, command.NumberOfStars );
            _hotelRepository.AddHotel( hotel );
        }
    }
}
