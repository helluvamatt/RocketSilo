namespace RocketSilo.Api.Structures;

[RequestUrl("/structures/:structureId")]
public class SeeSpecificStructureRequest : IRequest<SeeSpecificStructureResponse>
{
    public string StructureId { get; }

    public SeeSpecificStructureRequest(string structureId)
    {
        StructureId = structureId;
    }
}

public class SeeSpecificStructureResponse : IResponse
{
    public StructureStatus Structure { get; set; }
}