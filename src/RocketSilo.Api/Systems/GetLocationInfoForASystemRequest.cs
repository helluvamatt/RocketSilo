using RocketSilo.Api.Locations;

namespace RocketSilo.Api.Systems;

[RequestUrl("/systems/:systemSymbol/locations")]
public class GetLocationInfoForASystemRequest : IApiRequest<GetLocationInfoForASystemResponse>
{
    public string SystemSymbol { get; }

    public GetLocationInfoForASystemRequest(string systemSymbol)
    {
        SystemSymbol = systemSymbol;
    }
}

public class GetLocationInfoForASystemResponse : IApiResponse
{
    public IEnumerable<Location> Locations { get; set; } = Enumerable.Empty<Location>();
}