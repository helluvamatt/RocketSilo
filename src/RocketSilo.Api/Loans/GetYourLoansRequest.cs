namespace RocketSilo.Api.Loans;

[RequestUrl("/my/loans")]
public class GetYourLoansRequest : IRequest<GetYourLoansResponse>
{
    
}

public class GetYourLoansResponse : IResponse
{
    public IEnumerable<Loan> Loans { get; set; }
}