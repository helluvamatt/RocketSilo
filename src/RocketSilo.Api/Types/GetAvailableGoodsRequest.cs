namespace RocketSilo.Api.Types;

[RequestUrl("/types/goods")]
public class GetAvailableGoodsRequest : IRequest<GetAvailableGoodsResponse>
{
    
}

public class GetAvailableGoodsResponse : IResponse
{
    public IEnumerable<GoodDefinition> Goods { get; set; }
}