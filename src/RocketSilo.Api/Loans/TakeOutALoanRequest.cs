namespace RocketSilo.Api.Loans;

[RequestUrl("/my/loans", RequestMethod.POST)]
public class TakeOutALoanRequest: IRequest<TakeOutALoanResponse>
{
    public TakeOutALoanRequest(string type)
    {
        Type = type;
    }
    public string Type { get; }
}

public class TakeOutALoanResponse : IResponse
{
    public int Credits { get; set; }
    public IEnumerable<Loan> Loans { get; set; }
}