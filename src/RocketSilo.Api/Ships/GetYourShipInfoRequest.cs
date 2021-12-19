namespace RocketSilo.Api.Ships;

[RequestUrl("/my/ships/:shipId")]
public class GetYourShipInfoRequest : IRequest<GetYourShipInfoResponse>
{
    public string ShipId { get; }

    public GetYourShipInfoRequest(string shipId)
    {
        ShipId = shipId;
    }
}

public class GetYourShipInfoResponse : IResponse
{
    public Ship Ship { get; set; }
}