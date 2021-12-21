namespace RocketSilo.Api.Ships;

public class Ship
{
    public List<ShipCargo> Cargo { get; set; }
    public string Class { get; set; }
    public string Id { get; set; }
    public string Location { get; set; }
    public string Manufacturer { get; set; }
    public int MaxCargo { get; set; }
    public int Plating { get; set; }
    public int SpaceAvailable { get; set; }
    public int Speed { get; set; }
    public string Type { get; set; }
    public int Weapons { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public string? FlightPlanId { get; set; }
}