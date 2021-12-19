namespace RocketSilo.Api.Systems;

public class SystemShip
{
    public string Class { get; set; }
    public string Manufacturer { get; set; }
    public int MaxCargo { get; set; }
    public int Plating { get; set; }
    public IEnumerable<PurchaseLocation> PurchaseLocations { get; set; }
    public int Speed { get; set; }
    public string Type { get; set; }
    public int Weapons { get; set; }
}