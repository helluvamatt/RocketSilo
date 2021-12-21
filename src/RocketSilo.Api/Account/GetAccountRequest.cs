using RocketSilo.Api.Users;

namespace RocketSilo.Api.Account;

[RequestUrl("/my/account")]
public class GetAccountRequest: IApiRequest<GetAccountResponse> { }

public class GetAccountResponse: IApiResponse
{
    public User User { get; set; } = null!;
}

