using PreliminaryTechnicalQuestion.Application.Dto;

namespace PreliminaryTechnicalQuestion.Application.Mapping
{
    public static class RoomMapping
    {
        public static RoomDto TRoomDto(this PreliminaryTechnicalQuestion.Domain.Entities.Room room)
        {
            return new(
                room.Id,
                room.Name,
                room.Type,
                room.IsAvailable);
        }

        public static Domain.Entities.Room TRoomEntity(this CreateRoomDto room)
        {
            return new(
                room.Name,
                room.Type,
                room.IsAvailable);
        }

        public static Domain.Entities.Room TRoomEntity(this UpdateRoomDto room, int id)
        {
            return new(
                id,
                room.Name,
                room.Type,
                room.IsAvailable);
        }
    }
}