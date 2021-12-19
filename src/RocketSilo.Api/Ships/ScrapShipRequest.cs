namespace RocketSilo.Api.Ships;

[RequestUrl("/my/ships/:shipId/", RequestMethod.DELETE)]
public class ScrapShipRequest : IRequest<ScrapShipResponse>
{
    public string ShipId { get; }

    public ScrapShipRequest(string shipId)
    {
        ShipId = shipId;
    }
}

public class ScrapShipResponse : IResponse
{
    public string Success { get; set; }
}