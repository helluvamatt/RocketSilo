namespace RocketSilo.Api.Systems;

[RequestUrl("/systems/:systemSymbol/ship-listings")]
public class GetAllAvailableShipsInSystemRequest : IRequest<GetAllAvailableShipsInSystemResponse>
{
    public string SystemSymbol { get; }
    public GetAllAvailableShipsInSystemRequest(string systemSymbol)
    {
        SystemSymbol = systemSymbol;
    }
}

public class GetAllAvailableShipsInSystemResponse : IResponse
{
    public IEnumerable<SystemShip> ShipListings { get; set; }
}