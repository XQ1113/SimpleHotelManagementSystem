namespace PreliminaryTechnicalQuestion.Application.Dto
{
    public class UpdateRoomDto
    {
        public UpdateRoomDto(string name, string type, bool isAvailable)
        {
            Name = name;
            Type = type;
            IsAvailable = isAvailable;
        }

        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public bool IsAvailable { get; set; }
    }
}