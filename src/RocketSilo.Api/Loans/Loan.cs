namespace RocketSilo.Api.Loans;

public class Loan
{
    public DateTime Due { get; set; }
    public string Id { get; set; }
    public int RepaymentAmount { get; set; }
    public string Status { get; set; }
    public string Type { get; set; }
}