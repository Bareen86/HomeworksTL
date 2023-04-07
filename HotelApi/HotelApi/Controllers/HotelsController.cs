using HotelApi.Domain;
using HotelApi.Dto;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [ApiController]
    [Route("[controller]/")]
    public class HotelsController : Controller
    {
        private static readonly List<Hotel> _hotel = new();
        private static int intIncrement = 0;
        [HttpGet]
        public IActionResult Get()
        {
            var result = _hotel.Select(h => new { h.Id, h.Name, h.AmountOfRooms, h.RoomsInfo }).ToList();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetHotelById(int id)
        {
            if (_hotel.Count != 0)
            {
                var result = _hotel.Where(h => h.Id == id).ToList();
                return Ok(result);
            }
            return BadRequest("Отелей нет!");
        }
        [HttpPost]
        public IActionResult AddHotel([FromBody] CreateHotel createHotel)
        {
            intIncrement++;
            var hotel = new Hotel(intIncrement, createHotel.Name, createHotel.AmountOfRooms);
            _hotel.Add(hotel);
            return Ok();
        }
        /// <summary>
        /// Add hotel's room by hotel id and validate existance of room.
        /// </summary>
        /// <param name="id"></param>.
        /// <returns></returns>
        [HttpGet("{id}/rooms")]
        public IActionResult GetHotelRooms(int id)
        {
            if (_hotel.Count != 0)
            {
                if (_hotel[id - 1].RoomsInfo != null)
                {
                    var result = _hotel[id - 1].RoomsInfo.Select(r => new { r.RoomNumber, r.RoomType, r.Capacity }).ToList();
                    return Ok(result);
                }
                return BadRequest("В отеле нет номеров");
            }
            return BadRequest("Отелей нет!");
        }
        [HttpPost("{id}/rooms")]
        public IActionResult AddHotelRoom(int id, [FromBody] CreateRoom createRoom)
        {
            if (_hotel.Count != 0)
            {
                RoomInfo roomInfo = new RoomInfo(createRoom.RoomNumber, createRoom.RoomType, createRoom.Capacity) { };
                if (_hotel[id - 1].RoomsInfo != null)
                {
                    var validatedRoom = _hotel[id - 1].RoomsInfo.Where(r => r.RoomNumber != createRoom.RoomNumber).ToList();
                    if (validatedRoom.Count > 0)
                    {
                        _hotel[id - 1].RoomsInfo.Add(roomInfo);
                        return Ok();
                    }
                    return BadRequest("Такой номер в отеле уже существует! Введите другой номер комнаты.");
                }
                else
                {
                    _hotel[id - 1].RoomsInfo = new List<RoomInfo>
                {
                    roomInfo
                };
                    return Ok();
                }
            }
            return BadRequest("Отелей нет");
        }
        [HttpPut("{id}/rooms/{roomNumber}")]
        public IActionResult PutHotelRoom(int id, [FromBody] PutRoom putRoom, int roomNumber)
        {
            if (_hotel.Count != 0)
            {
                if (_hotel[id - 1].RoomsInfo != null)
                {
                    RoomInfo findRoom = _hotel[id - 1].RoomsInfo.Single(r => r.RoomNumber == roomNumber);
                    int indexOfRoom = _hotel[id - 1].RoomsInfo.IndexOf(findRoom);
                    var hotelRoom = new RoomInfo(roomNumber, putRoom.RoomType, putRoom.Capacity) { };
                    _hotel[id - 1].RoomsInfo[indexOfRoom] = hotelRoom;
                    return Ok();
                }
                return BadRequest($"Такой комнаты в отеле нет");
            }
            return BadRequest("Отелей нет!");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteHotel(int id)
        {
            if (id == 0)
            {
                return BadRequest("Нельзя удалить отель, с id = 0");
            }
            _hotel.RemoveAt(id - 1);
            return Ok();
        }
        [HttpDelete("{id}/rooms/{roomNumber}")]
        public IActionResult DeleteHotelRoom(int id, int roomNumber)//
        {
            if (_hotel.Count !=0)
            {
                if (_hotel[id - 1].RoomsInfo != null)
                {
                    _hotel[id - 1].RoomsInfo.RemoveAll(r => r.RoomNumber == roomNumber);
                    return Ok();
                }
                return BadRequest("Нечего удалять");
            }
            return BadRequest("Отелей нет!");
        }
        [HttpGet("{id}/rooms/{room_number}")]
        public IActionResult GetHotelRoom(int id, int room_number)
        {
            if (_hotel.Count != 0)
            {
                if (_hotel[id - 1].RoomsInfo != null)
                {
                    RoomInfo findRoom = _hotel[id - 1].RoomsInfo.Single(r => r.RoomNumber == room_number);
                    int indexOfRoom = _hotel[id - 1].RoomsInfo.IndexOf(findRoom);
                    RoomInfo hotelRoom = _hotel[id - 1].RoomsInfo[indexOfRoom];
                    return Ok(hotelRoom);
                }
                return BadRequest($"В {id} отеле нет комнат");
            }
            return BadRequest("Отелей нет!");
        }
        // Add in  API guest Entity.----------------------------------------------------------------------------------------------------
        [HttpGet("{id}/rooms/{room_number}/guests")]
        public IActionResult GetGuests(int id, int room_number)
        {
            if (_hotel.Count != 0)
            {
                if (_hotel[id - 1].RoomsInfo != null)
                {
                    RoomInfo findRoom = _hotel[id - 1].RoomsInfo.Single(r => r.RoomNumber == room_number);
                    int indexOfRoom = _hotel[id - 1].RoomsInfo.IndexOf(findRoom);
                    var result = _hotel[id - 1].RoomsInfo[indexOfRoom].Guests.Select(g => new { g.Name, g.Surname, g.PhoneNumber }).ToList();
                    return Ok();
                }
                return BadRequest("Такой комнаты в отеле нет!");
            }
            return BadRequest("Отелей нет!");
        }
        [HttpPost("{id}/rooms/{room_number}/guests")]
        public IActionResult PostGuests(int id, int room_number, [FromBody] CreateGuest guestsList)
        {
            if (_hotel.Count != 0)
            {
                if (_hotel[id - 1].RoomsInfo != null)
                {
                    RoomInfo findRoom = _hotel[id - 1].RoomsInfo.Single(r => r.RoomNumber == room_number);
                    int indexOfRoom = _hotel[id - 1].RoomsInfo.IndexOf(findRoom);
                    List<Guest> guests = guestsList.GuestsList;
                    _hotel[id - 1].RoomsInfo[indexOfRoom].Guests = guests;
                    return Ok();
                }
                return BadRequest("Такой комнаты в отеле нет!");
            }
            return BadRequest("Отелей нет!");
        }
        [HttpPut("{id}/rooms/{room_number}/guests")]
        public IActionResult PutGuestByName(int id, int room_number, [FromBody] CreateGuest putGuest)
        {
            if (_hotel.Count != 0)
            {
                if (_hotel[id - 1].RoomsInfo != null)
                {
                    RoomInfo findRoom = _hotel[id - 1].RoomsInfo.Single(r => r.RoomNumber == room_number);
                    int indexOfRoom = _hotel[id - 1].RoomsInfo.IndexOf(findRoom);
                    _hotel[id - 1].RoomsInfo[indexOfRoom].Guests = putGuest.GuestsList;
                    return Ok();
                }
                return BadRequest("Такой комнаты в отеле нет!");
            }
            return BadRequest("Отелей нет!");
        }
        [HttpDelete("{id}/rooms/{room_number}/guests")]
        public IActionResult DeleteGuest(int id, int room_number)//
        {
            if (_hotel.Count != 0)
            {
                if (_hotel[id - 1].RoomsInfo != null)
                {
                    RoomInfo findRoom = _hotel[id - 1].RoomsInfo.Single(r => r.RoomNumber == room_number);
                    int indexOfRoom = _hotel[id - 1].RoomsInfo.IndexOf(findRoom);
                    _hotel[id - 1].RoomsInfo[indexOfRoom].Guests = null;
                    return Ok();
                }
                return BadRequest("Такой комнаты в отеле нет!");
            }
            return BadRequest("Отелей нет!");
        }
    }
}
