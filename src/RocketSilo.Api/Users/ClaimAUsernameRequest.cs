namespace RocketSilo.Api.Users;

[RequestUrl("/users/:username/claim", RequestMethod.POST)]
public class ClaimAUsernameRequest : IRequest<ClaimAUsernameResponse>
{
    public string Username { get; }

    public ClaimAUsernameRequest(string username)
    {
        Username = username;
    }
}

public class ClaimAUsernameResponse : IResponse
{
    public string Token { get; set; }
    public User User { get; set; }
}