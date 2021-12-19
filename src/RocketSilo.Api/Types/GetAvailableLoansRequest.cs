namespace RocketSilo.Api.Types;

[RequestUrl("/types/loans")]
public class GetAvailableLoansRequest : IRequest<GetAvailableLoansResponse>
{
    
}

public class GetAvailableLoansResponse : IResponse
{
    public IEnumerable<LoanDefinition> Loans { get; set; }
}