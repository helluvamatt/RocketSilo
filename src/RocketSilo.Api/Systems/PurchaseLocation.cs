namespace RocketSilo.Api.Systems;

public class PurchaseLocation
{
    public string Location { get; set; } = null!;
    public int Price { get; set; }
    public string System { get; set; } = null!;
}