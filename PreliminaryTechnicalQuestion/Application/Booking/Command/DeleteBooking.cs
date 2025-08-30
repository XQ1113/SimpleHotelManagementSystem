using Microsoft.EntityFrameworkCore;
using PreliminaryTechnicalQuestion.Domain;

namespace PreliminaryTechnicalQuestion.Application.Booking.Command
{
    public static class DeleteBooking
    {
        public static async Task<IResult> DeleteBookingAsync(
            int id,
            AppDbContext dbContext,
            CancellationToken ct = default)
        {
            Domain.Entities.Booking? booking = await dbContext.Booking.Where(b => b.Id == id).FirstOrDefaultAsync();

            if (booking == null)
            {
                return Results.NotFound("Booking is not found.");
            }

            Domain.Entities.Room room = (await dbContext.Room.FindAsync(booking.RoomId))!;

            room.IsAvailable = true;

            dbContext.Booking.Remove(booking);

            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        }
    }
}