namespace RocketSilo.Api.Structures;

[RequestUrl("/my/structures", RequestMethod.POST)]
public class CreateANewStructureRequest : IApiRequest<CreateANewStructureResponse>
{
    public string Location { get; }
    public string Type { get; }

    public CreateANewStructureRequest(string location, string type)
    {
        Location = location;
        Type = type;
    }
}

public class CreateANewStructureResponse : IApiResponse
{
    public Structure Structure { get; set; } = null!;
}