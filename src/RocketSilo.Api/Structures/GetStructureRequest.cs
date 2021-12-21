namespace RocketSilo.Api.Structures;

[RequestUrl("/my/structures/:structureId")]
public class GetStructureRequest : IApiRequest<GetStructureResponse>
{
    public string StructureId { get; }

    public GetStructureRequest(string structureId)
    {
        StructureId = structureId;
    }
}

public class GetStructureResponse : IApiResponse
{
    public Structure Structure { get; set; } = null!;
}