using PreliminaryTechnicalQuestion.Application.Room.Command;
using PreliminaryTechnicalQuestion.Application.Room.Query;

namespace PreliminaryTechnicalQuestion.Presentation
{
    public static class RoomEndpoint
    {
        public static RouteGroupBuilder MapRoomEndpoint(this WebApplication app)
        {
            var group = app.MapGroup("rooms");

            // get all rooms
            group.MapGet("/", GetRooms.GetRoomsAsync);

            // get all available rooms
            group.MapGet("/available", GetAvailableRooms.GetAvailableRoomsAsync);

            // get specific room
            group.MapGet("/{id}", GetRoom.GetRoomAsync)
            .WithName("GetRoom");

            // add rooms
            group.MapPost("/", AddRooms.AddRoomsAsync);

            // update specific room
            group.MapPut("/{id}", UpdateRoom.UpdateRoomAsync);

            return group;
        }
    }
}