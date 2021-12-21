using RocketSilo.Api.PurchaseOrders;
using RocketSilo.Api.Ships;

namespace RocketSilo.Api.SellOrders;

[RequestUrl("/my/sell-orders", RequestMethod.POST)]
public class PlaceANewSellOrderRequest : IApiRequest<PlaceANewSellOrderResponse>
{
    public string ShipId { get; }
    public string Good { get; }
    public int Quantity { get; }
    public PlaceANewSellOrderRequest(string shipId, string good, int quantity)
    {
        ShipId = shipId;
        Good = good;
        Quantity = quantity;
    }
}

public class PlaceANewSellOrderResponse : IApiResponse
{
    public int Credits { get; set; }
    public Order Order { get; set; } = null!;
    public Ship Ship { get; set; } = null!;
}