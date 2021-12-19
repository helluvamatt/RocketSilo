namespace RocketSilo.Api.Structures;

[RequestUrl("/my/structures")]
public class GetAllMyStructuresRequest: IRequest<GetAllMyStructuresResponse>
{
}

public class GetAllMyStructuresResponse : IResponse
{
    public IEnumerable<Structure> Structures { get; set; }
}