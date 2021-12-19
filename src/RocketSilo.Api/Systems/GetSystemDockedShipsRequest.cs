namespace RocketSilo.Api.Systems;

[RequestUrl("/systems/:systemSymbol/ships")]
public class GetSystemDockedShipsRequest : IRequest<GetSystemDockedShipsResponse>
{
    public string SystemSymbol { get; }
    public GetSystemDockedShipsRequest(string systemSymbol)
    {
        SystemSymbol = systemSymbol;
    }
}

public class GetSystemDockedShipsResponse : IResponse
{
    public IEnumerable<SystemDockedShip> Ships { get; set; }
}