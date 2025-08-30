using Microsoft.EntityFrameworkCore;
using PreliminaryTechnicalQuestion.Application.Dto;
using PreliminaryTechnicalQuestion.Application.Mapping;
using PreliminaryTechnicalQuestion.Domain;

namespace PreliminaryTechnicalQuestion.Application.Room.Command
{
    public static class UpdateRoom
    {
        public static async Task<IResult> UpdateRoomAsync(
            int id,
            UpdateRoomDto updatedRoom,
            AppDbContext dbContext,
            CancellationToken ct = default)
        {
            Domain.Entities.Room? room = await dbContext.Room.Where(r => r.Id == id).FirstOrDefaultAsync();

            if (room == null)
            {
                return Results.NotFound("Room not found.");
            }

            dbContext.Entry(room).CurrentValues.SetValues(updatedRoom.TRoomEntity(id));
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute("GetRoom", new { id = room.Id }, room.TRoomDto());
        }
    }
}