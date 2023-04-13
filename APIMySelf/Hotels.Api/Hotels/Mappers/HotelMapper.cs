using Hotels.Api.Hotels.Dtos;
using Hotels.Domain.Hotels;

namespace Hotels.Api.Hotels.Mappers
{
    public static class HotelMapper
    {
        public static HotelDto Map(this Hotel hotel)
        {
            return new HotelDto()
            {
                Id = hotel.Id,
                Name = hotel.Name,
                NumberOfStars = hotel.NumberOfStars,
            };
        }
    }
}
