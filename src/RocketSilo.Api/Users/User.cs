namespace RocketSilo.Api.Users;

public class User
{
    public int Credits { get; set; }
    public DateTime JoinedAt { get; set; }
    public int ShipCount { get; set; }
    public int StructureCount { get; set; }
    public string Username { get; set; } = null!;
}