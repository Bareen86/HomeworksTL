using Hotels.Api.Hotels.Dtos;
using Hotels.Api.Hotels.Mappers;
using Hotels.Application.HotelsCreathing;
using Hotels.Application.HotelsRemover;
using Hotels.Application.HotelsUpdating;
using Hotels.Domain.Hotels;
using Hotels.Infrastructure.Foundation;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.Api.Hotels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHotelCreator _hotelCreator;
        private readonly IHotelEditor _hotelEditor;
        private readonly IHotelRemover _hotelRemover;

        public HotelsController(
            IHotelRepository hotelRepository,
            IHotelCreator hotelsCreator,
            IHotelEditor hotelsEditor,
            IHotelRemover hotelsRemover,
            IUnitOfWork unitOfWork)
        {
            _hotelRepository = hotelRepository;
            _hotelCreator = hotelsCreator;
            _hotelEditor = hotelsEditor;
            _hotelRemover = hotelsRemover;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Hotel> hotels = _hotelRepository.GetAllHotels();
            var map = hotels.Select(h => h.Map()).ToList();
            return Ok(map);
        }
        [HttpGet("{hotelid}")]
        public IActionResult GetHotelById([FromRoute] int hotelid)
        {
            var result = _hotelRepository.GetById(hotelid);
            if (result == null)
            {
                return NotFound();
            }
            var map = result.Map();
            return Ok(map);
        }

        [HttpPost]
        public IActionResult Get([FromBody] AddHotelCommandDto command)
        {
            _hotelCreator.CreateHotel(command.Map());
            _unitOfWork.Commit();
            return Ok();
        }
        [HttpPut("{hotelid}")]
        public IActionResult Update([FromRoute] int hotelid, [FromBody] UpdateHotelCommandDto command)
        {
            Hotel hotel = new Hotel(hotelid, command.Name, command.NumberOfStars);
            _hotelEditor.EditHotel(hotel);
            _unitOfWork.Commit();
            return Ok();
        }
        [HttpDelete("hotelid")]
        public IActionResult Delete(int hotelid)
        {
            _hotelRemover.Remove(hotelid);
            _unitOfWork.Commit();
            return Ok();
        }
    }
}
