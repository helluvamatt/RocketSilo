using RocketSilo.Api.Ships;

namespace RocketSilo.Api.PurchaseOrders;

[RequestUrl("/my/purchase-orders", RequestMethod.POST)]
public class PlaceANewPurchaseOrderRequest : IRequest<PlaceANewPurchaseOrderResponse>
{
    public string ShipId { get; }
    public string Good { get; }
    public int Quantity { get; }
    public PlaceANewPurchaseOrderRequest(string shipId, string good, int quantity)
    {
        ShipId = shipId;
        Good = good;
        Quantity = quantity;
    }
}

public class PlaceANewPurchaseOrderResponse : IResponse
{
    public int Credits { get; set; }
    public Order Order { get; set; }
    public Ship Ship { get; set; }
}