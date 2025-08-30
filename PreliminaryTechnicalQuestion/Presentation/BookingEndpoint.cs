using PreliminaryTechnicalQuestion.Application.Booking.Command;
using PreliminaryTechnicalQuestion.Application.Booking.Query;

namespace PreliminaryTechnicalQuestion.Presentation
{
    public static class BookingEndpoint
    {
        public static RouteGroupBuilder MapBookingEndpoint(this WebApplication app)
        {
            var group = app.MapGroup("bookings");

            // get all bookings
            group.MapGet("/", GetBookings.GetBookingsAsync);

            // get specific booking
            group.MapGet("/{id}", GetBooking.GetBookingAsync)
            .WithName("GetBooking");

            // add booking
            group.MapPost("/", AddBooking.AddBookingAsync);

            // delete specific booking
            group.MapDelete("/{id}", DeleteBooking.DeleteBookingAsync);

            return group;
        }
    }
}