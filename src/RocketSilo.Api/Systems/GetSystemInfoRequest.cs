namespace RocketSilo.Api.Systems;

[RequestUrl("/systems/:systemSymbol")]
public class GetSystemInfoRequest : IRequest<GetSystemInfoResponse>
{
    public string SystemSymbol { get; }

    public GetSystemInfoRequest(string systemSymbol)
    {
        SystemSymbol = systemSymbol;
    }
}

public class GetSystemInfoResponse : IResponse
{
    public SystemInfo System { get; set; }
}