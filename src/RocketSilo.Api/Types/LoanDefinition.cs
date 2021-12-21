namespace RocketSilo.Api.Types;

public class LoanDefinition
{
    public int Amount { get; set; }
    public bool CollateralRequired { get; set; }
    public int Rate { get; set; }
    public int TermInDays { get; set; }
    public string Type { get; set; } = null!;
}