namespace RocketSilo.Api.Locations;

[RequestUrl("/locations/:locationSymbol/marketplace")]
public class GetInfoOnALocationsMarketplaceRequest : IApiRequest<GetInfoOnALocationsMarketplaceResponse>
{
    public string LocationSymbol { get; }

    public GetInfoOnALocationsMarketplaceRequest(string locationSymbol)
    {
        LocationSymbol = locationSymbol;
    }
}

public class GetInfoOnALocationsMarketplaceResponse : IApiResponse
{
    public IEnumerable<Marketplace>? Marketplace { get; set; }
}