using Hotels.Domain.Hotels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Domain.Workers
{
    public class Worker
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname{ get; set; }
        public int HotelId { get; set; }
        public Hotel? Hotel { get; set; }

        public Worker(string name, string surname, int hotelId)
        {
            Name = name;
            Surname = surname;
            HotelId = hotelId;
        }
        public void UpdateName(string name)
        {
            Name = name;
        }

        public void UpdateSurname(string surname)
        {
            Surname = surname;
        }
    }
}
