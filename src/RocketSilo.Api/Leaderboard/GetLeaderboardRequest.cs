namespace RocketSilo.Api.Leaderboard;

[RequestUrl("/game/leaderboard/net-worth")]
public class GetLeaderboardRequest : IApiRequest<GetLeaderboardResponse>
{
}

public class GetLeaderboardResponse : IApiResponse
{
    public IEnumerable<Networth> NetWorth { get; set; } = Enumerable.Empty<Networth>();
    public IEnumerable<Networth> UserNetWorth { get; set; } = Enumerable.Empty<Networth>();
}