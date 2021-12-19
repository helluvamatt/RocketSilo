namespace RocketSilo.Api.PurchaseOrders;

public class Order
{
    public string Good { get; set; }
    public int PricePerUnit { get; set; }
    public int Quantity { get; set; }
    public int Total { get; set; }
}