namespace PreliminaryTechnicalQuestion.Domain.Entities;

public class Room
{
    public Room(string name, string type, bool isAvailable)
    {
        Name = name;
        Type = type;
        IsAvailable = isAvailable;
    }

    public Room(int id, string name, string type, bool isAvailable)
    {
        Id = id;
        Name = name;
        Type = type;
        IsAvailable = isAvailable;
    }

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public bool IsAvailable { get; set; }
}