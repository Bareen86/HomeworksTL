namespace HotelApi.Domain
{
    public class Guest
    {
        public string Name { get; init; }
        public string Surname { get; init; }
        public string PhoneNumber { get; init; }
        public Guest(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }
    }
}
