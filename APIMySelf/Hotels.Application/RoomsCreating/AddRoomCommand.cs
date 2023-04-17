using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.RoomsCreating
{
    public class AddRoomCommand
    {
        public string? RoomType { get; init; }
        public int Capacity { get; init; }
        public int HotelId { get; init; }
    }
}
