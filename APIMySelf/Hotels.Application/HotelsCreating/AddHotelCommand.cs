using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Application.HotelsCreathing
{
    public class AddHotelCommand
    {
        public string? Name { get; init; }
        public int NumberOfStars { get; init; }
    }
}
