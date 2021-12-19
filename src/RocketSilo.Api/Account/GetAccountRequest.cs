using RocketSilo.Api.Users;

namespace RocketSilo.Api.Account;

[RequestUrl("/my/account")]
public class GetAccountRequest: IRequest<GetAccountResponse>
{
    
}

public class GetAccountResponse: IResponse
{
    public User User { get; set; }
}

