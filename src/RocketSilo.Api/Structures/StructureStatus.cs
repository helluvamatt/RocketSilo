namespace RocketSilo.Api.Structures;

public class StructureStatus
{
    public bool Completed { get; set; }
    public string Id { get; set; }
    public IEnumerable<StructureStatusInventory> Materials { get; set; }
    public string Name { get; set; }
    public double Stability { get; set; }
}