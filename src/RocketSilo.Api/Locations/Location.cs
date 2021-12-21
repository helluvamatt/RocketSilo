namespace RocketSilo.Api.Locations;

public class Location
{
    public bool AllowsConstruction { get; set; }
    public int DockedShips { get; set; }
    public string Name { get; set; }
    public string Symbol { get; set; }
    public string Type { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public List<string> Traits { get; set; }
    public List<string>? Messages { get; set; }
}