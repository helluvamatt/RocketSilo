namespace RocketSilo.Api.Ships;

[RequestUrl("/my/ships/:shipId/", RequestMethod.DELETE)]
public class ScrapShipRequest : IApiRequest<ScrapShipResponse>
{
    public string ShipId { get; }

    public ScrapShipRequest(string shipId)
    {
        ShipId = shipId;
    }
}

public class ScrapShipResponse : IApiResponse
{
    public string Success { get; set; } = null!;
}