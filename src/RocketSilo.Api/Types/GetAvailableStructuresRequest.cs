namespace RocketSilo.Api.Types;

[RequestUrl("/types/structures")]
public class GetAvailableStructuresRequest : IRequest<GetAvailableStructuresResponse>
{
    
}

public class GetAvailableStructuresResponse : IResponse
{
    public IEnumerable<StructureDefinition> Structures { get; set; }
}