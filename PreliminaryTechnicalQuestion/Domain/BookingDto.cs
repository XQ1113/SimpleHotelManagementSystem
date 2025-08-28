namespace PreliminaryTechnicalQuestion.Domain
{
    public class BookingDto
    {
        public int Id { get; set; }
        public string GuestName { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public RoomDto Room { get; set; }
    }
}