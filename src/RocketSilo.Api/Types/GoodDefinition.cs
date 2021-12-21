namespace RocketSilo.Api.Types;

public class GoodDefinition
{
    public string Name { get; set; } = null!;
    public string Symbol { get; set; } = null!;
    public int VolumePerUnit { get; set; }
}