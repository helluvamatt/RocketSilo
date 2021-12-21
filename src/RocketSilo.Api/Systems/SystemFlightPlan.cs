namespace RocketSilo.Api.Systems;

public class SystemFlightPlan
{
    public DateTime ArrivesAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Departure { get; set; } = null!;
    public string Destination { get; set; } = null!;
    public string Id { get; set; } = null!;
    public string ShipId { get; set; } = null!;
    public string ShipType { get; set; } = null!;
    public string Username { get; set; } = null!;
}