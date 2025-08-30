namespace PreliminaryTechnicalQuestion.Domain.Entities
{
    public class Booking
    {
        public Booking(string guestName, int roomId, DateTime checkInDate, DateTime checkOutDate)
        {
            GuestName = guestName;
            RoomId = roomId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }

        public int Id { get; set; }
        public string GuestName { get; set; } = string.Empty;
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public Room Room { get; set; }
    }
}