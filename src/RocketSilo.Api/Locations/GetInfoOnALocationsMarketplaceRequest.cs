namespace RocketSilo.Api.Locations;

[RequestUrl("/locations/:locationSymbol/marketplace")]
public class GetInfoOnALocationsMarketplaceRequest : IRequest<GetInfoOnALocationsMarketplaceResponse>
{
    public string LocationSymbol { get; }

    public GetInfoOnALocationsMarketplaceRequest(string locationSymbol)
    {
        LocationSymbol = locationSymbol;
    }
}

public class GetInfoOnALocationsMarketplaceResponse : IResponse
{
    public IEnumerable<Marketplace>? Marketplace { get; set; }
}