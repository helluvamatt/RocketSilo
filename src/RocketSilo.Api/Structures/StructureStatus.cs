namespace RocketSilo.Api.Structures;

public class StructureStatus
{
    public bool Completed { get; set; }
    public string Id { get; set; } = null!;
    public IEnumerable<StructureStatusInventory> Materials { get; set; } = Enumerable.Empty<StructureStatusInventory>();
    public string Name { get; set; } = null!;
    public double Stability { get; set; }
}