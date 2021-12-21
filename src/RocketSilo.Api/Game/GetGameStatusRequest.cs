namespace RocketSilo.Api.Game;

[RequestUrl("/game/status")]
public class GetGameStatusRequest : IApiRequest<GetGameStatusResponse> { }

public class GetGameStatusResponse : IApiResponse
{
    public string Status { get; set; } = null!;
}