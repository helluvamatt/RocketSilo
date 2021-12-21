namespace RocketSilo.Api.Loans;

[RequestUrl("/my/loans/:loanId", RequestMethod.PUT)]
public class PayOffYourLoanRequest : IApiRequest<PayOffYourLoanResponse>
{
    public string LoanId { get; }

    public PayOffYourLoanRequest(string loanId)
    {
        LoanId = loanId;
    }
}

public class PayOffYourLoanResponse : IApiResponse
{
    public int Credits { get; set; }
    public IEnumerable<Loan> Loans { get; set; } = Enumerable.Empty<Loan>();
}