namespace RocketSilo.Api.Ships;

[RequestUrl("/my/ships/:shipId/jettison", RequestMethod.POST)]
public class JettisonCargoRequest: IApiRequest<JettisonCargoResponse>
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

public class JettisonCargoResponse : IApiResponse
{
    public string Good { get; set; } = null!;
    public int QuantityRemaining { get; set; }
    public string ShipId { get; set; } = null!;
}