using Hotels.Domain.Hotels;

namespace Hotels.Application.HotelsRemover
{
    public interface IHotelRemover
    {
        void Remove(int id);
    }
    public class HotelRemover: IHotelRemover
    {
        private readonly IHotelRepository _hotelRepository;

        public HotelRemover(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public void Remove(int id)
        {
            var hotel = _hotelRepository.GetById(id);
            _hotelRepository.DeleteHotel(hotel);
        }
    }
}
