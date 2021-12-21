namespace RocketSilo.Api.Ships;

public class Ship
{
    public List<ShipCargo> Cargo { get; set; } = new();
    public string Class { get; set; } = null!;
    public string Id { get; set; } = null!;
    public string Location { get; set; } = null!;
    public string Manufacturer { get; set; } = null!;
    public int MaxCargo { get; set; }
    public int Plating { get; set; }
    public int SpaceAvailable { get; set; }
    public int Speed { get; set; }
    public string Type { get; set; } = null!;
    public int Weapons { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public string? FlightPlanId { get; set; }
}