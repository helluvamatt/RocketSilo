using RocketSilo.Api.Ships;

namespace RocketSilo.Api.Structures;

[RequestUrl("/my/structures/:structureId/deposit", RequestMethod.POST)]
public class DepositGoodToAStructureYouOwnRequest: IApiRequest<DepositGoodToAStructureYouOwnResponse>
{
    public int StructureId { get; }
    public int ShipId { get; }
    public string Good { get; }
    public int Quantity { get; }

    public DepositGoodToAStructureYouOwnRequest(int structureId, int shipId, string good, int quantity)
    {
        StructureId = structureId;
        ShipId = shipId;
        Good = good;
        Quantity = quantity;
    }
}

public class DepositGoodToAStructureYouOwnResponse : IApiResponse
{
    public StructureInventory Deposit { get; set; } = null!;
    public Ship Ship { get; set; } = null!;
    public Structure Structure { get; set; } = null!;
}