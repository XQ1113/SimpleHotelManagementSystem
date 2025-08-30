using Microsoft.EntityFrameworkCore;
using PreliminaryTechnicalQuestion.Application.Dto;
using PreliminaryTechnicalQuestion.Application.Mapping;
using PreliminaryTechnicalQuestion.Domain;

namespace PreliminaryTechnicalQuestion.Application.Booking.Command
{
    public static class AddBooking
    {
        public static async Task<IResult> AddBookingAsync(
            CreateBookingDto newBooking,
            AppDbContext dbContext)
        {
            Domain.Entities.Room? room = await dbContext.Room.FirstOrDefaultAsync(r => r.Id == newBooking.RoomId);

            if (room == null)
            {
                return Results.NotFound("Room Id not found.");
            }

            if (!room.IsAvailable)
            {
                return Results.NotFound("Room is not available.");
            }

            Domain.Entities.Booking booking = newBooking.TBookingEntity();

            dbContext.Booking.Add(booking);

            room.IsAvailable = false;

            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute("GetBooking", new { id = booking.Id }, booking.TBookingDto(room));
        }
    }
}