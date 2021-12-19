namespace RocketSilo.Api.Ships;

[RequestUrl("/my/ships", RequestMethod.POST)]
public class PurchaseANewShipRequest : IRequest<PurchaseANewShipResponse>
{
    public PurchaseANewShipRequest(string location, string type)
    {
        Location = location;
        Type = type;
    }
    public string Location { get; }
    public string Type { get; }
}

public class PurchaseANewShipResponse : IResponse
{
    public int Credits { get; set; }
    public Ship Ship { get; set; }
}