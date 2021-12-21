namespace RocketSilo.Api.Leaderboard;

[RequestUrl("/game/leaderboard/net-worth")]
public class GetLeaderboardRequest : IApiRequest<GetLeaderboardResponse>
{
}

public class GetLeaderboardResponse : IApiResponse
{
    public IEnumerable<Networth> NetWorth { get; set; }
    public IEnumerable<Networth> UserNetWorth { get; set; }
}