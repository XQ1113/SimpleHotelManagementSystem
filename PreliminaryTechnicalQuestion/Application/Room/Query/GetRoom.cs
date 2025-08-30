using PreliminaryTechnicalQuestion.Application.Mapping;
using PreliminaryTechnicalQuestion.Domain;

namespace PreliminaryTechnicalQuestion.Application.Room.Query
{
    public static class GetRoom
    {
        public static async Task<IResult> GetRoomAsync(
            int id,
            AppDbContext dbContext,
            CancellationToken ct = default)
        {
            Domain.Entities.Room? room = await dbContext.Room.FindAsync(id);

            return room is null ? Results.NotFound("Can't find the room.") : Results.Ok(room.TRoomDto());
        }
    }
}