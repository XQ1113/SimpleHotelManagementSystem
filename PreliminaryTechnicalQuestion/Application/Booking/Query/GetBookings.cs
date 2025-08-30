using Microsoft.EntityFrameworkCore;
using PreliminaryTechnicalQuestion.Application.Dto;
using PreliminaryTechnicalQuestion.Application.Mapping;
using PreliminaryTechnicalQuestion.Domain;

namespace PreliminaryTechnicalQuestion.Application.Booking.Query
{
    public static class GetBookings
    {
        public static async Task<IResult> GetBookingsAsync(
            AppDbContext dbContext,
            CancellationToken ct = default)
        {
            List<BookingDto> bookings = await dbContext.Booking
                                                       .Include(b => b.Room)
                                                       .Select(b => b.TBookingDto())
                                                       .AsNoTracking()
                                                       .ToListAsync();

            if (bookings.Count == 0)
            {
                return Results.NotFound("No Bookings.");
            }

            return Results.Ok(bookings);
        }
    }
}