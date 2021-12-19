namespace RocketSilo.Api.Types;

[RequestUrl("/types/ships")]
public class GetAvailableShipsRequest : IRequest<GetAvailableShipsResponse>
{
    
}

public class GetAvailableShipsResponse : IResponse
{
    public IEnumerable<ShipDefinition> Ships { get; set; }
}