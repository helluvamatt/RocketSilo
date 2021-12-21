namespace RocketSilo.Api.Ships;

public class ShipCargo
{
    public string Good { get; set; } = null!;
    public int Quantity { get; set; }
    public int TotalVolume { get; set; }
}