using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.RoomsUpdatinng
{
    public class UpdateRoomCommand
    {
        public int roomId { get; init; }
        public string RoomType { get; init; }
        public int Capacity { get; init; }
    }
}
