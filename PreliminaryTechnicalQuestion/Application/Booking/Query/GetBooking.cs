using PreliminaryTechnicalQuestion.Application.Mapping;
using PreliminaryTechnicalQuestion.Domain;

namespace PreliminaryTechnicalQuestion.Application.Booking.Query
{
    public static class GetBooking
    {
        public static async Task<IResult> GetBookingAsync(
            int id,
            AppDbContext dbContext,
            CancellationToken ct = default)
        {
            Domain.Entities.Booking? booking = await dbContext.Booking.FindAsync(id);

            if (booking == null)
            {
                return Results.NotFound("Can't find the booking.");
            }

            Domain.Entities.Room room = (await dbContext.Room.FindAsync(booking.RoomId))!;

            return Results.Ok(booking.TBookingDto(room));
        }
    }
}