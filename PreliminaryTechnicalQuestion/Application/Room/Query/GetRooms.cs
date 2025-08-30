using Microsoft.EntityFrameworkCore;
using PreliminaryTechnicalQuestion.Application.Dto;
using PreliminaryTechnicalQuestion.Application.Mapping;
using PreliminaryTechnicalQuestion.Domain;

namespace PreliminaryTechnicalQuestion.Application.Room.Query
{
    public static class GetRooms
    {
        public static async Task<IResult> GetRoomsAsync(
            AppDbContext dbContext,
            CancellationToken ct = default)
        {
            List<RoomDto> rooms = await dbContext.Room
                .AsNoTracking()
                .Select(r => r.TRoomDto())
                .ToListAsync();

            if (rooms.Count == 0)
            {
                return Results.NotFound("No Room.");
            }

            return Results.Ok(rooms);
        }
    }
}