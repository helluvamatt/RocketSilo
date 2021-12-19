namespace RocketSilo.Api.Types;

public class StructureDefinition
{
    public IEnumerable<string> AllowedLocationTypes { get; set; }
    public IEnumerable<string> Consumes { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public IEnumerable<string> Produces { get; set; }
    public string Type { get; set; }
}