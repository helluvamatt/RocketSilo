using RocketSilo.Api.Structures;

namespace RocketSilo.Api.Locations;

//this api method is not yet documented on the api docs @ <https://api.spacetraders.io>
[RequestUrl("/locations/:locationSymbol/structures")]
public class GetStructureStatusesOnALocationRequest : IApiRequest<GetStructureStatusesOnALocationResponse>
{
    public string LocationSymbol { get; }

    public GetStructureStatusesOnALocationRequest(string locationSymbol)
    {
        LocationSymbol = locationSymbol;
    }
}

public class GetStructureStatusesOnALocationResponse : IApiResponse
{
    public IEnumerable<StructureStatus> Structures { get; set; }
}