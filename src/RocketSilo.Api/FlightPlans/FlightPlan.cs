namespace RocketSilo.Api.FlightPlans;

public class FlightPlan
{
    public DateTime ArrivesAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Departure { get; set; } = null!;
    public string Destination { get; set; } = null!;
    public int Distance { get; set; }
    public int FuelConsumed { get; set; }
    public int FuelRemaining { get; set; }
    public string Id { get; set; } = null!;
    public string ShipId { get; set; } = null!;
    public DateTime? TerminatedAt { get; set; }
    public int TimeRemainingInSeconds { get; set; }
}