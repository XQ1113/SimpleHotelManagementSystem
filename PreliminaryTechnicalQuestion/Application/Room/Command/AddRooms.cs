using PreliminaryTechnicalQuestion.Application.Dto;
using PreliminaryTechnicalQuestion.Application.Mapping;
using PreliminaryTechnicalQuestion.Domain;

namespace PreliminaryTechnicalQuestion.Application.Room.Command
{
    public static class AddRooms
    {
        public static async Task<IResult> AddRoomsAsync(
            List<CreateRoomDto> newRooms,
            AppDbContext dbContext)
        {
            List<Domain.Entities.Room> rooms = newRooms.Select(nr => nr.TRoomEntity()).ToList();

            await dbContext.Room.AddRangeAsync(rooms);
            await dbContext.SaveChangesAsync();

            return Results.Ok(rooms.Select(r => r.TRoomDto()));
        }
    }
}