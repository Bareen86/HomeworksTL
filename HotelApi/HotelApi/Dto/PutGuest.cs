using HotelApi.Domain;
using System.ComponentModel.DataAnnotations;

namespace HotelApi.Dto
{
    public class PutGuest
    {
        public List<Guest> GuestsList { get; set; }
    }
}
