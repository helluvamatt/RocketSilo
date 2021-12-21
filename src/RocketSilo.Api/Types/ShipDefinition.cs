namespace RocketSilo.Api.Types;

public class ShipDefinition : IComparable, IComparable<ShipDefinition>
{
    public string Class { get; set; } = null!;
    public string Manufacturer { get; set; } = null!;
    public int MaxCargo { get; set; }
    public int Plating { get; set; }
    public int Speed { get; set; }
    public string Type { get; set; } = null!;
    public int Weapons { get; set; }

    public int CompareTo(object? obj)
    {
        if (obj == null)
        {
            return 1;
        }

        if (obj is not ShipDefinition other)
        {
            throw new ArgumentException("Object is not a ShipDefinition");
        }

        return CompareTo(other);
    }

    public int CompareTo(ShipDefinition? other)
    {
        if (other == null)
        {
            return 1;
        }
        
        if(Class.Length > other.Class.Length)
        {
            return 1;
        }

        if(Class.Length < other.Class.Length)
        {
            return -1;
        }

        return string.Compare(Class, other.Class, StringComparison.Ordinal);
    }
}