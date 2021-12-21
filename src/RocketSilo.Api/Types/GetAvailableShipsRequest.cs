namespace RocketSilo.Api.Types;

[RequestUrl("/types/ships")]
public class GetAvailableShipsRequest : IApiRequest<GetAvailableShipsResponse>
{
}

public class GetAvailableShipsResponse : IApiResponse
{
    public IEnumerable<ShipDefinition> Ships { get; set; } = Enumerable.Empty<ShipDefinition>();
}