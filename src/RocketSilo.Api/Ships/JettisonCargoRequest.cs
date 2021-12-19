namespace RocketSilo.Api.Ships;

[RequestUrl("/my/ships/:shipId/jettison", RequestMethod.POST)]
public class JettisonCargoRequest: IRequest<JettisonCargoResponse>
{
    public string ShipId { get; }
    public string Good { get; }
    public int Quantity { get; }

    public JettisonCargoRequest(string shipId, string good, int quantity)
    {
        ShipId = shipId;
        Good = good;
        Quantity = quantity;
    }
}

public class JettisonCargoResponse : IResponse
{
    public string Good { get; set; }
    public int QuantityRemaining { get; set; }
    public string ShipId { get; set; }
}