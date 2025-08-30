namespace PreliminaryTechnicalQuestion.Application.Dto
{
    public class CreateBookingDto
    {
        public CreateBookingDto(string guestName, int roomId, DateTime checkInDate, DateTime checkOutDate)
        {
            GuestName = guestName;
            RoomId = roomId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }

        public string GuestName { get; set; } = string.Empty;
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}