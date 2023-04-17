using Hotels.Domain.Workers;
using System.ComponentModel.DataAnnotations;

namespace Hotels.Domain.Hotels
{
    public class Hotel
    {
        public int Id { get;  set; }
        public string  Name { get;   set; }
        public int NumberOfStars{ get;  set; }
        public List<Room> Rooms { get; set; } = new List<Room>();
        public List<Worker> Workers { get; set; } = new List<Worker> { };
        public Hotel(string name, int numberOfStars)
        {
            Name = name;
            NumberOfStars = numberOfStars;
        }
        
        public Hotel(int id,string name, int numberOfStars)
        {
            Id = id;
            Name = name;
            NumberOfStars = numberOfStars;
        }
        
        public void UpdateName(string name)
        {
            Name = name;
        }

        public  void UpdateNumberOfStars(int numberOfStars)
        {
            NumberOfStars = numberOfStars;
        }
    }
}
