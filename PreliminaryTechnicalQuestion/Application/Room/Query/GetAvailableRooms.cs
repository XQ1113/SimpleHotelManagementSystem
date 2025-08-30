using Microsoft.EntityFrameworkCore;
using PreliminaryTechnicalQuestion.Application.Dto;
using PreliminaryTechnicalQuestion.Application.Mapping;
using PreliminaryTechnicalQuestion.Domain;

namespace PreliminaryTechnicalQuestion.Application.Room.Query
{
    public static class GetAvailableRooms
    {
        public static async Task<IResult> GetAvailableRoomsAsync(
            AppDbContext dbContext,
            CancellationToken ct = default)
        {
            List<RoomDto> rooms = await dbContext.Room
                .AsNoTracking()
                .Where(r => r.IsAvailable)
                .Select(r => r.TRoomDto())
                .ToListAsync();

            if (rooms.Count == 0)
            {
                return Results.NotFound("No available room.");
            }

            return Results.Ok(rooms);
        }
    }
}