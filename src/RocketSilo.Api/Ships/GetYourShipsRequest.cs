namespace RocketSilo.Api.Ships;

[RequestUrl("/my/ships")]
public class GetYourShipsRequest : IApiRequest<GetYourShipsResponse>
{
}

public class GetYourShipsResponse : IApiResponse
{
    public IEnumerable<Ship> Ships { get; set; } = Enumerable.Empty<Ship>();
}