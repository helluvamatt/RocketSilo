using RocketSilo.Api.FlightPlans;

namespace RocketSilo.Api.WarpJump;

[RequestUrl("/my/warp-jumps", RequestMethod.POST)]
public class AttemptAWarpJumpRequest: IApiRequest<AttemptAWarpJumpResponse>
{
    public string ShipId { get; }

    public AttemptAWarpJumpRequest(string shipId)
    {
        ShipId = shipId;
    }
}

public class AttemptAWarpJumpResponse : IApiResponse
{
    public FlightPlan FlightPlan { get; set; } = null!;
}