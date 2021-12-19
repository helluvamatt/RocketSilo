namespace RocketSilo.Api.Ships;

[RequestUrl("/my/ships/:fromShipId/transfer", RequestMethod.POST)]
public class TransferCargoBetweenShipsRequest: IRequest<TransferCargoBetweenShipsResponse>
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

public class TransferCargoBetweenShipsResponse : IResponse
{
    public Ship FromShip { get; set; }
    public Ship ToShip { get; set; }
}