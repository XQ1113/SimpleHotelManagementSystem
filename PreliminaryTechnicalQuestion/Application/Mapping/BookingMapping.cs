using PreliminaryTechnicalQuestion.Application.Dto;

namespace PreliminaryTechnicalQuestion.Application.Mapping
{
    public static class BookingMapping
    {
        public static BookingDto TBookingDto(this Domain.Entities.Booking booking)
        {
            return new(
                 booking.Id,
                 booking.GuestName,
                 booking.RoomId,
                 booking.CheckInDate,
                 booking.CheckOutDate,
                 booking.Room.Name,
                 booking.Room.Type);
        }

        public static BookingDto TBookingDto(this Domain.Entities.Booking booking, Domain.Entities.Room room)
        {
            return new(
                 booking.Id,
                 booking.GuestName,
                 booking.CheckInDate,
                 booking.CheckOutDate,
                 room);
        }

        public static Domain.Entities.Booking TBookingEntity(this CreateBookingDto booking)
        {
            return new(
                booking.GuestName,
                booking.RoomId,
                booking.CheckInDate,
                booking.CheckOutDate);
        }
    }
}