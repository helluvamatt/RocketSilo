using RocketSilo.Api.Locations;

namespace RocketSilo.Api.Systems;

[RequestUrl("/systems/:systemSymbol/locations")]
public class GetLocationInfoForASystemRequest : IRequest<GetLocationInfoForASystemResponse>
{
    public string SystemSymbol { get; }

    public GetLocationInfoForASystemRequest(string systemSymbol)
    {
        SystemSymbol = systemSymbol;
    }
}

public class GetLocationInfoForASystemResponse : IResponse
{
    public IEnumerable<Location> Locations { get; set; }
}