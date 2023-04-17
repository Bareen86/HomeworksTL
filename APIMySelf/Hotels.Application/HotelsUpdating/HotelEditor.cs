using Hotels.Application.HotelsCreathing;
using Hotels.Domain.Hotels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.HotelsUpdating
{
    public interface IHotelEditor
    {
        void EditHotel(Hotel hotel);
    }
    public class HotelEditor : IHotelEditor
    {

        private readonly IHotelRepository _hotelRepository;

        public HotelEditor(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public void EditHotel(Hotel hotel)
        {
            _hotelRepository.UpdateHotel(hotel);
        }
    }
}
