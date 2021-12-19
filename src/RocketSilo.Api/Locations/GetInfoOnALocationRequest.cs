namespace RocketSilo.Api.Locations;

[RequestUrl("/locations/:locationSymbol")]
public class GetInfoOnALocationRequest : IRequest<GetInfoOnALocationResponse>
{
    public string LocationSymbol { get; }

    public GetInfoOnALocationRequest(string locationSymbol)
    {
        LocationSymbol = locationSymbol;
    }
}

public class GetInfoOnALocationResponse : IResponse
{
    public Location Location { get; set; }
}