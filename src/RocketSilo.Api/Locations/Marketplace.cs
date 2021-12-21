namespace RocketSilo.Api.Locations;

public class Marketplace
{
    public int PricePerUnit { get; set; }
    public int PurchasePricePerUnit { get; set; }
    public int QuantityAvailable { get; set; }
    public int SellPricePerUnit { get; set; }
    public int Spread { get; set; }
    public string Symbol { get; set; } = null!;
    public int VolumePerUnit { get; set; }
}