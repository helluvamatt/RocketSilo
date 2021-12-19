namespace RocketSilo.Api.Structures;

[RequestUrl("/my/structures/:structureId")]
public class GetStructureRequest : IRequest<GetStructureResponse>
{
    public string StructureId { get; }

    public GetStructureRequest(string structureId)
    {
        StructureId = structureId;
    }
}

public class GetStructureResponse : IResponse
{
    public Structure Structure { get; set; }
}