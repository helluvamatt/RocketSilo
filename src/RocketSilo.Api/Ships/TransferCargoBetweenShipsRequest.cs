namespace RocketSilo.Api.Ships;

[RequestUrl("/my/ships/:fromShipId/transfer", RequestMethod.POST)]
public class TransferCargoBetweenShipsRequest: IApiRequest<TransferCargoBetweenShipsResponse>
{
    public string FromShipId { get; }
    public string ToShipId { get; }
    public string Good { get; }
    public int Quantity { get; }

    public TransferCargoBetweenShipsRequest(string fromShipId, string toShipId, string good, int quantity)
    {
        FromShipId = fromShipId;
        ToShipId = toShipId;
        Good = good;
        Quantity = quantity;
    }
}

public class TransferCargoBetweenShipsResponse : IApiResponse
{
    public Ship FromShip { get; set; } = null!;
    public Ship ToShip { get; set; } = null!;
}