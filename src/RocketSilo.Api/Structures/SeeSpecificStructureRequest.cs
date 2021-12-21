namespace RocketSilo.Api.Structures;

[RequestUrl("/structures/:structureId")]
public class SeeSpecificStructureRequest : IApiRequest<SeeSpecificStructureResponse>
{
    public string StructureId { get; }

    public SeeSpecificStructureRequest(string structureId)
    {
        StructureId = structureId;
    }
}

public class SeeSpecificStructureResponse : IApiResponse
{
    public StructureStatus Structure { get; set; } = null!;
}