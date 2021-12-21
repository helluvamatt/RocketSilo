namespace RocketSilo.Api.Structures;

public class Structure
{
    public bool Active { get; set; }
    public IEnumerable<string> Consumes { get; set; } = Enumerable.Empty<string>();
    public string Id { get; set; } = null!;
    public IEnumerable<StructureInventory> Inventory { get; set; } = Enumerable.Empty<StructureInventory>();
    public string Location { get; set; } = null!;
    public StructureOwner Owner { get; set; } = null!;
    public IEnumerable<string> Produces { get; set; } = Enumerable.Empty<string>();
    public string Status { get; set; } = null!;
    public string Type { get; set; } = null!;
}