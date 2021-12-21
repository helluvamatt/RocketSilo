namespace RocketSilo.Api.Systems;

public class SystemShip
{
    public string Class { get; set; } = null!;
    public string Manufacturer { get; set; } = null!;
    public int MaxCargo { get; set; }
    public int Plating { get; set; }
    public IEnumerable<PurchaseLocation> PurchaseLocations { get; set; } = Enumerable.Empty<PurchaseLocation>();
    public int Speed { get; set; }
    public string Type { get; set; } = null!;
    public int Weapons { get; set; }
}