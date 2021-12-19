namespace RocketSilo.Api.Loans;

[RequestUrl("/my/loans/:loanId", RequestMethod.PUT)]
public class PayOffYourLoanRequest : IRequest<PayOffYourLoanResponse>
{
    public string LoanId { get; }

    public PayOffYourLoanRequest(string loanId)
    {
        LoanId = loanId;
    }
}

public class PayOffYourLoanResponse : IResponse
{
    public int Credits { get; set; }
    public IEnumerable<Loan> Loans { get; set; }
}