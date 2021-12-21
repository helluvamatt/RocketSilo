namespace RocketSilo.Api.Systems;

public class SystemLocationInfo
{
    public bool AllowsConstruction { get; set; }
    public string Name { get; set; } = null!;
    public string Symbol { get; set; } = null!;
    public string Type { get; set; } = null!;
    public int X { get; set; }
    public int Y { get; set; }
}