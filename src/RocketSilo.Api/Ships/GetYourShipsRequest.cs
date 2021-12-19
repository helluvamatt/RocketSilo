namespace RocketSilo.Api.Ships;

[RequestUrl("/my/ships")]
public class GetYourShipsRequest : IRequest<GetYourShipsResponse>
{
}

public class GetYourShipsResponse : IResponse
{
    public IEnumerable<Ship> Ships { get; set; }
}