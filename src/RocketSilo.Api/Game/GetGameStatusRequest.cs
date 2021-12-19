namespace RocketSilo.Api.Game;

[RequestUrl("/game/status")]
public class GetGameStatusRequest : IRequest<GetGameStatusResponse>
{
    
}

public class GetGameStatusResponse : IResponse
{
    public string Status { get; set; }
}