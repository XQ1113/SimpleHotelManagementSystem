namespace PreliminaryTechnicalQuestion.Application.Dto
{
    public class BookingDto
    {
        public BookingDto(int id, string guestName, DateTime checkInDate, DateTime checkOutDate, Domain.Entities.Room room)
        {
            Id = id;
            GuestName = guestName;
            RoomId = room.Id;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            RoomName = room.Name;
            RoomType = room.Type;
        }

        public BookingDto(int id, string guestName, int roomId, DateTime checkInDate, DateTime checkOutDate, string roomName, string roomType)
        {
            Id = id;
            GuestName = guestName;
            RoomId = roomId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            RoomName = roomName;
            RoomType = roomType;
        }

        public int Id { get; set; }
        public string GuestName { get; set; } = string.Empty;
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public string RoomType { get; set; } = string.Empty;
    }
}