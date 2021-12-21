namespace RocketSilo.Api.Locations;

public class Location
{
    public bool AllowsConstruction { get; set; }
    public int DockedShips { get; set; }
    public string Name { get; set; } = null!;
    public string Symbol { get; set; } = null!;
    public string Type { get; set; } = null!;
    public int X { get; set; }
    public int Y { get; set; }
    public List<string> Traits { get; set; } = new();
    public List<string>? Messages { get; set; }
}