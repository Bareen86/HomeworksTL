using HotelApi.Domain;
using System.ComponentModel.DataAnnotations;

namespace HotelApi.Dto
{
    public class CreateGuest
    {
        public List<Guest> GuestsList { get; set; }
    }
}
