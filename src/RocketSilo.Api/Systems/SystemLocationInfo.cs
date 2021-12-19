namespace RocketSilo.Api.Systems;

public class SystemLocationInfo
{
    public bool AllowsConstruction { get; set; }
    public string Name { get; set; }
    public string Symbol { get; set; }
    public string Type { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
}