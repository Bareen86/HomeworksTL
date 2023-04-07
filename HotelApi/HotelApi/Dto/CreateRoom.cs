using System.ComponentModel.DataAnnotations;

namespace HotelApi.Dto
{
    public class CreateRoom
    {
        [Range(1, 2000, ErrorMessage = "Недопустимый номер комнаты")]
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }

        public int Capacity { get; set; }
    }
}
