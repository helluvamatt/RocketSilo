namespace RocketSilo.Api.Loans;

[RequestUrl("/my/loans", RequestMethod.POST)]
public class TakeOutALoanRequest: IApiRequest<TakeOutALoanResponse>
{
    public TakeOutALoanRequest(string type)
    {
        Type = type;
    }
    public string Type { get; }
}

public class TakeOutALoanResponse : IApiResponse
{
    public int Credits { get; set; }
    public IEnumerable<Loan> Loans { get; set; } = Enumerable.Empty<Loan>();
}