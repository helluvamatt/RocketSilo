namespace RocketSilo.Api.Types;

public class StructureDefinition
{
    public IEnumerable<string> AllowedLocationTypes { get; set; } = Enumerable.Empty<string>();
    public IEnumerable<string> Consumes { get; set; } = Enumerable.Empty<string>();
    public string Name { get; set; } = null!;
    public int Price { get; set; }
    public IEnumerable<string> Produces { get; set; } = Enumerable.Empty<string>();
    public string Type { get; set; } = null!;
}