namespace RocketSilo.Api.Loans;

public class Loan
{
    public DateTime Due { get; set; }
    public string Id { get; set; } = null!;
    public int RepaymentAmount { get; set; }
    public string Status { get; set; } = null!;
    public string Type { get; set; } = null!;
}