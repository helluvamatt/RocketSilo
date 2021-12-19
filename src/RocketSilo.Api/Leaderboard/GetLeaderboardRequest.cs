namespace RocketSilo.Api.Leaderboard;

[RequestUrl("/game/leaderboard/net-worth")]
public class GetLeaderboardRequest : IRequest<GetLeaderboardResponse>
{
}

public class GetLeaderboardResponse : IResponse
{
    public IEnumerable<Networth> NetWorth { get; set; }
    public IEnumerable<Networth> UserNetWorth { get; set; }
}