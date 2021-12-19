namespace RocketSilo.Api.Structures;

public class Structure
{
    public bool Active { get; set; }
    public IEnumerable<string> Consumes { get; set; }
    public string Id { get; set; }
    public IEnumerable<StructureInventory> Inventory { get; set; }
    public string Location { get; set; }
    public StructureOwner Owner { get; set; }
    public IEnumerable<string> Produces { get; set; }
    public string Status { get; set; }
    public string Type { get; set; }
}