using Hotels.Api.Rooms.Dtos;
using Hotels.Api.Rooms.Mappers;
using Hotels.Application.RoomsCreating;
using Hotels.Application.RoomsDeleting;
using Hotels.Application.RoomsUpdatinng;
using Hotels.Domain.Hotels;
using Hotels.Infrastructure.Foundation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.Api.Rooms.Controllers
{
    [Route("api/")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IRoomCreator _roomCreator;
        private readonly IRoomsEditor _roomEditor;
        private readonly IRoomRemover _roomRemover;
        private readonly IUnitOfWork _unitOfWork;

        public RoomsController(
            IRoomRepository roomRepository,
            IRoomCreator roomCreator,
            IRoomsEditor roomEditor,
            IRoomRemover roomRemover,
            IUnitOfWork unitOfWork)
        {
            _roomRepository = roomRepository;
            _roomCreator = roomCreator;
            _roomEditor = roomEditor;
            _roomRemover = roomRemover;
            _unitOfWork = unitOfWork;
        }

        [HttpGet("Hotels/Rooms")]
        public IActionResult GetAll()
        {
            List<Room> rooms = _roomRepository.GetAllRooms();
            var map = rooms.Select(r => r.Map()).ToList();
            return Ok(map);
        }

        [HttpGet("Hotels/{hotelid}/Rooms")]
        public IActionResult HotelGetAllRooms(int hotelid)
        {
            var rooms = _roomRepository.GetAllRooms().Where(r => r.HotelId == hotelid);
            var map = rooms.Select(r =>r.Map()).ToList();
            return Ok(map);
        }

        [HttpPost("Hotels/{hotelid}/Rooms")]
        public IActionResult AddRoom([FromRoute] int hotelid, [FromBody] AddRoomCommandDto command)
        {
            Room room = new(command.RoomType, command.Capacity, hotelid);
            _roomCreator.CreateRoom(room);
            _unitOfWork.Commit();
            return Ok();
        }
        /// <summary>
        /// Ничего лучше не придумал, чем изменить обЪект по ссылке. Был вариант сделать в Application/RoomsUpdating/RoomsEditor второй метод TransformRoom, где в  параметрах принимается UpdateRoomCommandDto.
        /// Но чтобы эта реализовать, мне пришлость бы Application дать ссылку на API, что крайне непозволительно.
        /// </summary>
        /// <param name="hotelid"></param>
        /// <param name="roomid"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut("Hotels/{hotelid}/Rooms/{roomid}")]
        public IActionResult Update([FromRoute] int hotelid, [FromRoute] int roomid, UpdateRoomCommandDto command)
        {
            Room room = _roomRepository.GetAllRooms().Single(r => r.Id == roomid && r.HotelId == hotelid);
            room.RoomType = command.RoomType;
            room.Capacity = command.Capacity;
            _roomEditor.Update(room);
            _unitOfWork.Commit();
            return Ok();
        }

        [HttpDelete("Hotels/{hotelid}/Rooms/{roomid}")]
        public IActionResult Delete([FromRoute] int hotelid, [FromRoute] int roomid)
        {
            _roomRemover.Remove(hotelid, roomid);
            _unitOfWork.Commit();
            return Ok();
        }
    }
}
