namespace RocketSilo.Api.Types;

[RequestUrl("/types/goods")]
public class GetAvailableGoodsRequest : IApiRequest<GetAvailableGoodsResponse>
{
}

public class GetAvailableGoodsResponse : IApiResponse
{
    public IEnumerable<GoodDefinition> Goods { get; set; } = Enumerable.Empty<GoodDefinition>();
}