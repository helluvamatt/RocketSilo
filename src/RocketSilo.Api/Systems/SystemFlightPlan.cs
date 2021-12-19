namespace RocketSilo.Api.Systems;

public class SystemFlightPlan
{
    public DateTime ArrivesAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Departure { get; set; }
    public string Destination { get; set; }
    public string Id { get; set; }
    public string ShipId { get; set; }
    public string ShipType { get; set; }
    public string Username { get; set; }
}