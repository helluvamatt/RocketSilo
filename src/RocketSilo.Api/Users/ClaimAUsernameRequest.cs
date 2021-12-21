namespace RocketSilo.Api.Users;

[RequestUrl("/users/:username/claim", RequestMethod.POST)]
public class ClaimAUsernameRequest : IApiRequest<ClaimAUsernameResponse>
{
    public string Username { get; }

    public ClaimAUsernameRequest(string username)
    {
        Username = username;
    }
}

public class ClaimAUsernameResponse : IApiResponse
{
    public string Token { get; set; } = null!;
    public User User { get; set; } = null!;
}