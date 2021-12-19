using RocketSilo.Api.FlightPlans;

namespace RocketSilo.Api.WarpJump;

[RequestUrl("/my/warp-jumps", RequestMethod.POST)]
public class AttemptAWarpJumpRequest: IRequest<AttemptAWarpJumpResponse>
{
    public string ShipId { get; }

    public AttemptAWarpJumpRequest(string shipId)
    {
        ShipId = shipId;
    }
}

public class AttemptAWarpJumpResponse : IResponse
{
    public FlightPlan FlightPlan { get; set; }
}