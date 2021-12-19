namespace RocketSilo.Api.Locations;

[RequestUrl("/locations/:locationSymbol/ships")]
public class GetTheShipsAtALocationRequest : IRequest<GetTheShipsAtALocationResponse>
{
    public string LocationSymbol { get; }

    public GetTheShipsAtALocationRequest(string locationSymbol)
    {
        LocationSymbol = locationSymbol;
    }
}

public class GetTheShipsAtALocationResponse : IResponse
{
    public IEnumerable<LocationsShip> Ships { get; set; }
}