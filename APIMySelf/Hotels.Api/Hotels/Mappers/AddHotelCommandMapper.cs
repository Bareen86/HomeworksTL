using Hotels.Api.Hotels.Dtos;
using Hotels.Application.HotelsCreathing;

namespace Hotels.Api.Hotels.Mappers
{
    public static class AddHotelCommandMapper
    {
        public static AddHotelCommand Map(this AddHotelCommandDto command)
        {
            return new AddHotelCommand
            {
                Name = command.Name,
                NumberOfStars = command.NumberOfStars,
            };
        }
    }
}
